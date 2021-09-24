namespace XwRemote.Misc
{
    partial class Scanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner));
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.ipAddressControlFrom = new IPAddressControlLib.IPAddressControl();
            this.ipAddressControlTo = new IPAddressControlLib.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStartNoARP = new System.Windows.Forms.Button();
            this.listViewHosts = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textTcpPorts = new System.Windows.Forms.TextBox();
            this.checkTcpPorts = new System.Windows.Forms.CheckBox();
            this.Pump = new System.Windows.Forms.Timer(this.components);
            this.checkBoxHideDead = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericTestTimeout = new System.Windows.Forms.NumericUpDown();
            this.numericMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkDNS = new System.Windows.Forms.CheckBox();
            this.checkNetBios = new System.Windows.Forms.CheckBox();
            this.buttonStartARP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericTestTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogHeader1
            //
            this.dialogHeader1.HeaderDescription = "Try and find hosts on the network that have open ports so that you can connect to" +
    " them";
            this.dialogHeader1.HeaderTitle = "Network scan";
            resources.ApplyResources(this.dialogHeader1, "dialogHeader1");
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.magnifier;
            this.dialogHeader1.Name = "dialogHeader1";
            // 
            // ipAddressControlFrom
            // 
            resources.ApplyResources(this.ipAddressControlFrom, "ipAddressControlFrom");
            this.ipAddressControlFrom.AllowInternalTab = false;
            this.ipAddressControlFrom.AutoHeight = true;
            this.ipAddressControlFrom.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControlFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControlFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControlFrom.Name = "ipAddressControlFrom";
            this.ipAddressControlFrom.ReadOnly = false;
            this.ipAddressControlFrom.TextChanged += new System.EventHandler(this.ipAddressControlFrom_TextChanged);
            // 
            // ipAddressControlTo
            // 
            resources.ApplyResources(this.ipAddressControlTo, "ipAddressControlTo");
            this.ipAddressControlTo.AllowInternalTab = false;
            this.ipAddressControlTo.AutoHeight = true;
            this.ipAddressControlTo.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControlTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControlTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControlTo.Name = "ipAddressControlTo";
            this.ipAddressControlTo.ReadOnly = false;
            this.ipAddressControlTo.TextChanged += new System.EventHandler(this.ipAddressControlTo_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // buttonStartNoARP
            // 
            resources.ApplyResources(this.buttonStartNoARP, "buttonStartNoARP");
            this.buttonStartNoARP.Name = "buttonStartNoARP";
            this.buttonStartNoARP.UseVisualStyleBackColor = true;
            this.buttonStartNoARP.Click += new System.EventHandler(this.buttonStart_NoARP_Click);
            // 
            // listViewHosts
            // 
            resources.ApplyResources(this.listViewHosts, "listViewHosts");
            this.listViewHosts.HideSelection = false;
            this.listViewHosts.Name = "listViewHosts";
            this.listViewHosts.UseCompatibleStateImageBehavior = false;
            this.listViewHosts.View = System.Windows.Forms.View.Details;
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // textTcpPorts
            // 
            resources.ApplyResources(this.textTcpPorts, "textTcpPorts");
            this.textTcpPorts.Name = "textTcpPorts";
            // 
            // checkTcpPorts
            // 
            resources.ApplyResources(this.checkTcpPorts, "checkTcpPorts");
            this.checkTcpPorts.Name = "checkTcpPorts";
            this.checkTcpPorts.UseVisualStyleBackColor = true;
            this.checkTcpPorts.CheckedChanged += new System.EventHandler(this.checkTcpPorts_CheckedChanged);
            // 
            // Pump
            // 
            this.Pump.Tick += new System.EventHandler(this.Pump_Tick);
            // 
            // checkBoxHideDead
            // 
            resources.ApplyResources(this.checkBoxHideDead, "checkBoxHideDead");
            this.checkBoxHideDead.Checked = true;
            this.checkBoxHideDead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHideDead.Name = "checkBoxHideDead";
            this.checkBoxHideDead.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numericTestTimeout
            // 
            resources.ApplyResources(this.numericTestTimeout, "numericTestTimeout");
            this.numericTestTimeout.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericTestTimeout.Name = "numericTestTimeout";
            this.numericTestTimeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericMaxThreads
            // 
            resources.ApplyResources(this.numericMaxThreads, "numericMaxThreads");
            this.numericMaxThreads.Name = "numericMaxThreads";
            this.numericMaxThreads.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // checkDNS
            // 
            resources.ApplyResources(this.checkDNS, "checkDNS");
            this.checkDNS.Checked = true;
            this.checkDNS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDNS.Name = "checkDNS";
            this.checkDNS.UseVisualStyleBackColor = true;
            // 
            // checkNetBios
            // 
            resources.ApplyResources(this.checkNetBios, "checkNetBios");
            this.checkNetBios.Checked = true;
            this.checkNetBios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNetBios.Name = "checkNetBios";
            this.checkNetBios.UseVisualStyleBackColor = true;
            // 
            // buttonStartARP
            // 
            resources.ApplyResources(this.buttonStartARP, "buttonStartARP");
            this.buttonStartARP.Name = "buttonStartARP";
            this.buttonStartARP.UseVisualStyleBackColor = true;
            this.buttonStartARP.Click += new System.EventHandler(this.buttonStart_ARP_Click);
            // 
            // Scanner
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStartARP);
            this.Controls.Add(this.checkNetBios);
            this.Controls.Add(this.checkDNS);
            this.Controls.Add(this.numericMaxThreads);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericTestTimeout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxHideDead);
            this.Controls.Add(this.textTcpPorts);
            this.Controls.Add(this.checkTcpPorts);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listViewHosts);
            this.Controls.Add(this.buttonStartNoARP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAddressControlTo);
            this.Controls.Add(this.ipAddressControlFrom);
            this.Controls.Add(this.dialogHeader1);
            this.Name = "Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scanner_FormClosing);
            this.Load += new System.EventHandler(this.Scanner_Load);
            this.Resize += new System.EventHandler(this.Scanner_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericTestTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private IPAddressControlLib.IPAddressControl ipAddressControlFrom;
        private IPAddressControlLib.IPAddressControl ipAddressControlTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStartNoARP;
        private System.Windows.Forms.ListView listViewHosts;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textTcpPorts;
        private System.Windows.Forms.CheckBox checkTcpPorts;
        private System.Windows.Forms.Timer Pump;
        private System.Windows.Forms.CheckBox checkBoxHideDead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericTestTimeout;
        private System.Windows.Forms.NumericUpDown numericMaxThreads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkDNS;
        private System.Windows.Forms.CheckBox checkNetBios;
        private System.Windows.Forms.Button buttonStartARP;
    }
}