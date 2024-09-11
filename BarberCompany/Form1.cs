using BarberCompany.Models;

namespace BarberCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new BarberShopContext())
            {
                string nombre=txtName.Text;
                var barber = new Barber
                {
                    AvailabilityBarber = true,
                    ContactNumber = "2251182095",
                    FatherLastName = "Sosa",
                    MotherLastName = "Cruz",
                    NameBarber = nombre
                };
                context.Barbers.Add(barber);
                context.SaveChanges();
            }
        }
    }
}
