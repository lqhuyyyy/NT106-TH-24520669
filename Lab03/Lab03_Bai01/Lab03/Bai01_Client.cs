using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai01
{
    public partial class Bai01_Client : Form
    {
        public Bai01_Client()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string ip = tb_IP.Text;
            int port = int.Parse(tb_Port.Text);
            string message = rtb_Out.Text;

            UdpClient udpClient = new UdpClient();
            byte[] data = Encoding.UTF8.GetBytes(message);
            udpClient.Send(data, data.Length, ip, port);
            udpClient.Close();

            MessageBox.Show("Đã gửi thông điệp đến Server!");
        }
    }
}
