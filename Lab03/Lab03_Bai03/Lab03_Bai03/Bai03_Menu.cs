using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai03
{
    public partial class Bai03_Menu : Form
    {
        public Bai03_Menu()
        {
            InitializeComponent();
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            Bai03_Sever severForm = new Bai03_Sever();
            severForm.Show();
        }

        private void btn_CL_Click(object sender, EventArgs e)
        {
            Bai03_Client clientForm = new Bai03_Client();
            clientForm.Show();
        }

    }
}
