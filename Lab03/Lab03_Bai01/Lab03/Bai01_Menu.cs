using Lab03_Bai01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai01_Menu : Form
    {
        public Bai01_Menu()
        {
            InitializeComponent();
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            Bai01_Sever svForm = new Bai01_Sever();
            svForm.Show();
        }

        private void btn_CL_Click(object sender, EventArgs e)
        {
            Bai01_Client clForm = new Bai01_Client();
            clForm.Show();
        }
    }
}
