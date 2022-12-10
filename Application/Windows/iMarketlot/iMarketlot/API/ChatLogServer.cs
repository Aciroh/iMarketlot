using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace iMarketlot.API
{
    class ChatLogServer
    {
        private static List<String> receivedMessages;
        private static TcpListener listener;
        private static IPAddress ipAddress = null;
        private static Boolean serverStatus = false;
        public static event EventHandler<EventArgs> receivedMessage;
        public static event EventHandler<EventArgs> serverStarted;


        public ChatLogServer()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = ip;
                }
            }
        }

        public Boolean getServerStatus()
        {
            return serverStatus;
        }

        public void startServer()
        {
            // Initialize the list of incoming strings
            receivedMessages = new List<String>();            

            // Start the server at port 7777
            listener = new TcpListener(ipAddress, 7777);
            listener.Start();
            serverStatus = true;
            serverStarted(null, EventArgs.Empty);


            // Accept incoming connections in a loop
            while (true)
            {
                // Get the next incoming connection
                TcpClient client = listener.AcceptTcpClient();

                // Read the incoming string from the client
                String incomingString = readString(client);

                // Add the incoming string to the list of incoming strings
                receivedMessages.Add(incomingString);

                //Trigger receivedMessage event
                receivedMessage(null, EventArgs.Empty);

                // Close the connection with the client
                client.Close();
            }
        }

        public void stopServer()
        {
            serverStatus = false;
            listener.Stop();
        }

        public IPAddress getIPAddress()
        {
            return ipAddress;
        }

        // Reads a string from the given TcpClient
        private String readString(TcpClient client)
        {
            // Get the network stream from the client
            NetworkStream stream = client.GetStream();

            // Read the incoming bytes from the stream
            byte[] incomingBytes = new byte[1024];
            int byteCount = stream.Read(incomingBytes, 0, incomingBytes.Length);

            // Convert the bytes to a string
            String incomingString = Encoding.UTF8.GetString(incomingBytes, 0, byteCount);

            

            Console.WriteLine(incomingString);

            // Return the string
            return incomingString;
        }

        // Gets the list of incoming strings
        public List<String> getReceivedMessages()
        {
            return receivedMessages;
        }
    }
}
