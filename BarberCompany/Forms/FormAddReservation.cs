using BarberCompany.Models;
using System.Xml.Linq;

namespace BarberCompany.Forms
{
    public partial class FormAddReservation : Form
    {
        private int barberId;
        public FormAddReservation()
        {
            InitializeComponent();
            CargarBarberosEnComboBox();
            CargarServiciosEnComboBox();
            CargarFechasEnComboBox();
            CargarHorasEnComboBox();
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

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            using (var context = new BarberShopContext())
            {
                // Crear una nueva instancia de la clase Citation
                var citation = new Citation();

                // Obtener la fecha seleccionada desde el ComboBox
                string fechaSeleccionada = cbDate.SelectedItem.ToString();
                DateOnly fecha = DateOnly.ParseExact(fechaSeleccionada, "dd/MM/yyyy", null);

                // Obtener la hora seleccionada desde el ComboBox
                string horaSeleccionada = cbTime.SelectedItem.ToString();
                TimeOnly hora = TimeOnly.ParseExact(horaSeleccionada, "HH:mm", null);

                // Asignar los valores de fecha y hora a los campos correspondientes de Citation
                citation.DateCitation = fecha;
                citation.HourCitation = hora;
                citation.NameUser = txtName.Text;

                context.Citations.Add(citation);
                context.SaveChanges();

                MessageBox.Show("La cita ha sido guardada correctamente.");

                FormHome f = new FormHome();
                f.Show();
                this.Hide();
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
            TimeOnly horaInicio = new TimeOnly(9, 0);  // Inicio del horario (9:00 AM)
            TimeOnly horaFin = new TimeOnly(18, 0);    // Fin del horario (6:00 PM)
            TimeSpan intervalo = TimeSpan.FromMinutes(30);  // Intervalo de 30 minutos

            cbTime.Items.Clear();

            for (TimeOnly hora = horaInicio; hora < horaFin; hora = hora.Add(intervalo))
            {
                cbTime.Items.Add(hora.ToString("HH:mm"));  // Agrega la hora en formato 24 horas
            }

            cbTime.SelectedIndex = 0;  // Selecciona la primera hora por defecto
        }

        private void plResumen_Paint(object sender, PaintEventArgs e)
        {
            lbBarber.Text = "NameBarber";
        }

        private void lbServices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FormServices f = new FormServices();
            f.Show();
            this.Hide();
        }
    }
}
