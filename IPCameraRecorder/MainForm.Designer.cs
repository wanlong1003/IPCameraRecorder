namespace IPCameraRecorder
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("我的摄像头");
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemDeviceManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusClientInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusVideoInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMiddle = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvDevice = new System.Windows.Forms.TreeView();
            this.panelVideos = new System.Windows.Forms.Panel();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelVideos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDeviceManage,
            this.menuItemHelp});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(845, 25);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // menuItemDeviceManage
            // 
            this.menuItemDeviceManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd});
            this.menuItemDeviceManage.Name = "menuItemDeviceManage";
            this.menuItemDeviceManage.Size = new System.Drawing.Size(68, 21);
            this.menuItemDeviceManage.Text = "设备管理";
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(152, 22);
            this.menuItemAdd.Text = "添加";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 21);
            this.menuItemHelp.Text = "帮助";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(100, 22);
            this.menuItemAbout.Text = "关于";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusClientInfo,
            this.statusVideoInfo,
            this.statusMiddle,
            this.statusTime});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 488);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(845, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // statusClientInfo
            // 
            this.statusClientInfo.Name = "statusClientInfo";
            this.statusClientInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // statusVideoInfo
            // 
            this.statusVideoInfo.Name = "statusVideoInfo";
            this.statusVideoInfo.Size = new System.Drawing.Size(104, 17);
            this.statusVideoInfo.Text = "帧率:0    已收到:0";
            // 
            // statusMiddle
            // 
            this.statusMiddle.Name = "statusMiddle";
            this.statusMiddle.Size = new System.Drawing.Size(670, 17);
            this.statusMiddle.Spring = true;
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(56, 17);
            this.statusTime.Text = "当前时间";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvDevice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelVideos);
            this.splitContainer1.Panel2.Controls.Add(this.panelTools);
            this.splitContainer1.Size = new System.Drawing.Size(845, 463);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvDevice
            // 
            this.tvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDevice.Location = new System.Drawing.Point(0, 0);
            this.tvDevice.Name = "tvDevice";
            treeNode8.Name = "rootNode";
            treeNode8.Text = "我的摄像头";
            this.tvDevice.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.tvDevice.Size = new System.Drawing.Size(281, 463);
            this.tvDevice.TabIndex = 1;
            this.tvDevice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDevice_AfterSelect);
            // 
            // panelVideos
            // 
            this.panelVideos.Controls.Add(this.pbVideo);
            this.panelVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVideos.Location = new System.Drawing.Point(0, 0);
            this.panelVideos.Name = "panelVideos";
            this.panelVideos.Size = new System.Drawing.Size(560, 421);
            this.panelVideos.TabIndex = 1;
            // 
            // pbVideo
            // 
            this.pbVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbVideo.Location = new System.Drawing.Point(0, 0);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(560, 421);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVideo.TabIndex = 0;
            this.pbVideo.TabStop = false;
            // 
            // panelTools
            // 
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTools.Location = new System.Drawing.Point(0, 421);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(560, 42);
            this.panelTools.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IP摄像头客户端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelVideos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeviceManage;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusVideoInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvDevice;
        private System.Windows.Forms.Panel panelVideos;
        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel statusMiddle;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripStatusLabel statusClientInfo;
    }
}

