using System.Diagnostics;

namespace BarberCompany.Forms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void lbBarber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBarber f = new FormBarber();
            f.Show();
            this.Hide();



        }

        private void lbCities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReservation f = new FormReservation();
            f.Show();
            this.Hide();
        }

        private void btnCities_Click(object sender, EventArgs e)
        {
            FormAddReservation f = new FormAddReservation();
            f.Show();
            this.Hide();
        }

        private void lbServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormServices f = new FormServices();
            f.Show();
            this.Hide();
        }

        private void lbBarberShop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShopBarber f = new FormShopBarber();
            f.Show();
            this.Hide();
        }
    }
}
