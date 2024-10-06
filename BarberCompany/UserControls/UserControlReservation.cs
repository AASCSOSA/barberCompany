using BarberCompany.Forms;
using BarberCompany.Models;

namespace BarberCompany.UserControls
{
    public partial class UserControlReservation : UserControl
    {
        public UserControlReservation(Citation citation)
        {
            InitializeComponent();
            this.Margin = new Padding(20);
            if (citation != null)
            {
                lbId.Text = citation.IdCitation.ToString();
                lbDate.Text = citation.DateCitation.ToString();
                lbHour.Text = citation.HourCitation.ToString();
                lbNameInfo.Text = citation.NameUser.ToString();
            }
            else
            {
                lbNameInfo.Text = "No hay una cita";
            }
        }

        private void btnElimined_Click(object sender, EventArgs e)
        {
            using (var context = new BarberShopContext())
            {
                int id = int.Parse(lbId.Text);
                // Buscar la cita por su Id
                var citation = context.Citations.FirstOrDefault(b => b.IdCitation == id);

                if (citation != null)
                {
                    // Eliminar la cita
                    context.Citations.Remove(citation);

                    context.SaveChanges();

                    MessageBox.Show("La cita se ha cancelado.");

                }
                else
                {
                    MessageBox.Show("No se encontró la cita.");
                }
            }
            FormReservation f = new FormReservation();
            f.Show();
            this.Hide();
        }
    }
}

