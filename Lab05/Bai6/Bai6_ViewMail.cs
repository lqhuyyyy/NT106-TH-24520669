using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Bai6
{
    public partial class Bai6_ViewMail : Form
    {
        public string user;
        public string password;
        public Bai6_ViewMail(string from, string to, string subject, string body)
        {
            InitializeComponent();
            textbox_from.Text = from;
            textbox_to.Text = to;
            label_Subject.Text = subject;
            LoadHtmlAsync(body);
        }
        private async void LoadHtmlAsync(string htmlContent)
        {
            // Khởi tạo WebView2
            await webView21.EnsureCoreWebView2Async();
            // Hiển thị nội dung HTML
            webView21.CoreWebView2.NavigateToString(htmlContent);
        }

        private void reply_Click(object sender, EventArgs e)
        {
            Bai6_SendMail replyForm = new Bai6_SendMail();
            replyForm.email = user;
            replyForm.password = password;

            // Tự động điền thông tin Reply
            replyForm.mailto.Text = textbox_from.Text;
            replyForm.subject.Text = "RE: " + label_Subject.Text;

            replyForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}