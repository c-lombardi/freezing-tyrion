using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freezing_tyrion
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldrbrwsr = new FolderBrowserDialog();
            fldrbrwsr.ShowDialog();
            MusicPath.Text = fldrbrwsr.SelectedPath;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Preferences.ActiveForm.Visible = false;
            main.ShowDialog();
        }

        private void ChangePort_Click(object sender, EventArgs e)
        {
            PortNumTxt.Enabled = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            PortNumTxt.Enabled = false;
        }

        private void PortNumTxt_TextChanged(object sender, EventArgs e)
        {
            this.PortNumTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(DisableTxt);
        }
        private void DisableTxt(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                PortNumTxt.Enabled = false;
            } 
        }
    }
}
