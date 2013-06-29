namespace freezing_tyrion
{
    partial class Preferences
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
            this.MusicPath = new System.Windows.Forms.TextBox();
            this.FolderBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PortNumTxt = new System.Windows.Forms.TextBox();
            this.ChangePort = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusicPath
            // 
            this.MusicPath.Enabled = false;
            this.MusicPath.Location = new System.Drawing.Point(181, 49);
            this.MusicPath.Name = "MusicPath";
            this.MusicPath.Size = new System.Drawing.Size(269, 20);
            this.MusicPath.TabIndex = 5;
            // 
            // FolderBtn
            // 
            this.FolderBtn.Location = new System.Drawing.Point(12, 46);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(125, 23);
            this.FolderBtn.TabIndex = 4;
            this.FolderBtn.Text = "Folder";
            this.FolderBtn.UseVisualStyleBackColor = true;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // PortNumTxt
            // 
            this.PortNumTxt.Enabled = false;
            this.PortNumTxt.Location = new System.Drawing.Point(181, 105);
            this.PortNumTxt.Name = "PortNumTxt";
            this.PortNumTxt.Size = new System.Drawing.Size(269, 20);
            this.PortNumTxt.TabIndex = 8;
            this.PortNumTxt.Text = "5000";
            this.PortNumTxt.TextChanged += new System.EventHandler(this.PortNumTxt_TextChanged);
            // 
            // ChangePort
            // 
            this.ChangePort.Location = new System.Drawing.Point(13, 101);
            this.ChangePort.Name = "ChangePort";
            this.ChangePort.Size = new System.Drawing.Size(124, 23);
            this.ChangePort.TabIndex = 9;
            this.ChangePort.Text = "Change Port Number";
            this.ChangePort.UseVisualStyleBackColor = true;
            this.ChangePort.Click += new System.EventHandler(this.ChangePort_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(181, 178);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 23);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 463);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ChangePort);
            this.Controls.Add(this.PortNumTxt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MusicPath);
            this.Controls.Add(this.FolderBtn);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MusicPath;
        private System.Windows.Forms.Button FolderBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.TextBox PortNumTxt;
        private System.Windows.Forms.Button ChangePort;
        private System.Windows.Forms.Button SaveBtn;
    }
}