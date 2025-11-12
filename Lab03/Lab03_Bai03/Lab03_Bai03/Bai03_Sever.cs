using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai03
{
    public partial class Bai03_Sever : Form
    {
        public Bai03_Sever()
        {
            InitializeComponent();
        }

        TcpListener listener;
        TcpClient client;
        NetworkStream ns;
        Thread threadServer;

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            threadServer = new Thread(StartServer);
            threadServer.IsBackground = true;
            threadServer.Start();
            btn_Listen.Enabled = false;
        }

        void StartServer()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, 8080);
                listener.Start();
                UpdateUI("Server started!\nWaiting for connection...");

                client = listener.AcceptTcpClient();
                UpdateUI($"Connection accepted from {client.Client.RemoteEndPoint}");

                ns = client.GetStream();
                byte[] data = new byte[1024];
                int bytes;

                while ((bytes = ns.Read(data, 0, data.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(data, 0, bytes);
                    UpdateUI($"From client: {message}");
                    if (message.Trim() == "quit") break;
                }

                ns.Close();
                client.Close();
                listener.Stop();
            }
            catch (Exception ex)
            {
                UpdateUI("Error: " + ex.Message);
            }
        }

        void UpdateUI(string msg)
        {
            if (InvokeRequired)
                Invoke(new Action<string>(UpdateUI), msg);
            else
                rtb_Out.AppendText(msg + Environment.NewLine);
        }
    }
}
