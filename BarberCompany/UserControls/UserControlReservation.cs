using BarberCompany.Forms;
using BarberCompany.Models;
using System.Threading;

namespace BarberCompany.UserControls
{
    public partial class UserControlReservation : UserControl
    {
        //private List<Citation> citation;

        public UserControlReservation(Citation citation)
        {
            InitializeComponent();
            this.Margin = new Padding(20);

            if (citation != null)
            {
                lbId.Text = citation.IdCitation.ToString();
                lbDate.Text = citation.DateCitation.ToString();
                lbHour.Text = citation.HourCitation.ToString();
                lbNameInfo.Text = citation.NameUser;
                //lbBarber.Text = barber.NameBarber.ToString();

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
                // Buscar el barbero por su Id
                var citation = context.Citations.FirstOrDefault(b => b.IdCitation == id);

                if (citation != null)
                {
                    // Eliminar el barbero
                    context.Citations.Remove(citation);

                    // Guardar los cambios en la base de datos
                    context.SaveChanges();

                    MessageBox.Show("La cita se ha sido cancelado.");
                    
                }
                else
                {
                    MessageBox.Show("No se encontró el barbero con el Id especificado.");
                }
            }
            FormReservation f = new FormReservation();
            f.Show();
            this.Hide();
        }
    }
}
