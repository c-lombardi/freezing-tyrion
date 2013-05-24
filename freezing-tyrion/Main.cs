using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace freezing_tyrion
{
    public partial class Main : Form
    {
        WMPLib.WindowsMediaPlayer wplayer;
        public Main()
        {
            wplayer = new WMPLib.WindowsMediaPlayer();
            InitializeComponent();
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            string path = @"G:\Music\Daft Punk\Random Access Memories\";
            string mp3 = "";
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var file in dir.GetFiles())
            {
                if (file.Name.Contains("Lucky"))
                {
                    mp3 = file.Directory.ToString() + "\\" + file.ToString();
                }
            }
            
            wplayer.URL = mp3;
            wplayer.controls.play();
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }
    }
}
