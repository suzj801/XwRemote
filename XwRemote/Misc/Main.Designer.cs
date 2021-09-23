namespace XwRemote
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ServerTabs = new KRBTabControlNS.CustomTab.KRBTabControl();
            this.Toolbar_ServerManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Toolbar_Updates = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MainToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Toolbar_Favorites = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolSettings = new System.Windows.Forms.ToolStripButton();
            this.Toolbar_CanYouHelp = new System.Windows.Forms.ToolStripButton();
            this.Toolbar_Stuff = new System.Windows.Forms.ToolStripButton();
            this.appTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMainApplicationWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.MainToolbar.SuspendLayout();
            this.appTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ServerTabs);
            this.toolStripContainer1.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // ServerTabs
            // 
            resources.ApplyResources(this.ServerTabs, "ServerTabs");
            this.ServerTabs.AllowDrop = true;
            this.ServerTabs.BackgroundHatcher.BackColor = System.Drawing.Color.Gray;
            this.ServerTabs.BackgroundHatcher.HatchType = System.Drawing.Drawing2D.HatchStyle.DashedVertical;
            this.ServerTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ServerTabs.Name = "ServerTabs";
            this.ServerTabs.TabGradient.ColorEnd = System.Drawing.Color.LightSteelBlue;
            this.ServerTabs.TabGradient.GradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ServerTabs.TabStyles = KRBTabControlNS.CustomTab.KRBTabControl.TabStyle.Sequence;
            this.ServerTabs.UpDownStyle = KRBTabControlNS.CustomTab.KRBTabControl.UpDown32Style.OfficeBlue;
            this.ServerTabs.TabClosing += new System.ComponentModel.CancelEventHandler(this.ServerTabs_TabClosing);
            this.ServerTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.ServerTabs_Selected);
            this.ServerTabs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ServerTabs_MouseMove);
            // 
            // Toolbar_ServerManager
            // 
            resources.ApplyResources(this.Toolbar_ServerManager, "Toolbar_ServerManager");
            this.Toolbar_ServerManager.Image = global::XwRemote.Properties.Resources.server_connect;
            this.Toolbar_ServerManager.Name = "Toolbar_ServerManager";
            this.Toolbar_ServerManager.Click += new System.EventHandler(this.Toolbar_ServerManager_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // Toolbar_Updates
            // 
            resources.ApplyResources(this.Toolbar_Updates, "Toolbar_Updates");
            this.Toolbar_Updates.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Toolbar_Updates.Name = "Toolbar_Updates";
            this.Toolbar_Updates.Click += new System.EventHandler(this.toolStripUpdates_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // MainToolbar
            // 
            resources.ApplyResources(this.MainToolbar, "MainToolbar");
            this.MainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toolbar_ServerManager,
            this.toolStripSeparator4,
            this.Toolbar_Favorites,
            this.toolStripSeparator5,
            this.toolStripButton1,
            this.toolSettings,
            this.Toolbar_CanYouHelp,
            this.toolStripSeparator3,
            this.Toolbar_Stuff,
            this.toolStripSeparator2,
            this.Toolbar_Updates});
            this.MainToolbar.Name = "MainToolbar";
            this.MainToolbar.MouseEnter += new System.EventHandler(this.MainToolbar_MouseEnter);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // Toolbar_Favorites
            // 
            resources.ApplyResources(this.Toolbar_Favorites, "Toolbar_Favorites");
            this.Toolbar_Favorites.Image = global::XwRemote.Properties.Resources.favs;
            this.Toolbar_Favorites.Name = "Toolbar_Favorites";
            this.Toolbar_Favorites.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Toolbar_Favorites_DropDownItemClicked);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Image = global::XwRemote.Properties.Resources.settings;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolSettings_Click);
            // 
            // toolSettings
            // 
            resources.ApplyResources(this.toolSettings, "toolSettings");
            this.toolSettings.Image = global::XwRemote.Properties.Resources.magnifier;
            this.toolSettings.Name = "toolSettings";
            this.toolSettings.Click += new System.EventHandler(this.toolScanner_Click);
            // 
            // Toolbar_CanYouHelp
            // 
            resources.ApplyResources(this.Toolbar_CanYouHelp, "Toolbar_CanYouHelp");
            this.Toolbar_CanYouHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Toolbar_CanYouHelp.Image = global::XwRemote.Properties.Resources.paypal;
            this.Toolbar_CanYouHelp.Name = "Toolbar_CanYouHelp";
            this.Toolbar_CanYouHelp.Click += new System.EventHandler(this.Toolbar_CanYouHelp_Click);
            // 
            // Toolbar_Stuff
            // 
            resources.ApplyResources(this.Toolbar_Stuff, "Toolbar_Stuff");
            this.Toolbar_Stuff.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Toolbar_Stuff.Image = global::XwRemote.Properties.Resources.xwremote1;
            this.Toolbar_Stuff.Name = "Toolbar_Stuff";
            this.Toolbar_Stuff.Click += new System.EventHandler(this.Toolbar_Stuff_Click);
            // 
            // appTrayMenu
            // 
            resources.ApplyResources(this.appTrayMenu, "appTrayMenu");
            this.appTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainApplicationWindowToolStripMenuItem,
            this.resetPositionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.appTrayMenu.Name = "appTrayMenu";
            // 
            // showMainApplicationWindowToolStripMenuItem
            // 
            resources.ApplyResources(this.showMainApplicationWindowToolStripMenuItem, "showMainApplicationWindowToolStripMenuItem");
            this.showMainApplicationWindowToolStripMenuItem.Name = "showMainApplicationWindowToolStripMenuItem";
            this.showMainApplicationWindowToolStripMenuItem.Click += new System.EventHandler(this.showMainApplicationWindowToolStripMenuItem_Click);
            // 
            // resetPositionToolStripMenuItem
            // 
            resources.ApplyResources(this.resetPositionToolStripMenuItem, "resetPositionToolStripMenuItem");
            this.resetPositionToolStripMenuItem.Name = "resetPositionToolStripMenuItem";
            this.resetPositionToolStripMenuItem.Click += new System.EventHandler(this.resetPositionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // appTrayIcon
            // 
            resources.ApplyResources(this.appTrayIcon, "appTrayIcon");
            this.appTrayIcon.ContextMenuStrip = this.appTrayMenu;
            this.appTrayIcon.DoubleClick += new System.EventHandler(this.appTrayIcon_DoubleClick);
            this.appTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.appTrayIcon_MouseDoubleClick);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.MainToolbar);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.MainToolbar.ResumeLayout(false);
            this.MainToolbar.PerformLayout();
            this.appTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        public KRBTabControlNS.CustomTab.KRBTabControl ServerTabs;
        private System.Windows.Forms.ToolStripButton Toolbar_ServerManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip MainToolbar;
        public System.Windows.Forms.ToolStripButton Toolbar_Updates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton Toolbar_Favorites;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolSettings;
        private System.Windows.Forms.ToolStripButton Toolbar_CanYouHelp;
        private System.Windows.Forms.ToolStripButton Toolbar_Stuff;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip appTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem showMainApplicationWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPositionToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon appTrayIcon;
    }
}

