using System;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        /*
         Copy the echo client/server example from the slides.

        Modify the Client so that it takes input from the user, 
        which is sent to and echoed from the server. 
        Make it so the client terminates when the user types "exit". 
        This should happen in a while loop, so it will continue 
        taking input, sending and receiving, until "exit" is typed.

        You will also have to add an extra while loop in the server.
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
