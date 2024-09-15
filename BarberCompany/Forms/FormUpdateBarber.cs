using BarberCompany.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BarberCompany.Forms
{
    public partial class FormUpdateBarber : Form
    {
        private int barberId;
        FormBarber f = new FormBarber();

        public FormUpdateBarber(string name, string availability, string contact, string fatherName, string motherName, string id)
        {
            InitializeComponent();

            // Convertir id a entero para buscar en la base de datos
            barberId = int.Parse(id);

            txtId.Text = id;
            txtName.Text = name;
            txtFatherLastName.Text = fatherName;
            txtMotherLastName.Text = motherName;
            txtContactNumber.Text = contact;
            txtAvailabilityBarber.Text = availability;
        }

        private void btnUpdateBarber_Click(object sender, EventArgs e)
        {
            using (var context = new BarberShopContext())
            {
                // Buscar el barbero por su Id
                var barber = context.Barbers.FirstOrDefault(b => b.IdBarber == barberId);

                if (barber != null)
                {
                    // Actualizar las propiedades del barbero con los valores del formulario
                    barber.NameBarber = txtName.Text;
                    barber.FatherLastName = txtFatherLastName.Text;
                    barber.MotherLastName = txtMotherLastName.Text;
                    barber.ContactNumber = txtContactNumber.Text;
                    barber.AvailabilityBarber = bool.TryParse(txtAvailabilityBarber.Text, out bool availability) ? availability : barber.AvailabilityBarber;

                    // Guardar los cambios en la base de datos
                    context.SaveChanges();

                    MessageBox.Show("La información del barbero se ha actualizado correctamente.");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se encontró el barbero con el Id especificado.");
                }
            }
        }

        private void btnElimined_Click(object sender, EventArgs e)
        {
            using (var context = new BarberShopContext())
            {
                // Buscar el barbero por su Id
                var barber = context.Barbers.FirstOrDefault(b => b.IdBarber == barberId);

                if (barber != null)
                {
                    // Eliminar el barbero
                    context.Barbers.Remove(barber);

                    // Guardar los cambios en la base de datos
                    context.SaveChanges();

                    MessageBox.Show("El barbero ha sido eliminado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró el barbero con el Id especificado.");
                }
            }
        }
    }
}
