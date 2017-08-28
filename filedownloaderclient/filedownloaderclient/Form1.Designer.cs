namespace filedownloaderclient
{
    partial class Form1
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.txtSvrPath = new System.Windows.Forms.TextBox();
            this.btnAutoCopy = new System.Windows.Forms.Button();
            this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAutoSave = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSavingFolder = new System.Windows.Forms.Button();
            this.lblSavingPath = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(324, 143);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtSvrPath
            // 
            this.txtSvrPath.Location = new System.Drawing.Point(37, 62);
            this.txtSvrPath.Name = "txtSvrPath";
            this.txtSvrPath.Size = new System.Drawing.Size(362, 20);
            this.txtSvrPath.TabIndex = 1;
            // 
            // btnAutoCopy
            // 
            this.btnAutoCopy.Location = new System.Drawing.Point(37, 143);
            this.btnAutoCopy.Name = "btnAutoCopy";
            this.btnAutoCopy.Size = new System.Drawing.Size(75, 23);
            this.btnAutoCopy.TabIndex = 3;
            this.btnAutoCopy.Text = "Autocopy";
            this.btnAutoCopy.UseVisualStyleBackColor = true;
            this.btnAutoCopy.Click += new System.EventHandler(this.btnAutoCopy_Click);
            // 
            // btnAutoSave
            // 
            this.btnAutoSave.Location = new System.Drawing.Point(324, 235);
            this.btnAutoSave.Name = "btnAutoSave";
            this.btnAutoSave.Size = new System.Drawing.Size(75, 23);
            this.btnAutoSave.TabIndex = 4;
            this.btnAutoSave.Text = "Autosave";
            this.btnAutoSave.UseVisualStyleBackColor = true;
            this.btnAutoSave.Click += new System.EventHandler(this.btnAutoSave_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(37, 186);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(362, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // btnSavingFolder
            // 
            this.btnSavingFolder.Location = new System.Drawing.Point(37, 235);
            this.btnSavingFolder.Name = "btnSavingFolder";
            this.btnSavingFolder.Size = new System.Drawing.Size(147, 23);
            this.btnSavingFolder.TabIndex = 6;
            this.btnSavingFolder.Text = "Set Auto Saving Folder";
            this.btnSavingFolder.UseVisualStyleBackColor = true;
            this.btnSavingFolder.Click += new System.EventHandler(this.btnSavingFolder_Click);
            // 
            // lblSavingPath
            // 
            this.lblSavingPath.AutoSize = true;
            this.lblSavingPath.Location = new System.Drawing.Point(37, 213);
            this.lblSavingPath.Name = "lblSavingPath";
            this.lblSavingPath.Size = new System.Drawing.Size(0, 13);
            this.lblSavingPath.TabIndex = 7;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Location = new System.Drawing.Point(40, 89);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(359, 38);
            this.txtStatus.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAutoSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 261);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblSavingPath);
            this.Controls.Add(this.btnSavingFolder);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnAutoSave);
            this.Controls.Add(this.btnAutoCopy);
            this.Controls.Add(this.txtSvrPath);
            this.Controls.Add(this.btnDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.SaveFileDialog sfdMain;
        private System.Windows.Forms.TextBox txtSvrPath;
        private System.Windows.Forms.Button btnAutoCopy;
        private System.Windows.Forms.FolderBrowserDialog fbdMain;
        private System.Windows.Forms.Button btnAutoSave;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSavingFolder;
        private System.Windows.Forms.Label lblSavingPath;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

