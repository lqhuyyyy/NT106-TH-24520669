using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai02
{
    public partial class Lab03_Bai02 : Form
    {
        public Lab03_Bai02()
        {
            InitializeComponent();
        }

        Socket listener;
        Thread listenThread;

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            listenThread = new Thread(StartListening);
            listenThread.IsBackground = true;
            listenThread.Start();
            rtb_Out.AppendText("Telnet running on 127.0.0.1:8080\n");
        }

        private void StartListening()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8080);

            listener = new Socket(AddressFamily.InterNetwork,
                                  SocketType.Stream,
                                  ProtocolType.Tcp);

            listener.Bind(endPoint);
            listener.Listen(5);

            while (true)
            {
                Socket client = listener.Accept();
                Thread receiveThread = new Thread(() => ReceiveData(client));
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
        }

        private void ReceiveData(Socket client)
        {
            byte[] buffer = new byte[1024];
            int received;

            while ((received = client.Receive(buffer)) > 0)
            {
                string text = Encoding.ASCII.GetString(buffer, 0, received);
                rtb_Out.Invoke(() =>
                {
                    rtb_Out.AppendText(text);
                });

                client.Send(Encoding.ASCII.GetBytes(text));
            }
        }

        private void lb_Out_Click(object sender, EventArgs e)
        {

        }
    }
}
