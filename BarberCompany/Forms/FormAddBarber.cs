using BarberCompany.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
             string.IsNullOrWhiteSpace(txtFatherLastName.Text) ||
             string.IsNullOrWhiteSpace(txtMotherLastName.Text) ||
             string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para agregar un barbero."); 
                return;
            }

            bool availabilityBarber = txtAvailabilityBarber.Text == "1";

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
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
