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
            FormAddBarber form = new FormAddBarber();
            form.ShowDialog();

        }

        private void labelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            f.Hide();
        }

        private void flwBarbers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
