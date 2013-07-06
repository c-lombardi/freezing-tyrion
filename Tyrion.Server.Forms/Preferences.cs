using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Tyrion.Server.Forms
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            PortNumTxt.Enabled = false;
        }
        private void PortNumTxt_Digits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                PortNumTxt.Enabled = false;
            }
        }
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Preferences.ActiveForm.Visible = false;
            main.ShowDialog();
        }

        private void FolderBtn_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fldrbrwsr = new FolderBrowserDialog();
            fldrbrwsr.ShowDialog();
            MusicPathTxt.Text = fldrbrwsr.SelectedPath;
        }

        private void ChangePortBtn_Click_1(object sender, EventArgs e)
        {
            PortNumTxt.Enabled = true;
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            PortNumTxt.Enabled = false;
        }

        private void PortNumTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
