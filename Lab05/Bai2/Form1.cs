using MailKit.Net.Imap;
using MailKit.Security;
using MimeKit;
using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private const string ImapServer = "imap.gmail.com";
        private const int ImapPort = 993;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            listViewEmails.Items.Clear();
            lblTotal.Text = "0";
            lblRecent.Text = "0";

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            using (var client = new ImapClient())
            {
                try
                {
                    // Kết nối IMAP
                    await client.ConnectAsync(ImapServer, ImapPort, SecureSocketOptions.SslOnConnect);

                    // Đăng nhập (gmail app password)
                    await client.AuthenticateAsync(email, password);

                    // Mở inbox
                    var inbox = client.Inbox;
                    await inbox.OpenAsync(MailKit.FolderAccess.ReadOnly);

                    // Thống kê
                    lblTotal.Text = inbox.Count.ToString();
                    lblRecent.Text = inbox.Recent.ToString();

                    // Lấy 10 email mới nhất
                    int total = inbox.Count;
                    int limit = 10;
                    int start = total - limit;
                    if (start < 0) start = 0;

                    for (int i = total - 1; i >= start; i--)
                    {
                        var message = await inbox.GetMessageAsync(i);

                        string subject = message.Subject ?? "(No subject)";
                        string from = message.From?.ToString() ?? "(Unknown)";
                        string date = message.Date.ToString("dd/MM/yyyy HH:mm:ss");

                        var item = new ListViewItem(subject);
                        item.SubItems.Add(from);
                        item.SubItems.Add(date);

                        // Thêm vào listview (phải dùng Invoke)
                        listViewEmails.Invoke((MethodInvoker)(() =>
                        {
                            listViewEmails.Items.Add(item);
                        }));
                    }
                }
                catch (MailKit.Security.AuthenticationException)
                {
                    MessageBox.Show("Sai mật khẩu hoặc chưa bật IMAP / App Password.",
                        "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}",
                        "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (client.IsConnected)
                        await client.DisconnectAsync(true);
                }
            }
        }
    }
}
