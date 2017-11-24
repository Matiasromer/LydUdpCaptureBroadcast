using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestSender
{
    class Program
    {
        // virker for Soap
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        public static void Start()
        {
            while (true)
            {
                Lyd newlyd = new Lyd() { Lyde = "55", Id = 2 };

                IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 7000);
                UdpClient sender = new UdpClient();

                byte[] data = Encoding.ASCII.GetBytes(newlyd.ToString());
                sender.Send(data, data.Length, ep);
            }
        }



    }
}
