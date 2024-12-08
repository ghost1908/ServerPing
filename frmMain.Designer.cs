namespace ServerPing
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvServers = new System.Windows.Forms.DataGridView();
            this.colStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.colServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPingResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPingEnable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsPingObjectContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsPOCStart = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPOCStop = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPOC_Properties = new System.Windows.Forms.ToolStripMenuItem();
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.tlslblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.tlsbtnLoadData = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnStartAll = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnStopAll = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServers)).BeginInit();
            this.cmsPingObjectContext.SuspendLayout();
            this.stsInfo.SuspendLayout();
            this.tlsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServers
            // 
            this.dgvServers.AllowUserToAddRows = false;
            this.dgvServers.AllowUserToDeleteRows = false;
            this.dgvServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStatus,
            this.colServer,
            this.colPingResult,
            this.colLastPing,
            this.colPingEnable});
            this.dgvServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvServers.Location = new System.Drawing.Point(0, 25);
            this.dgvServers.Name = "dgvServers";
            this.dgvServers.RowHeadersVisible = false;
            this.dgvServers.RowTemplate.ContextMenuStrip = this.cmsPingObjectContext;
            this.dgvServers.Size = new System.Drawing.Size(526, 341);
            this.dgvServers.TabIndex = 4;
            this.dgvServers.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServers_CellMouseEnter);
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 16;
            // 
            // colServer
            // 
            this.colServer.DataPropertyName = "Name";
            this.colServer.HeaderText = "Server";
            this.colServer.Name = "colServer";
            // 
            // colPingResult
            // 
            this.colPingResult.DataPropertyName = "PingResult";
            this.colPingResult.HeaderText = "Result";
            this.colPingResult.Name = "colPingResult";
            // 
            // colLastPing
            // 
            this.colLastPing.DataPropertyName = "LastPing";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.colLastPing.DefaultCellStyle = dataGridViewCellStyle3;
            this.colLastPing.HeaderText = "Last ping";
            this.colLastPing.Name = "colLastPing";
            // 
            // colPingEnable
            // 
            this.colPingEnable.DataPropertyName = "Enable";
            this.colPingEnable.HeaderText = "Enable";
            this.colPingEnable.Name = "colPingEnable";
            // 
            // cmsPingObjectContext
            // 
            this.cmsPingObjectContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsPOCStart,
            this.cmsPOCStop,
            this.cmsPOC_Properties});
            this.cmsPingObjectContext.Name = "cmsPingObjectContext";
            this.cmsPingObjectContext.Size = new System.Drawing.Size(128, 70);
            // 
            // cmsPOCStart
            // 
            this.cmsPOCStart.Name = "cmsPOCStart";
            this.cmsPOCStart.Size = new System.Drawing.Size(127, 22);
            this.cmsPOCStart.Text = "Start";
            this.cmsPOCStart.Click += new System.EventHandler(this.cmsPOCStart_Click);
            // 
            // cmsPOCStop
            // 
            this.cmsPOCStop.Name = "cmsPOCStop";
            this.cmsPOCStop.Size = new System.Drawing.Size(127, 22);
            this.cmsPOCStop.Text = "Stop";
            this.cmsPOCStop.Click += new System.EventHandler(this.cmsPOCStop_Click);
            // 
            // cmsPOC_Properties
            // 
            this.cmsPOC_Properties.Name = "cmsPOC_Properties";
            this.cmsPOC_Properties.Size = new System.Drawing.Size(127, 22);
            this.cmsPOC_Properties.Text = "Properties";
            // 
            // stsInfo
            // 
            this.stsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlslblInfo});
            this.stsInfo.Location = new System.Drawing.Point(0, 366);
            this.stsInfo.Name = "stsInfo";
            this.stsInfo.Size = new System.Drawing.Size(526, 22);
            this.stsInfo.TabIndex = 7;
            this.stsInfo.Text = "statusStrip1";
            // 
            // tlslblInfo
            // 
            this.tlslblInfo.Name = "tlslblInfo";
            this.tlslblInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // tlsMain
            // 
            this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnLoadData,
            this.tlsbtnStartAll,
            this.tlsbtnStopAll});
            this.tlsMain.Location = new System.Drawing.Point(0, 0);
            this.tlsMain.Name = "tlsMain";
            this.tlsMain.Size = new System.Drawing.Size(526, 25);
            this.tlsMain.TabIndex = 8;
            this.tlsMain.Text = "toolStrip1";
            // 
            // tlsbtnLoadData
            // 
            this.tlsbtnLoadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnLoadData.Image = global::ServerPing.Properties.Resources.DataGrid_674;
            this.tlsbtnLoadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnLoadData.Name = "tlsbtnLoadData";
            this.tlsbtnLoadData.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnLoadData.Text = "Load data";
            this.tlsbtnLoadData.Click += new System.EventHandler(this.tlsbtnLoadData_Click);
            // 
            // tlsbtnStartAll
            // 
            this.tlsbtnStartAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnStartAll.Enabled = false;
            this.tlsbtnStartAll.Image = global::ServerPing.Properties.Resources.startwithoutdebugging_6556;
            this.tlsbtnStartAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnStartAll.Name = "tlsbtnStartAll";
            this.tlsbtnStartAll.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnStartAll.Text = "Start All";
            this.tlsbtnStartAll.Click += new System.EventHandler(this.tlsbtnStartAll_Click);
            // 
            // tlsbtnStopAll
            // 
            this.tlsbtnStopAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnStopAll.Enabled = false;
            this.tlsbtnStopAll.Image = global::ServerPing.Properties.Resources.Larger_225;
            this.tlsbtnStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnStopAll.Name = "tlsbtnStopAll";
            this.tlsbtnStopAll.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnStopAll.Text = "Stop All";
            this.tlsbtnStopAll.Click += new System.EventHandler(this.tlsbtnStopAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 388);
            this.Controls.Add(this.dgvServers);
            this.Controls.Add(this.tlsMain);
            this.Controls.Add(this.stsInfo);
            this.Name = "frmMain";
            this.Text = "Ping servers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServers)).EndInit();
            this.cmsPingObjectContext.ResumeLayout(false);
            this.stsInfo.ResumeLayout(false);
            this.stsInfo.PerformLayout();
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServers;
        private System.Windows.Forms.StatusStrip stsInfo;
        private System.Windows.Forms.ToolStripStatusLabel tlslblInfo;
        private System.Windows.Forms.DataGridViewImageColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPingResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPingEnable;
        private System.Windows.Forms.ContextMenuStrip cmsPingObjectContext;
        private System.Windows.Forms.ToolStripMenuItem cmsPOCStart;
        private System.Windows.Forms.ToolStripMenuItem cmsPOCStop;
        private System.Windows.Forms.ToolStripMenuItem cmsPOC_Properties;
        private System.Windows.Forms.ToolStrip tlsMain;
        private System.Windows.Forms.ToolStripButton tlsbtnLoadData;
        private System.Windows.Forms.ToolStripButton tlsbtnStartAll;
        private System.Windows.Forms.ToolStripButton tlsbtnStopAll;
    }
}

