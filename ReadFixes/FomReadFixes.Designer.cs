namespace ReadFixes
{
    partial class FrmReadFixes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReadFixes));
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnTarget = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.radSourceFolder = new System.Windows.Forms.RadioButton();
            this.radSourceFiles = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkSamples = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.grpSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(22, 133);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(56, 13);
            this.lblTarget.TabIndex = 0;
            this.lblTarget.Text = "Target file";
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(367, 128);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(75, 23);
            this.btnTarget.TabIndex = 1;
            this.btnTarget.Text = "Browse...";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.BtnTarget_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(94, 130);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(267, 20);
            this.txtTarget.TabIndex = 2;
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.txtSource);
            this.grpSource.Controls.Add(this.btnSource);
            this.grpSource.Controls.Add(this.lblSource);
            this.grpSource.Controls.Add(this.chkSubfolders);
            this.grpSource.Controls.Add(this.radSourceFolder);
            this.grpSource.Controls.Add(this.radSourceFiles);
            this.grpSource.Location = new System.Drawing.Point(16, 13);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(436, 109);
            this.grpSource.TabIndex = 3;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source Fixes";
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(78, 74);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(267, 20);
            this.txtSource.TabIndex = 5;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(351, 72);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 4;
            this.btnSource.Text = "Browse...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.BtnSource_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(6, 77);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(67, 13);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Fixes source";
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Enabled = false;
            this.chkSubfolders.Location = new System.Drawing.Point(68, 45);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(122, 17);
            this.chkSubfolders.TabIndex = 2;
            this.chkSubfolders.Text = "Including subfolders";
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // radSourceFolder
            // 
            this.radSourceFolder.AutoSize = true;
            this.radSourceFolder.Location = new System.Drawing.Point(7, 44);
            this.radSourceFolder.Name = "radSourceFolder";
            this.radSourceFolder.Size = new System.Drawing.Size(55, 17);
            this.radSourceFolder.TabIndex = 1;
            this.radSourceFolder.Text = "Folder";
            this.radSourceFolder.UseVisualStyleBackColor = true;
            this.radSourceFolder.CheckedChanged += new System.EventHandler(this.RadSourceFolder_CheckedChanged);
            // 
            // radSourceFiles
            // 
            this.radSourceFiles.AutoSize = true;
            this.radSourceFiles.Checked = true;
            this.radSourceFiles.Location = new System.Drawing.Point(7, 20);
            this.radSourceFiles.Name = "radSourceFiles";
            this.radSourceFiles.Size = new System.Drawing.Size(46, 17);
            this.radSourceFiles.TabIndex = 0;
            this.radSourceFiles.TabStop = true;
            this.radSourceFiles.Text = "Files";
            this.radSourceFiles.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(367, 189);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // chkSamples
            // 
            this.chkSamples.AutoSize = true;
            this.chkSamples.Checked = true;
            this.chkSamples.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSamples.Location = new System.Drawing.Point(16, 193);
            this.chkSamples.Name = "chkSamples";
            this.chkSamples.Size = new System.Drawing.Size(100, 17);
            this.chkSamples.TabIndex = 6;
            this.chkSamples.Text = "Export Samples";
            this.chkSamples.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.Location = new System.Drawing.Point(419, 219);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(22, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // FrmReadFixes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.chkSamples);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grpSource);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.lblTarget);
            this.Name = "FrmReadFixes";
            this.Text = "Read Fixes";
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.RadioButton radSourceFolder;
        private System.Windows.Forms.RadioButton radSourceFiles;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkSamples;
        private System.Windows.Forms.Button btnHelp;
    }
}

