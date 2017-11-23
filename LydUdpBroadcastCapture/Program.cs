using System;
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

        

        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }
        private static void Start()
        {
            //hiver webserviceen ind (husk at kigge efter navnet i app-config og paste det ind)
            using (var reciever = new LydReference1.Service1Client("BasicHttpBinding_IService1"))
            {
                int port = 7000;
                //192.168.1.7
                //bruger udpclient da dataen bliver broadcastet fra raspen og
                //giver clienten portnummeret, i det her tilfælde 7000(Skal matche det i raspen)
                using (UdpClient client = new UdpClient(port))
                {
                    while (true)
                    {
                        //beder den om at lytte på alle adresser og port 7000 
                        IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, port);

                        //lægger det modtagede data ned i et byte-array
                        //som modtages fra clientens endpoint
                        byte[] recieved = client.Receive(ref endpoint);
                        //skriver adressen og portnummeret ud i konsollen
                        Console.WriteLine("Modtaget fra: " + endpoint.Address + " På Port: " + endpoint.Port);

                        //laver byte-arrayet om til en string.
                        string str = Encoding.ASCII.GetString(recieved);
                        Console.WriteLine("Sender: " + str);

                        //sender tekst fra raspen gennem soapservicen til databasen
                        reciever.PostLydToList(str);
                    }
                }
            }
        }
    }

}
                

