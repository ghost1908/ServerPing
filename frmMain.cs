using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;

namespace ServerPing
{
    public partial class frmMain : Form
    {
        private IList<PingObject> pObjects;
        private PingObject currentObject;
        private DataGridViewCellEventArgs mouseLocation;

        public frmMain()
        {
            InitializeComponent();
        }

        private void PingCompleted(object sender, CompletedEventArgs e)
        {
            dgvServers.Invoke(new Action(() => dgvServers.Refresh()));
            dgvServers.Invoke(new Action(() => dgvServers.AutoResizeColumns()));
        }

        private void cmsPOCStart_Click(object sender, EventArgs e)
        {
            currentObject = (PingObject)dgvServers.Rows[mouseLocation.RowIndex].DataBoundItem;
            currentObject.Start();
            dgvServers.Refresh();
        }

        private void cmsPOCStop_Click(object sender, EventArgs e)
        {
            currentObject = (PingObject)dgvServers.Rows[mouseLocation.RowIndex].DataBoundItem;
            currentObject.Stop();
            dgvServers.Refresh();
        }

        private void dgvServers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

        private void tlsbtnLoadData_Click(object sender, EventArgs e)
        {
            LoadSettings();

            dgvServers.AutoGenerateColumns = false;
            dgvServers.DataSource = pObjects;
            dgvServers.AutoResizeColumns();

            tlsbtnLoadData.Enabled = false;
            tlsbtnStartAll.Enabled = true;
        }

        private void LoadSettings()
        {
            pObjects = new List<PingObject>();

            XDocument xDoc = XDocument.Load("Settings.xml");
            IEnumerable<XElement> srvs =
                from el in xDoc.Root.Element("Servers").Elements("Server")
                select el;
            
            foreach (XElement srv in srvs)
            {
                PingObject pObject = new PingObject(srv.Attribute("Name").Value, srv.Attribute("IPAddress").Value, int.Parse(srv.Attribute("PingCount").Value));
                pObject.Completed += PingCompleted;
                pObjects.Add(pObject);
            }
        }

        private void tlsbtnStartAll_Click(object sender, EventArgs e)
        {
            foreach (PingObject po in pObjects)
                po.Start();
            dgvServers.Refresh();
            tlsbtnStartAll.Enabled = false;
            tlsbtnStopAll.Enabled = true;
        }

        private void tlsbtnStopAll_Click(object sender, EventArgs e)
        {
            foreach (PingObject po in pObjects)
                po.Stop();
            dgvServers.Refresh();
            tlsbtnStartAll.Enabled = true;
            tlsbtnStopAll.Enabled = false;
        }
    }
}
