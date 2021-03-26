using System;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        /*
         Just like in Java, if your server should be 
         able to handle multiple clients in parallel, 
         you need multithreading.

        Modify the previous exercise, so that the server can 
        handle multiple clients.

        Test this by starting the server, then starting three 
        clients and verify the behaviour.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client...");

            TcpClient client = new TcpClient("127.0.0.1", 5000);

            NetworkStream stream = client.GetStream();

            while (true)
            {
                string input = Console.ReadLine();

                byte[] dataToServer = Encoding.ASCII.GetBytes(input);
                stream.Write(dataToServer, 0, dataToServer.Length);

                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);

                Console.WriteLine(response);
                if (input == "exit")
                {
                    break;
                }
            }
            stream.Close();
            client.Close();
        }
    }
}
