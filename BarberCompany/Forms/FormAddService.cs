using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BarberCompany.Models;

namespace BarberCompany.Forms
{
    public partial class FormAddService : Form
    {
        public FormAddService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                 string.IsNullOrWhiteSpace(txtDescription.Text) ||
                 string.IsNullOrWhiteSpace(txtCost.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para agregar un servicio.");
                return;
            }

            using (var context = new BarberShopContext())
            {

                var service = new ServiceBarber
                {
                    NameService = txtName.Text,
                    DescriptionService = txtDescription.Text,
                    ServiceCost = (decimal)float.Parse(txtCost.Text)

                };
                context.ServiceBarbers.Add(service);
                context.SaveChanges();
            }
            MessageBox.Show("Servicio Agregado");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
