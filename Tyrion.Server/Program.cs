using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Tyrion.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress address = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndpoint = new IPEndPoint(address, 5000);
            listener.Bind(localEndpoint);
            listener.Listen(100);
            Socket s = listener.Accept();
            
        }
    }
}
