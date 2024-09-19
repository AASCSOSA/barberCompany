using BarberCompany.Models;
using BarberCompany.UserControls;

namespace BarberCompany.Forms
{
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
            LoadServices();
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

        private void btnCities_Click(object sender, EventArgs e)
        {
            // Crea una instancia de FormAddBarber y suscríbete al evento FormClosed
            FormAddServices f = new FormAddServices();

            f.FormClosed += (s, args) =>
            {
                LoadServices(); // Actualiza la lista de barberos cuando se cierra el formulario de agregar
            };
            f.Show();
        }

        private void LoadServices()
        {
            flwPanelService.Controls.Clear(); // Limpia los controles existentes


            using (var context = new BarberShopContext())
            {
                var services = context.ServiceBarbers.ToList();
                foreach (var service in services)
                {
                    UserControlServiceHair userControl = new UserControlServiceHair(service);

                    flowLayoutPanel1.Controls.Add(userControl);
                }
            }
        }

        private void lbCities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Crea una instancia de FormAddBarber y suscríbete al evento FormClosed

            FormAddReservation f = new FormAddReservation();
            f.Show();
            this.Hide();
        }

        private void btnCities_Click_1(object sender, EventArgs e)
        {
            FormAddServices f = new FormAddServices();
            f.FormClosed += (s, args) =>
            {
                LoadServices(); // Actualiza la lista de barberos cuando se cierra el formulario de agregar
            };
            f.Show();
        }

        private void lbCities_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddReservation f = new FormAddReservation();
            f.Show();
            this.Hide();
        }
    }
}
