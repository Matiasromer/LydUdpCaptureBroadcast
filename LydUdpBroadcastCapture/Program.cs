﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace LydUdpBroadcastCapture
{
    class Program
    {

        private const int port = 11001;
        // Virker for Soap
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }
        // Lavet local reference hvis man skal bruge breakpoint. Husk at ændre reference til local i metode hvis det skal bruges!
        private static void Start()
        {
            using (var reciever = new LydReference1.Service1Client("BasicHttpBinding_IService1"))
            {
                using (UdpClient client = new UdpClient(new IPEndPoint(IPAddress.Any, port)))
                {
                    IPEndPoint remoteEndPoint = new IPEndPoint(0, 0);
                    while (true)
                    {
                        Console.WriteLine("Waiting for broadcast {0}", client.Client.LocalEndPoint);
                        byte[] datagramReceived = client.Receive(ref remoteEndPoint);

                        string str = Encoding.ASCII.GetString(datagramReceived, 0, datagramReceived.Length);
                        Console.WriteLine("Receives {0} bytes from {1} port {2} message {3}", datagramReceived.Length,
                            remoteEndPoint.Address, remoteEndPoint.Port, str);

                        if (reciever.TjekStatus())
                        {
                            reciever.PostLydToList(str);
                            Console.WriteLine("Saved");
                        }


                    }
                }
            }
        }

              
    }

  
}


