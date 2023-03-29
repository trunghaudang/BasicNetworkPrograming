using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {

        private int Port = 8080; // Port number for the server
        private readonly UdpClient udpServer; 
        private Thread listenThread; // Thread for listening message
        public Form1()
        {
            InitializeComponent();            
            udpServer = new UdpClient(Port);

            // Start the listening thread
            listenThread = new Thread(ListenForClients);
            listenThread.Start();
        }

        void ListenForClients()
        {

             while (true)
             {
                    // Receive message from client
                    IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] clientData = udpServer.Receive(ref clientEndPoint);
                    string message = Encoding.Unicode.GetString(clientData);

                    // Show the received message
                    Invoke(new Action(() =>
                    {
                        txt_ServerView.AppendText($"Client ({clientEndPoint.Port}): {message}\r\n");
                    }));

                    // Send message back to the client
                    byte[] responseData = Encoding.Unicode.GetBytes(message);
                    udpServer.Send(responseData, responseData.Length, clientEndPoint);

             }
             
        }
        
    }
}
