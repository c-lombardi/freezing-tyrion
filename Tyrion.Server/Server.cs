﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
<<<<<<< HEAD
using Tyrion.Services;

=======
<<<<<<< HEAD
=======
using Tyrion.Services;

>>>>>>> master
>>>>>>> 7ff262619f4f9d68d2c265b2a6fd67fe7afe6546
namespace Tyrion.Server
{
    class Server
    {
        static void Main(string[] args)
        {
            string mp3 = "";
<<<<<<< HEAD
            ThreadPool.QueueUserWorkItem((state) => { MusicDirectory.IndexAudioFiles(@"E:\Music"); });
=======
<<<<<<< HEAD
            MusicDirectoryTraverse(@"E:\Music");
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var file in dir.GetFiles())
            {
                if (file.Name.Contains("Crush"))
                {
                    mp3 = file.Directory.ToString() + "\\" + file.ToString();
                }
            }
=======
            ThreadPool.QueueUserWorkItem((state) => { MusicDirectory.IndexAudioFiles(@"D:\Music"); });
>>>>>>> master
>>>>>>> 7ff262619f4f9d68d2c265b2a6fd67fe7afe6546
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
