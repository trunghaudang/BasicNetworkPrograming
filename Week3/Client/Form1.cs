using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        private const int Port = 8080; // Port number for the server
        private readonly UdpClient udpClient; 
        private IPEndPoint serverEndPoint;
        public Form1()
        {
            InitializeComponent();
           
            udpClient = new UdpClient();         
            serverEndPoint = new IPEndPoint(IPAddress.Loopback, Port);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            // Get the message text from client and send to server 
            string message = txt_ClientMess.Text;        
            byte[] messageData = Encoding.Unicode.GetBytes(message);
            udpClient.Send(messageData, messageData.Length, serverEndPoint);

            // Receive response from the server
            byte[] responseData = udpClient.Receive(ref serverEndPoint);
            string responseMessage = Encoding.Unicode.GetString(responseData);
           
            
            //Show the response message
            txt_ClientView.AppendText($"Server({serverEndPoint.Port}): {responseMessage}\r\n");
        }

        
    }
}
