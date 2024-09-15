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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void lbBarber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHome f2 = new FormHome();
            FormBarber f = new FormBarber();
            f.Show();
            f2.Close();


        }

        private void lbCities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReservation f = new FormReservation();
            f.ShowDialog();
        }

        private void btnCities_Click(object sender, EventArgs e)
        {
            FormAddReservation f    = new FormAddReservation(); 
            f.ShowDialog();
        }
    }
}
