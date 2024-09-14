using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BarberiaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(29, 27, 27);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            //this.ClientSize= new Size((Point)ClientSize);
            // Top menu
            Panel topMenu = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.FromArgb(255, 140, 0)
            };
            this.Controls.Add(topMenu);

            // Crear FlowLayoutPanel para el menú
            FlowLayoutPanel menuFlow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = false,
                Padding = new Padding(10, 10, 0, 10)
            };
            topMenu.Controls.Add(menuFlow);

            // Declarar el array de elementos del menú
            string[] menuItems = { "Inicio", "Servicios", "Citas", "Contacto" };

            // Crear un Panel contenedor para ocupar el espacio restante
            Panel spacerPanel = new Panel
            {
                Width = menuFlow.ClientSize.Width - (menuItems.Length * 130), // Ajusta el ancho según el número de botones y su tamaño
                Height = 1 // Altura mínima para que el panel sea visible
            };
            menuFlow.Controls.Add(spacerPanel);

            // Agregar botones al FlowLayoutPanel
            foreach (var menuItem in menuItems)
            {
                Button menuButton = new Button
                {
                    Text = menuItem,
                    Size = new Size(120, 30), // Mantenemos tamaño 
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(255, 140, 0),
                    FlatAppearance = { BorderSize = 0 },
                    Font = new Font("Arial", 14, FontStyle.Italic)
                };
                menuFlow.Controls.Add(menuButton);
            }


            // Services title
            Label servicesTitle = new Label
            {
                Text = "Servicios",
                Font = new Font("Arial", 36, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(40, 90),
                AutoSize = true
            };
            this.Controls.Add(servicesTitle);

            // Add Services button
            Button addServicesButton = new Button
            {
                Text = "Agregar Servicios",
                Location = new Point(this.ClientSize.Width - 250, 85),
                Size = new Size(240, 55),
                BackColor = Color.FromArgb(255, 140, 0),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Arial", 16, FontStyle.Bold)
            };
            this.Controls.Add(addServicesButton);

            // Creación de las tarjetas de servicio con ajustes de tamaño y espaciado
            CreateServiceCard("Corte clasico....................................$120\n\nCorte moderno.................................$150\n\nCorte infantil....................................$100", @"C:\Users\moham\source\repos\BarberiaApp\BarberiaApp\imagenes\cabello.png");
            CreateServiceCard("Afeitado clasico...................................$65\n\nAfeitado con navaja.............................$80\n\nAfeitado y masaje facial.....................$100", @"C:\Users\moham\source\repos\BarberiaApp\BarberiaApp\imagenes\barba.png");
            CreateServiceCard("Corte y afeitado a la clasica...............$185\n\nSpa masculino..................................$160", @"C:\Users\moham\source\repos\BarberiaApp\BarberiaApp\imagenes\completo.png");

            AdjustServiceCardLayout(); // Llamar al método para ajustar el layout al inicio
        }

        private void CreateServiceCard(string service, string imagePath)
        {
            Panel card = new Panel
            {
                BackColor = ColorTranslator.FromHtml("#975009"), // Cambiar el color de la tarjeta
                Tag = "serviceCard"
            };

            PictureBox iconBox = new PictureBox
            {
                Size = new Size(270, 270), // Aumentar el tamaño de la imagen
                SizeMode = PictureBoxSizeMode.StretchImage // Ajustar la imagen al tamaño del PictureBox
            };

            // Verificar si el archivo existe antes de cargarlo
            if (File.Exists(imagePath))
            {
                iconBox.Image = Image.FromFile(imagePath); // Cargar la imagen PNG específica
            }
            else
            {
                MessageBox.Show($"No se encontró la imagen: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            card.Controls.Add(iconBox);

            Label serviceLabel = new Label
            {
                Text = service,
                ForeColor = Color.White,
                Font = new Font("Arial", 22),
                AutoSize = true
            };
            card.Controls.Add(serviceLabel);

            this.Controls.Add(card);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustServiceCardLayout();
        }

        private void AdjustServiceCardLayout()
        {
            int margin = 50; // Margen entre las tarjetas
            int cardWidth = (this.ClientSize.Width - (4 * margin)) / 3; // Ajustar el ancho para que quepan 3 tarjetas con más espacio entre ellas
            int cardHeight = 760; // Ajustar la altura de las tarjetas
            int topMargin = 200; // Margen superior para bajar las tarjetas

            int index = 0;
            foreach (Control control in this.Controls)
            {
                if (control is Panel card && card.Tag != null && card.Tag.ToString() == "serviceCard")
                {
                    card.Size = new Size(cardWidth, cardHeight);
                    card.Location = new Point(margin + index * (cardWidth + margin), topMargin);

                    // Ajustar la posición de los controles dentro de la tarjeta
                    foreach (Control child in card.Controls)
                    {
                        if (child is PictureBox iconBox)
                        {
                            iconBox.Location = new Point((card.Width - iconBox.Width) / 2, 20);
                        }
                        else if (child is Label serviceLabel)
                        {
                            serviceLabel.Location = new Point(10, 330); // Ajustar la posición para dejar espacio para la imagen más grande
                        }
                    }

                    index++;
                }
            }
        }
    }
}