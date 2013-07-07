using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tyrion.Services;

namespace Tyrion.Server
{
    class Server
    {
        static void Main(string[] args)
        {
            string mp3 = "";
            ThreadPool.QueueUserWorkItem((state) => { MusicDirectory.IndexAudioFiles(@"E:\Music"); });
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress address = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndpoint = new IPEndPoint(address, 5000);
            listener.Bind(localEndpoint);
            listener.Listen(100);
            Console.WriteLine("Listening");
            while (true)
            {
                
                Socket s = listener.Accept();
                NetworkStream n = new NetworkStream(s);
                Console.WriteLine("Accepted");
                byte[] buf = new byte[8192];
                n.Read(buf, 0, buf.Length);
                string fileId = System.Text.Encoding.UTF8.GetString(buf);
                int id = int.Parse(fileId);
                Console.WriteLine(id);
                AudioFileService fileService = new AudioFileService();
                mp3 = fileService.GetPathById(id);
                int numberRead = 0;
                FileStream mp3Stream = new FileStream(mp3, FileMode.Open);
                while ((numberRead = mp3Stream.Read(buf, 0, buf.Length)) > 0)
                {
                    s.Send(buf, 0, numberRead, SocketFlags.None);
                }
                s.Close();
                mp3Stream.Close();
            }
        }
    }
}
