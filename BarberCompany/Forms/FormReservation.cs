using BarberCompany.Models;
using BarberCompany.UserControls;

namespace BarberCompany.Forms
{
    public partial class FormReservation : Form
    {
        public FormReservation()
        {
            InitializeComponent();
            LoadCitations();
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

        private void lbServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormServices f = new FormServices();
            f.Show();
            this.Hide();
        }

        private void LoadCitations()
        {
            fwlPanelReservation.Controls.Clear(); // Limpia los controles existentes


            using (var context = new BarberShopContext())
            {
                var citation = context.Citations.ToList();

                foreach (var citations in citation)
                {
                    UserControlReservation userControl = new UserControlReservation(citations);
                    fwlPanelReservation.Controls.Add(userControl);

                }
            }
        }
    }
}
