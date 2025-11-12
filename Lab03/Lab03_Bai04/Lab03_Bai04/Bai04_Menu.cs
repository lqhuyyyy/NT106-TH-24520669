namespace Lab03_Bai04
{
    public partial class Bai04_Menu : Form
    {
        public Bai04_Menu()
        {
            InitializeComponent();
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            Bai04_Sever svForm = new Bai04_Sever();
            svForm.Show();
        }

        private void btn_CL_Click(object sender, EventArgs e)
        {
            Bai04_Client clForm = new Bai04_Client();
            clForm.Show();
        }
    }
}
