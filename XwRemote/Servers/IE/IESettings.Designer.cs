using System.Windows.Forms;

namespace XwRemote.Servers
{
    partial class IESettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IESettings));
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dividerPanel1 = new DividerPanel.DividerPanel();
            this.IsFavorite = new System.Windows.Forms.CheckBox();
            this.checkUseHtml = new System.Windows.Forms.CheckBox();
            this.userIDbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passIDbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loginIDbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabColorBox = new ColorComboTestApp.ColorComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.dividerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.HeaderDescription = "Connection settings for Web Console Devices";
            this.dialogHeader1.HeaderTitle = "Internet Explorer";
            resources.ApplyResources(this.dialogHeader1, "dialogHeader1");
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.IE;
            this.dialogHeader1.Name = "dialogHeader1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // PassBox
            // 
            resources.ApplyResources(this.PassBox, "PassBox");
            this.PassBox.Name = "PassBox";
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassBox_KeyDown);
            // 
            // UserBox
            // 
            resources.ApplyResources(this.UserBox, "UserBox");
            this.UserBox.Name = "UserBox";
            // 
            // HostBox
            // 
            resources.ApplyResources(this.HostBox, "HostBox");
            this.HostBox.Name = "HostBox";
            // 
            // NameBox
            // 
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dividerPanel1
            // 
            this.dividerPanel1.AllowDrop = true;
            this.dividerPanel1.BorderSide = System.Windows.Forms.Border3DSide.Top;
            this.dividerPanel1.Controls.Add(this.btnCancel);
            this.dividerPanel1.Controls.Add(this.btnOK);
            this.dividerPanel1.Controls.Add(this.IsFavorite);
            resources.ApplyResources(this.dividerPanel1, "dividerPanel1");
            this.dividerPanel1.Name = "dividerPanel1";
            // 
            // IsFavorite
            // 
            resources.ApplyResources(this.IsFavorite, "IsFavorite");
            this.IsFavorite.Name = "IsFavorite";
            this.IsFavorite.UseVisualStyleBackColor = true;
            // 
            // checkUseHtml
            // 
            resources.ApplyResources(this.checkUseHtml, "checkUseHtml");
            this.checkUseHtml.Name = "checkUseHtml";
            this.checkUseHtml.UseVisualStyleBackColor = true;
            this.checkUseHtml.CheckedChanged += new System.EventHandler(this.checkUseHtml_CheckedChanged);
            // 
            // userIDbox
            // 
            resources.ApplyResources(this.userIDbox, "userIDbox");
            this.userIDbox.Name = "userIDbox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // passIDbox
            // 
            resources.ApplyResources(this.passIDbox, "passIDbox");
            this.passIDbox.Name = "passIDbox";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // loginIDbox
            // 
            resources.ApplyResources(this.loginIDbox, "loginIDbox");
            this.loginIDbox.Name = "loginIDbox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tabColorBox
            // 
            this.tabColorBox.Extended = true;
            this.tabColorBox.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.tabColorBox, "tabColorBox");
            this.tabColorBox.Name = "tabColorBox";
            this.tabColorBox.SelectedColor = System.Drawing.Color.LightSkyBlue;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // NotesBox
            // 
            this.NotesBox.AcceptsReturn = true;
            resources.ApplyResources(this.NotesBox, "NotesBox");
            this.NotesBox.Name = "NotesBox";
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Image = global::XwRemote.Properties.Resources.eye;
            resources.ApplyResources(this.buttonShowPassword, "buttonShowPassword");
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // IESettings
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.tabColorBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginIDbox);
            this.Controls.Add(this.passIDbox);
            this.Controls.Add(this.userIDbox);
            this.Controls.Add(this.checkUseHtml);
            this.Controls.Add(this.dialogHeader1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.HostBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dividerPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IESettings";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.OnLoad);
            this.dividerPanel1.ResumeLayout(false);
            this.dividerPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private DividerPanel.DividerPanel dividerPanel1;
        private System.Windows.Forms.CheckBox IsFavorite;
        private System.Windows.Forms.CheckBox checkUseHtml;
        private System.Windows.Forms.TextBox userIDbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passIDbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loginIDbox;
        private System.Windows.Forms.Label label7;
        private ColorComboTestApp.ColorComboBox tabColorBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NotesBox;
        private Button buttonShowPassword;
    }
}