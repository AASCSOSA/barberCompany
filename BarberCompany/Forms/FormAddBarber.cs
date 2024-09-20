using BarberCompany.Models;

namespace BarberCompany.Forms
{
    public partial class FormAddBarber : Form
    {

        public FormAddBarber()
        {
            InitializeComponent();


        }

        private void btnAddBarber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
             string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
             string.IsNullOrWhiteSpace(txtFatherLastName.Text) ||
             string.IsNullOrWhiteSpace(txtMotherLastName.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para agregar un barbero.");
                return;
            }

            bool availabilityBarber = cbDisponibilidad.Text == "Disponible";

            using (var context = new BarberShopContext())
            {

                var barber = new Barber
                {
                    AvailabilityBarber = availabilityBarber,
                    ContactNumber = txtContactNumber.Text,
                    FatherLastName = txtFatherLastName.Text,
                    MotherLastName = txtMotherLastName.Text,
                    NameBarber = txtName.Text,

                };
                context.Barbers.Add(barber);
                context.SaveChanges();
            }
            MessageBox.Show("Agregado");
            this.Close();
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
