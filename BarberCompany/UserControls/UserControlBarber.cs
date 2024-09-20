using BarberCompany.Forms;
using BarberCompany.Models;

namespace BarberCompany
{
    public partial class UserControlBarber : UserControl
    {
        public UserControlBarber(Barber barber)
        {
            InitializeComponent();
            this.Margin = new Padding(20);

            if (barber != null)
            {
                lbId.Text = barber.IdBarber.ToString();
                lbNameBarber.Text = barber.NameBarber;
                lbFatherName.Text = barber.FatherLastName;
                lbMother.Text = barber.MotherLastName;
                lbAvilabilityBarber.Text = barber.AvailabilityBarber.HasValue
                     ? (barber.AvailabilityBarber.Value ? "Disponible" : "No Disponible")
                     : "Sin datos";


                // Asignar el número de contacto a lbTelephoneNumber 
                lbTelephoneNumber.Text = barber.ContactNumber;
            }
            else
            {
                lbNameBarber.Text = "No se encontró un barbero";
                lbTelephoneNumber.Text = "Sin datos";
            }
        }

        private void UserControlBarber_Click(object sender, EventArgs e)
        {
            string id = lbId.Text;
            string name = lbNameBarber.Text;
            string fatherName = lbFatherName.Text;
            string motherName = lbMother.Text;
            string availability = lbAvilabilityBarber.Text;
            string contact = lbTelephoneNumber.Text;


            FormUpdateBarber f = new FormUpdateBarber(name, availability, contact, fatherName, motherName, id);
            f.ShowDialog();
        }
    }
}




