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

namespace Lab03_Bai03
{
    public partial class Bai03_Client : Form
    {
        public Bai03_Client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        NetworkStream ns;

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                tcpClient.Connect(ip, 8080);
                ns = tcpClient.GetStream();
                rtb_Out.Text = "Connected to Server!";
                btn_Connect.Enabled = false;   
                btn_Send.Enabled = true;       
                btn_Disconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                rtb_Out.Text = "Error: " + ex.Message;
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (ns != null)
            {
                byte[] data = Encoding.ASCII.GetBytes(rtb_Out.Text + "\n");
                ns.Write(data, 0, data.Length);
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (ns != null)
            {
                byte[] data = Encoding.ASCII.GetBytes("quit\n");
                ns.Write(data, 0, data.Length);
                ns.Close();
                tcpClient.Close();
                rtb_Out.Text = "Disconnected!";
                btn_Connect.Enabled = true;    
                btn_Send.Enabled = false;      
                btn_Disconnect.Enabled = false;
            }
        }
    }
}
