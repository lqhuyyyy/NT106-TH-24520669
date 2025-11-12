namespace Lab03_Bai06
{
    public partial class Bai06_Menu : Form
    {
        public Bai06_Menu()
        {
            InitializeComponent();
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            Bai06_Sever severForm = new Bai06_Sever();
            severForm.Show();
        }

        private void btn_CL_Click(object sender, EventArgs e)
        {
            Bai06_Client clientForm = new Bai06_Client();
            clientForm.Show();
        }
    }
}
