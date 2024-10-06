using BarberCompany.Models;
using BarberCompany.UserControls;
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
    public partial class FormShopBarber : Form
    {
        public FormShopBarber()
        {
            InitializeComponent();
            LoadShopsBarber();
            flwShopsBarber.Padding = new Padding(40);
        }

        private void LoadShopsBarber()
        {
            flwShopsBarber.Controls.Clear(); // Limpia los controles existentes

            using (var context = new BarberShopContext())
            {
                var shops = context.BarberShops.ToList();
                foreach (var shop in shops)
                {
                    UserControlShopBarber userControl = new UserControlShopBarber(shop);
                    flwShopsBarber.Controls.Add(userControl);
                }
            }
        }
        private void btnNewShopBarber_Click(object sender, EventArgs e)
        {
            FormAddBarberShop f = new FormAddBarberShop();
            f.FormClosed += (s, args) =>
            {
                LoadShopsBarber();
            };
            f.Show();
        }

        //Rutas
        private void labelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void lbServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormServices f = new FormServices();
            f.Show();
            this.Hide();
        }

        private void lbCities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReservation f = new FormReservation();
            f.Show();
            this.Hide();
        }

        private void lbBarber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBarber f = new FormBarber();
            f.Show();
            this.Hide();
        }

        private void lbShopBarber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
