using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
namespace Tyrion.Server
{
    class Server
    {
        static void Main(string[] args)
        {
            string path = @"G:\Music\Daft Punk\Random Access Memories\";
            string mp3 = "";
            MusicDirectoryTraverse(@"D:\Music");
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var file in dir.GetFiles())
            {
                if (file.Name.Contains("Crush"))
                {
                    mp3 = file.Directory.ToString() + "\\" + file.ToString();
                }
            }
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress address = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndpoint = new IPEndPoint(address, 5000);
            listener.Bind(localEndpoint);
            listener.Listen(100);
            Console.WriteLine("Listening");
            while (true)
            {
                FileStream mp3Stream = new FileStream(mp3, FileMode.Open);
                Socket s = listener.Accept();
                Console.WriteLine("Accepted");
                byte[] buf = new byte[8192];
                int numberRead = 0;
                while ((numberRead = mp3Stream.Read(buf, 0, buf.Length)) > 0)
                {
                    s.Send(buf, 0, numberRead, SocketFlags.None);
                }
                s.Close();
                mp3Stream.Close();
            }
        }
        static void MusicDirectoryTraverse(string root)
        {
            DirectoryInfo rootDirectory = new DirectoryInfo(root);
            var x = rootDirectory.GetFiles("*.*", SearchOption.AllDirectories).Where(w=>w.Extension.ToLower().Contains("mp3"));
        }
    }
}
