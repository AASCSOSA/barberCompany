using BarberCompany.Models;

namespace BarberCompany.Forms
{
    public partial class FormBarber : Form
    {
        public FormBarber()
        {
            InitializeComponent();

            LoadBarbers();
            flwBarbers.Padding = new Padding(40);
        }

        private void LoadBarbers()
        {
            flwBarbers.Controls.Clear(); // Limpia los controles existentes

            using (var context = new BarberShopContext())
            {
                var barbers = context.Barbers.ToList();
                foreach (var barber in barbers)
                {
                    UserControlBarber userControl = new UserControlBarber(barber);
                    flwBarbers.Controls.Add(userControl);
                }
            }
        }

        private void btnNewBarber_Click(object sender, EventArgs e)
        {
            // Crea una instancia de FormAddBarber y suscríbete al evento FormClosed
            FormAddBarber f = new FormAddBarber();
            f.FormClosed += (s, args) =>
            {
                LoadBarbers(); // Actualiza la lista de barberos cuando se cierra el formulario de agregar
            };
            f.Show();
        }

        private void labelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }





        private void flwBarbers_Paint(object sender, PaintEventArgs e)
        {
            // Código de pintura (si es necesario)
        }

        private void lbCities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReservation f = new FormReservation();
            f.Show();
            this.Hide();
        }

        private void lbServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormServices f = new FormServices();
            f.Show();
            this.Hide();
        }
    }
}
