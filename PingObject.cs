using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;

namespace ServerPing
{
    //public delegate void CompletedEventHandler(object sender, CompletedEventArgs e);

    public class PingObject : IDisposable
    {
        // -------------------------------
        // Timer
        // -------------------------------
        private AutoResetEvent autoEvent = new AutoResetEvent(false);
        //private StatusChecker statusChecker
        private Timer timerPing;
        private TimerCallback tcb;
        // -------------------------------

        // -------------------------------
        // Ping
        // -------------------------------
        private byte[] packetData = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        private AutoResetEvent resetEvent = new AutoResetEvent(false);
        private Ping pingSender;
        private PingOptions packetOptions;
        // -------------------------------

        private int _pingResult;
        private DateTime _lastPing;
        private long totalTimeout;
        private byte pingsSent;

        public string Name { get; set; }                        // PingObject name
        public string IPAddress { get; set; }                   // IPAddress or hostname
        public int PingResult { get { return _pingResult; } }   // Average value of ping roundtimetrip
        public bool Enable { get; set; }                        // PingObject enable
        public Image Status { get; set; }                       // PingObject image status
        public DateTime LastPing { get { return _lastPing; } }  // Date and timeof last ping result
        public int PingCount { get; set; }                      // Ping count

        private bool disposed = false;

        public event EventHandler<CompletedEventArgs> Completed;

        public PingObject(string name, string endpoint, int count)
        {
            Name = name;
            IPAddress = endpoint;
            PingCount = count;

            pingsSent = 0;
            totalTimeout = 0;

            pingSender = new Ping();
            pingSender.PingCompleted += new PingCompletedEventHandler(pingSender_Complete);

            packetOptions = new PingOptions(50, true);

            Status = Properties.Resources.offline;

            tcb = SendPing;
            timerPing = new Timer(tcb, autoEvent, -1, 0);
        }

        public void Start()
        {
            timerPing.Change(1000, 30000);
            Enable = true;
        }

        public void Stop()
        {
            timerPing.Change(-1, 0);
            Enable = false;
            Status = Properties.Resources.offline;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Method for timer
        private void SendPing(Object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;

            if (!Enable)
            {
                autoEvent.Set();
            }
            else
            {
                SendPing();
            }
        }

        private void SendPing()
        {
            pingSender.SendAsync(IPAddress, 4000, packetData, packetOptions, resetEvent);
        }

        // Event for ping.
        private void pingSender_Complete(object sender, PingCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // TODO: Operation was canceled
                Status = Properties.Resources.offline;

                // The main thread can resume
                ((AutoResetEvent)e.UserState).Set();
            }
            else if (e.Error != null)
            {
                // TODO: An error occured
                Status = Properties.Resources.offline;

                // The main thread can resume
                ((AutoResetEvent)e.UserState).Set();
            }
            else
            {
                PingReply pingResponse = e.Reply;

                if (pingResponse == null)
                {
                    // No response
                }
                else if (pingResponse.Status == IPStatus.Success)
                {
                    // We got a response
                    totalTimeout += e.Reply.RoundtripTime;
                }
                else
                {
                    // Ping was notsuccess
                }
            }
            pingsSent++;
            if (pingsSent < (PingCount - 1))
            {
                SendPing();
            }
            else
            {
                CompletedEventArgs args = new CompletedEventArgs();
                args.TotalTimeout = totalTimeout;
                args.AvgTimeout = _pingResult = (int)(totalTimeout / pingsSent);
                args.LastPing = _lastPing = DateTime.Now;

                if (_pingResult > 0 && _pingResult < 30)
                {
                    Status = Properties.Resources.online_vg;
                }
                else if (_pingResult < 60)
                {
                    Status = Properties.Resources.online_good;
                }
                else
                {
                    Status = Properties.Resources.online_bad;
                }

                // Raise event
                OnCompleted(args);

                // Reset results
                totalTimeout = 0;
                pingsSent = 0;
            }
        }

        protected virtual void OnCompleted(CompletedEventArgs e)
        {
            EventHandler<CompletedEventArgs> handler = Completed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here
                resetEvent.Dispose();
                pingSender.Dispose();
                autoEvent.Dispose();
                tcb = null;
                timerPing.Dispose();
            }

            // Free any unmanaged objects here.

            disposed = true;
        }
    }

    public class CompletedEventArgs : EventArgs
    {
        public long TotalTimeout { get; set; }
        public int AvgTimeout { get; set; }
        public DateTime LastPing { get; set; }
    }
}
