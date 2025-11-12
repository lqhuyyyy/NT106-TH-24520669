namespace Lab03_Bai05
{
    public partial class Bai05_Menu : Form
    {
        public Bai05_Menu()
        {
            InitializeComponent();
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            Bai05_Sever severForm = new Bai05_Sever();
            severForm.Show();
        }

        private void btn_CL_Click(object sender, EventArgs e)
        {
            Bai05_Client clientForm = new Bai05_Client();
            clientForm.Show();
        }
    }
}
