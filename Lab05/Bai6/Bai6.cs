using MailKit;
using MailKit.Security;
using MailKit.Net.Imap;
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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }
        private void GetMail(string username_, string password_)
        {
            var client = new ImapClient();
            try
            {
                // Kết nối IMAP server
                client.Connect(imapBox.Text, int.Parse(imapPort.Text), SecureSocketOptions.SslOnConnect);
                client.Authenticate(username_, password_);

                // Cập nhật giao diện
                logout.Visible = true;
                refresh.Visible = true;
                sendMail.Visible = true;
                login.Visible = false;
                username.ReadOnly = true;
                password.ReadOnly = true;

                var inboxMail = client.Inbox;
                inboxMail.Open(FolderAccess.ReadOnly);

                // Lấy 20 mail gần nhất
                var messages = inboxMail.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope | MessageSummaryItems.Body)
                                        .OrderByDescending(x => x.Date)
                                        .Take(20);

                dataGridView.Rows.Clear();
                int index = 1;
                foreach (var message in messages)
                {
                    var email = inboxMail.GetMessage(message.UniqueId);
                    var from = message.Envelope.From.ToString();
                    var subject = message.Envelope.Subject;
                    var date = message.Date.LocalDateTime.ToString("dd/MM/yyyy HH:mm:ss");

                    var row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell
                    {
                        Value = index,
                        Tag = email.HtmlBody
                    });

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = from });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = subject });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = date });

                    dataGridView.Rows.Add(row);
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed: " + ex.Message);
            }
            finally
            {
                client.Disconnect(true);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
                return;
            GetMail(username.Text, password.Text);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            logout.Visible = false;
            refresh.Visible = false;
            sendMail.Visible = false;
            login.Visible = true;
            username.ReadOnly = false;
            password.ReadOnly = false;
            username.Text = "";
            password.Text = "";
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            login_Click(sender, e);
        }

        private void sendMail_Click(object sender, EventArgs e)
        {
            Bai6_SendMail sendForm = new Bai6_SendMail();
            sendForm.email = username.Text;
            sendForm.password = password.Text;
            sendForm.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var body = dataGridView.Rows[e.RowIndex].Cells[0].Tag; 
                string from = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string subject = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                Bai6_ViewMail viewForm = new Bai6_ViewMail(from, username.Text, subject, body != null ? body.ToString() : "");
                viewForm.user = username.Text;
                viewForm.password = password.Text;
                viewForm.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
