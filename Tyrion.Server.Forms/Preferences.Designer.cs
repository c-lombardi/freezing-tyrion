namespace Tyrion.Server.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderBtn = new System.Windows.Forms.Button();
            this.ChangePortBtn = new System.Windows.Forms.Button();
            this.MusicPathTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PortNumTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.preferencesToolStripMenuItem.Text = "Home";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // FolderBtn
            // 
            this.FolderBtn.Location = new System.Drawing.Point(35, 53);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(115, 23);
            this.FolderBtn.TabIndex = 2;
            this.FolderBtn.Text = "Folder";
            this.FolderBtn.UseVisualStyleBackColor = true;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click_1);
            // 
            // ChangePortBtn
            // 
            this.ChangePortBtn.Location = new System.Drawing.Point(35, 107);
            this.ChangePortBtn.Name = "ChangePortBtn";
            this.ChangePortBtn.Size = new System.Drawing.Size(115, 23);
            this.ChangePortBtn.TabIndex = 3;
            this.ChangePortBtn.Text = "Change Port Number";
            this.ChangePortBtn.UseVisualStyleBackColor = true;
            this.ChangePortBtn.Click += new System.EventHandler(this.ChangePortBtn_Click_1);
            // 
            // MusicPathTxt
            // 
            this.MusicPathTxt.Enabled = false;
            this.MusicPathTxt.Location = new System.Drawing.Point(191, 55);
            this.MusicPathTxt.Name = "MusicPathTxt";
            this.MusicPathTxt.Size = new System.Drawing.Size(203, 20);
            this.MusicPathTxt.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(74, 206);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(233, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // PortNumTxt
            // 
            this.PortNumTxt.Enabled = false;
            this.PortNumTxt.Location = new System.Drawing.Point(191, 109);
            this.PortNumTxt.Name = "PortNumTxt";
            this.PortNumTxt.Size = new System.Drawing.Size(203, 20);
            this.PortNumTxt.TabIndex = 7;
            this.PortNumTxt.Text = "5000";
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 430);
            this.Controls.Add(this.PortNumTxt);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.MusicPathTxt);
            this.Controls.Add(this.ChangePortBtn);
            this.Controls.Add(this.FolderBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Button FolderBtn;
        private System.Windows.Forms.Button ChangePortBtn;
        private System.Windows.Forms.TextBox MusicPathTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox PortNumTxt;
    }
}