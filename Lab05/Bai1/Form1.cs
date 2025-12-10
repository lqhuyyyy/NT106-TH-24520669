
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using MailKit.Net.Smtp;
using MimeKit;
namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Send_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(TB_From.Text, "ulsk rlnz uwgo tahu");
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Huy Phước", TB_From.Text));
                message.To.Add(new MailboxAddress("", TB_To.Text));
                message.Subject = TB_Sub.Text;
                message.Body = new TextPart("plain")
                {
                    Text = TB_Body.Text,
                };
                client.Send(message);
                MessageBox.Show("Gửi thành công " , "Gửi tin nhắn thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi trả về: " + ex.Message, "Lỗi xảy ra!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
