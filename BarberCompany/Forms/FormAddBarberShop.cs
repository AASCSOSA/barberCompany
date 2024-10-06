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
using System.Xml.Linq;

namespace BarberCompany.Forms
{
    public partial class FormAddBarberShop : Form
    {
        public FormAddBarberShop()
        {
            InitializeComponent();
        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameShop.Text) ||
             string.IsNullOrWhiteSpace(txtAddress.Text) ||
             string.IsNullOrWhiteSpace(txtNumAddress.Text) ||
             string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos para agregar una sucursal.");
                return;
            }

            using (var context = new BarberShopContext())
            {

                var shop = new BarberShop
                {
                    NameBarber = txtNameShop.Text,
                    Address = txtAddress.Text,
                    AddressNumber = int.Parse(txtNumAddress.Text),
                    City = txtCity.Text,

                };
                context.BarberShops.Add(shop);
                context.SaveChanges();
            }
            MessageBox.Show("Sucursal agregada");
            this.Close();
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
