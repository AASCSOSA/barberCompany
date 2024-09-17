namespace BarberCompany.Forms
{
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void labelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void lbBarber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBarber f = new FormBarber();
            f.Show();
            this.Hide();
        }
    }
}
