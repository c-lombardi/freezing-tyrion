using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(IPAddress.Parse("127.0.0.1"),5000);
            NetworkStream mp3Stream = new NetworkStream(s);
            MemoryStream memStream = new MemoryStream();
            byte[] buf = new byte[8192];
            int numRead = 0;
            while ((numRead = mp3Stream.Read(buf, 0, buf.Length)) > 0)
            {
                memStream.Write(buf, 0, numRead);
            }
            memStream.Position = 0;
            song = new Tune() { stream = memStream };
            song.PlayStream();
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            if(song != null)
                song.Stop();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences pref = new Preferences();
            Main.ActiveForm.Visible = false;
            pref.ShowDialog();
        }
    }
}
