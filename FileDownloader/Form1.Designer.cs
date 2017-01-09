namespace FileDownloader
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileDownloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtSaveDestination = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblSaveClick = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDownloaderToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuMain.Size = new System.Drawing.Size(566, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // fileDownloaderToolStripMenuItem
            // 
            this.fileDownloaderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileDownloaderToolStripMenuItem.Name = "fileDownloaderToolStripMenuItem";
            this.fileDownloaderToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileDownloaderToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(109, 115);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(346, 20);
            this.txtURL.TabIndex = 1;
            // 
            // txtSaveDestination
            // 
            this.txtSaveDestination.Location = new System.Drawing.Point(109, 143);
            this.txtSaveDestination.Name = "txtSaveDestination";
            this.txtSaveDestination.ReadOnly = true;
            this.txtSaveDestination.Size = new System.Drawing.Size(346, 20);
            this.txtSaveDestination.TabIndex = 2;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(68, 118);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(33, 13);
            this.lblURL.TabIndex = 3;
            this.lblURL.Text = "URL: ";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(68, 146);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(33, 13);
            this.lblSave.TabIndex = 4;
            this.lblSave.Text = "Save:";
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(109, 195);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(346, 23);
            this.pbDownload.TabIndex = 5;
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(106, 221);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(349, 21);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(110)))), ((int)(((byte)(103)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(479, 127);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblSaveClick
            // 
            this.lblSaveClick.BackColor = System.Drawing.Color.Gray;
            this.lblSaveClick.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveClick.Location = new System.Drawing.Point(435, 143);
            this.lblSaveClick.Name = "lblSaveClick";
            this.lblSaveClick.Size = new System.Drawing.Size(20, 20);
            this.lblSaveClick.TabIndex = 8;
            this.lblSaveClick.Text = "...";
            this.lblSaveClick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSaveClick.Click += new System.EventHandler(this.lblSaveClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(566, 290);
            this.Controls.Add(this.lblSaveClick);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtSaveDestination);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.Text = "File Downloader";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileDownloaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtSaveDestination;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblSaveClick;
    }
}

