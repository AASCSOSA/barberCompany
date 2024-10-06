using BarberCompany.Models;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BarberCompany.Forms
{
    public partial class FormAddReservation : Form
    {
        public FormAddReservation()
        {
            InitializeComponent();
            CargarBarberosEnComboBox();
            CargarFechasEnComboBox();
            CargarHorasEnComboBox();
            CargarServiciosEnComboBox();
            CargarSucursalesEnComboBox();
        }

        private void labelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void lbBarber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBarber f = new FormBarber();
            f.Show();
            this.Hide();
        }

        private void lbCities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReservation f = new FormReservation();
            f.Show();
            this.Hide();
        }

        private void lbServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormServices f = new FormServices();
            f.Show();
            this.Hide();
        }

        private void CargarServiciosEnComboBox()
        {
            using (var context = new BarberShopContext())
            {
                // Obtener todos los barberos
                var listaServicios = context.ServiceBarbers.ToList();

                // Asignar la lista al ComboBox
                cbServices.DataSource = listaServicios;
                cbServices.DisplayMember = "NameService";  // Mostrar el nombre de los barberos
                cbServices.ValueMember = "IdService";  // Valor asociado: el ID del barbero
            }
        }

        private void CargarBarberosEnComboBox()
        {
            using (var context = new BarberShopContext())
            {
                // Obtener todos los barberos
                var listaBarberos = context.Barbers.Where(b => b.AvailabilityBarber == true).ToList();

                // Asignar la lista al ComboBox
                cbBarber.DataSource = listaBarberos;
                cbBarber.DisplayMember = "NameBarber";  // Mostrar el nombre de los barberos
                cbBarber.ValueMember = "IdBarber";  // Valor asociado: el ID del barbero
            }
        }
        private void CargarSucursalesEnComboBox()
        {
            using (var context = new BarberShopContext())
            {
                // Obtener todos las sucursales
                var listaSucursales = context.BarberShops.ToList();

                // Asignar la lista al ComboBox
                cbBarberShop.DataSource = listaSucursales;
                cbBarberShop.DisplayMember = "NameBarber";  // Mostrar el nombre de los barberos
                cbBarberShop.ValueMember = "IdBarberShop";  // Valor asociado: el ID del barbero
            }
        }
        private void CargarFechasEnComboBox()
        {
            DateOnly fechaInicio = DateOnly.FromDateTime(DateTime.Today); // Fecha de inicio (hoy)
            DateOnly fechaFin = DateOnly.FromDateTime(DateTime.Today.AddMonths(3)); // Fecha de fin (3 meses a partir de hoy)

            cbDate.Items.Clear();

            for (DateOnly fecha = fechaInicio; fecha <= fechaFin; fecha = fecha.AddDays(1))
            {
                cbDate.Items.Add(fecha.ToString("dd/MM/yyyy"));  // Agrega las fechas en formato día/mes/año
            }

            cbDate.SelectedIndex = 0; // Selecciona la primera fecha (hoy) por defecto
        }
        private void CargarHorasEnComboBox()
        {
            TimeOnly horaInicio = new TimeOnly(9, 0);
            TimeOnly horaFin = new TimeOnly(18, 0);
            TimeSpan intervalo = TimeSpan.FromMinutes(30);

            cbHour.Items.Clear();

            for (TimeOnly hora = horaInicio; hora < horaFin; hora = hora.Add(intervalo))
            {
                cbHour.Items.Add(hora.ToString("HH:mm"));
            }

            cbHour.SelectedIndex = 0;
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {

            using (var context = new BarberShopContext())
            {

                var citation = new Citation();

                string fechaSeleccionada = cbDate.SelectedItem.ToString();
                DateOnly fecha = DateOnly.ParseExact(fechaSeleccionada, "dd/MM/yyyy", null);


                string horaSeleccionada = cbHour.SelectedItem.ToString();
                TimeOnly hora = TimeOnly.ParseExact(horaSeleccionada, "HH:mm", null);

                citation.DateCitation = fecha;
                citation.HourCitation = hora;
                citation.NameUser = txtUser.Text;
                Console.WriteLine(txtUser.Text);

                context.Citations.Add(citation);
                context.SaveChanges();

                MessageBox.Show("La cita ha sido guardada correctamente.");

                FormHome f = new FormHome();
                f.Show();
                this.Hide();
            }

        }

        private void cbBarber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
