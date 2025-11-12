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

namespace Lab03_Bai01
{
    public partial class Bai01_Sever : Form
    {
        public Bai01_Sever()
        {
            InitializeComponent();
        }
        UdpClient udpServer;
        Thread threadServer;
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            int port = int.Parse(tb_Port.Text);
            udpServer = new UdpClient(port);
            threadServer = new Thread(new ThreadStart(ListenMessage));
            threadServer.IsBackground = true;
            threadServer.Start();
            MessageBox.Show("Server đang lắng nghe trên cổng " + port);
        }

        private void ListenMessage()
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                byte[] receiveBytes = udpServer.Receive(ref remoteEP);
                string receiveData = Encoding.UTF8.GetString(receiveBytes);
                this.Invoke(new MethodInvoker(delegate
                {
                    rtb_Out.AppendText(remoteEP.Address.ToString() + ": " + receiveData + "\n");
                }));
            }
        }
    }
}
