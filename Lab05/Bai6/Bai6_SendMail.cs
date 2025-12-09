using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Bai6_SendMail : Form
    {
        public string email { get; set; }
        public string password { get; set; }
        public Bai6_SendMail()
        {
            InitializeComponent();
        }
        private void Bai6_SendMail_Load(object sender, EventArgs e)
        {
            mailfrom.Text = email;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path.Text = dialog.FileName;
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(name.Text, mailfrom.Text));
            message.To.Add(MailboxAddress.Parse(mailto.Text));
            message.Subject = subject.Text;

            var bodyBuilder = new BodyBuilder();

            // Xử lý HTML hoặc Text thường
            if (checkBox.Checked)
                bodyBuilder.HtmlBody = richTextBox1.Text;
            else
                bodyBuilder.TextBody = richTextBox1.Text;

            // Đính kèm file
            if (!string.IsNullOrEmpty(path.Text) && File.Exists(path.Text))
            {
                bodyBuilder.Attachments.Add(path.Text);
            }

            message.Body = bodyBuilder.ToMessageBody();

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate(email, password);
                    client.Send(message);
                    client.Disconnect(true);
                    MessageBox.Show("Gửi mail thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
