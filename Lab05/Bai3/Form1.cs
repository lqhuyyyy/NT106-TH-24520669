using System;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MimeKit;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Email và Password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var client = new Pop3Client())
                {
                    client.Connect("pop.gmail.com", 995, true);
                    client.Authenticate("recent:" + email, password);
                    int messageCount = client.Count;
                    lblTotal.Text = messageCount.ToString();
                    lblRecent.Text = messageCount.ToString();
                    listView1.Items.Clear();

                    // Lấy 15 mail gần nhất
                    int limit = Math.Min(15, messageCount);

                    for (int i = messageCount - 1; i >= messageCount - limit; i--)
                    {
                        var message = client.GetMessage(i);

                        ListViewItem item = new ListViewItem(message.Subject);
                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm:ss"));

                        listView1.Items.Add(item);
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}