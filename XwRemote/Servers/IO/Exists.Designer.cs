namespace XwRemote.Servers
{
    partial class Exists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exists));
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.overwriteFile = new System.Windows.Forms.Button();
            this.resumeFile = new System.Windows.Forms.Button();
            this.skipFile = new System.Windows.Forms.Button();
            this.overwriteAll = new System.Windows.Forms.Button();
            this.resumeAll = new System.Windows.Forms.Button();
            this.skipAll = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceIcon = new System.Windows.Forms.PictureBox();
            this.DestinationIcon = new System.Windows.Forms.PictureBox();
            this.SourceFileName = new System.Windows.Forms.Label();
            this.DestinationFileName = new System.Windows.Forms.Label();
            this.SourceFileDate = new System.Windows.Forms.Label();
            this.SourceFileSize = new System.Windows.Forms.Label();
            this.DestinationFileDate = new System.Windows.Forms.Label();
            this.DestinationFileSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SourceIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.HeaderDescription = "Please choose the desired action";
            this.dialogHeader1.HeaderTitle = "File already exists";
            resources.ApplyResources(this.dialogHeader1, "dialogHeader1");
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.redhealp;
            this.dialogHeader1.Name = "dialogHeader1";
            // 
            // overwriteFile
            // 
            resources.ApplyResources(this.overwriteFile, "overwriteFile");
            this.overwriteFile.ForeColor = System.Drawing.Color.Green;
            this.overwriteFile.Name = "overwriteFile";
            this.overwriteFile.UseVisualStyleBackColor = true;
            this.overwriteFile.Click += new System.EventHandler(this.overwriteFile_Click);
            // 
            // resumeFile
            // 
            resources.ApplyResources(this.resumeFile, "resumeFile");
            this.resumeFile.ForeColor = System.Drawing.Color.Green;
            this.resumeFile.Name = "resumeFile";
            this.resumeFile.UseVisualStyleBackColor = true;
            this.resumeFile.Click += new System.EventHandler(this.resumeFile_Click);
            // 
            // skipFile
            // 
            resources.ApplyResources(this.skipFile, "skipFile");
            this.skipFile.ForeColor = System.Drawing.Color.Green;
            this.skipFile.Name = "skipFile";
            this.skipFile.UseVisualStyleBackColor = true;
            this.skipFile.Click += new System.EventHandler(this.skipFile_Click);
            // 
            // overwriteAll
            // 
            resources.ApplyResources(this.overwriteAll, "overwriteAll");
            this.overwriteAll.ForeColor = System.Drawing.Color.Maroon;
            this.overwriteAll.Name = "overwriteAll";
            this.overwriteAll.UseVisualStyleBackColor = true;
            this.overwriteAll.Click += new System.EventHandler(this.overwriteAll_Click);
            // 
            // resumeAll
            // 
            resources.ApplyResources(this.resumeAll, "resumeAll");
            this.resumeAll.ForeColor = System.Drawing.Color.Maroon;
            this.resumeAll.Name = "resumeAll";
            this.resumeAll.UseVisualStyleBackColor = true;
            this.resumeAll.Click += new System.EventHandler(this.resumeAll_Click);
            // 
            // skipAll
            // 
            resources.ApplyResources(this.skipAll, "skipAll");
            this.skipAll.ForeColor = System.Drawing.Color.Maroon;
            this.skipAll.Name = "skipAll";
            this.skipAll.UseVisualStyleBackColor = true;
            this.skipAll.Click += new System.EventHandler(this.skipAll_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
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
            // SourceIcon
            // 
            resources.ApplyResources(this.SourceIcon, "SourceIcon");
            this.SourceIcon.Name = "SourceIcon";
            this.SourceIcon.TabStop = false;
            // 
            // DestinationIcon
            // 
            resources.ApplyResources(this.DestinationIcon, "DestinationIcon");
            this.DestinationIcon.Name = "DestinationIcon";
            this.DestinationIcon.TabStop = false;
            // 
            // SourceFileName
            // 
            resources.ApplyResources(this.SourceFileName, "SourceFileName");
            this.SourceFileName.Name = "SourceFileName";
            // 
            // DestinationFileName
            // 
            resources.ApplyResources(this.DestinationFileName, "DestinationFileName");
            this.DestinationFileName.Name = "DestinationFileName";
            // 
            // SourceFileDate
            // 
            resources.ApplyResources(this.SourceFileDate, "SourceFileDate");
            this.SourceFileDate.Name = "SourceFileDate";
            // 
            // SourceFileSize
            // 
            resources.ApplyResources(this.SourceFileSize, "SourceFileSize");
            this.SourceFileSize.Name = "SourceFileSize";
            // 
            // DestinationFileDate
            // 
            resources.ApplyResources(this.DestinationFileDate, "DestinationFileDate");
            this.DestinationFileDate.Name = "DestinationFileDate";
            // 
            // DestinationFileSize
            // 
            resources.ApplyResources(this.DestinationFileSize, "DestinationFileSize");
            this.DestinationFileSize.Name = "DestinationFileSize";
            // 
            // Exists
            // 
            this.AcceptButton = this.overwriteFile;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.Controls.Add(this.DestinationFileSize);
            this.Controls.Add(this.SourceFileSize);
            this.Controls.Add(this.DestinationFileDate);
            this.Controls.Add(this.SourceFileDate);
            this.Controls.Add(this.DestinationFileName);
            this.Controls.Add(this.SourceFileName);
            this.Controls.Add(this.DestinationIcon);
            this.Controls.Add(this.SourceIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.skipAll);
            this.Controls.Add(this.resumeAll);
            this.Controls.Add(this.overwriteAll);
            this.Controls.Add(this.skipFile);
            this.Controls.Add(this.resumeFile);
            this.Controls.Add(this.overwriteFile);
            this.Controls.Add(this.dialogHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exists";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.SourceIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private System.Windows.Forms.Button overwriteFile;
        private System.Windows.Forms.Button resumeFile;
        private System.Windows.Forms.Button skipFile;
        private System.Windows.Forms.Button overwriteAll;
        private System.Windows.Forms.Button resumeAll;
        private System.Windows.Forms.Button skipAll;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox SourceIcon;
        public System.Windows.Forms.PictureBox DestinationIcon;
        public System.Windows.Forms.Label SourceFileName;
        public System.Windows.Forms.Label SourceFileDate;
        public System.Windows.Forms.Label SourceFileSize;
        public System.Windows.Forms.Label DestinationFileName;
        public System.Windows.Forms.Label DestinationFileDate;
        public System.Windows.Forms.Label DestinationFileSize;

    }
}