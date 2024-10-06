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

namespace BarberCompany.UserControls
{
    public partial class UserControlShopBarber : UserControl
    {
        public UserControlShopBarber(BarberShop shop)
        {
            InitializeComponent();
            this.Margin = new Padding(20);

            if (shop != null)
            {
                lbIdShop.Text = shop.IdBarberShop.ToString();
                lbNameShop.Text = shop.NameBarber;
                lbAddressShop.Text = shop.Address;
                lbNumShop.Text = shop.AddressNumber.ToString();
                lbCityShop.Text = shop.City; 

            }
            else
            {
                lbNameShop.Text = "No se encontró una sucursal";
            }
        }
    }
}
