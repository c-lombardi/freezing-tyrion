using NAudio.Wave;
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
using Tyrion.Models;

namespace freezing_tyrion
{
    public partial class Main : Form
    {
        private Tune song;
        public Main()
        {
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
            song = new Tune() { path = mp3 };
            song.Play();
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            song.Stop();
        }
    }
}
