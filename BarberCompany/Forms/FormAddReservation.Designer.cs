namespace BarberCompany.Forms
{
    partial class FormAddReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddReservation));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbBarber = new LinkLabel();
            lbCities = new LinkLabel();
            lbServices = new LinkLabel();
            labelHome = new LinkLabel();
            label1 = new Label();
            cbServices = new ComboBox();
            cbBarber = new ComboBox();
            label2 = new Label();
            cbDate = new ComboBox();
            label3 = new Label();
            cbHour = new ComboBox();
            label4 = new Label();
            btnNewReservation = new Button();
            label5 = new Label();
            txtUser = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 140, 43);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbBarber);
            panel1.Controls.Add(lbCities);
            panel1.Controls.Add(lbServices);
            panel1.Controls.Add(labelHome);
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(1, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1684, 73);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lbBarber
            // 
            lbBarber.ActiveLinkColor = Color.Gainsboro;
            lbBarber.AutoSize = true;
            lbBarber.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBarber.LinkColor = Color.White;
            lbBarber.Location = new Point(1512, 20);
            lbBarber.Name = "lbBarber";
            lbBarber.Size = new Size(100, 30);
            lbBarber.TabIndex = 5;
            lbBarber.TabStop = true;
            lbBarber.Text = "Barberos";
            lbBarber.LinkClicked += lbBarber_LinkClicked;
            // 
            // lbCities
            // 
            lbCities.AutoSize = true;
            lbCities.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCities.LinkColor = Color.White;
            lbCities.Location = new Point(1418, 20);
            lbCities.Name = "lbCities";
            lbCities.Size = new Size(61, 30);
            lbCities.TabIndex = 4;
            lbCities.TabStop = true;
            lbCities.Text = "Citas";
            lbCities.LinkClicked += lbCities_LinkClicked;
            // 
            // lbServices
            // 
            lbServices.ActiveLinkColor = Color.Gainsboro;
            lbServices.AutoSize = true;
            lbServices.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbServices.LinkColor = Color.White;
            lbServices.Location = new Point(1285, 20);
            lbServices.Name = "lbServices";
            lbServices.Size = new Size(100, 30);
            lbServices.TabIndex = 3;
            lbServices.TabStop = true;
            lbServices.Text = "Servicios";
            lbServices.LinkClicked += lbServices_LinkClicked;
            // 
            // labelHome
            // 
            labelHome.ActiveLinkColor = Color.Gainsboro;
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.LinkColor = Color.White;
            labelHome.Location = new Point(1186, 20);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(67, 30);
            labelHome.TabIndex = 2;
            labelHome.TabStop = true;
            labelHome.Text = "Inicio";
            labelHome.LinkClicked += labelHome_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 192);
            label1.Name = "label1";
            label1.Size = new Size(280, 37);
            label1.TabIndex = 6;
            label1.Text = "Seleccionar Servicio ";
            // 
            // cbServices
            // 
            cbServices.FormattingEnabled = true;
            cbServices.Location = new Point(55, 247);
            cbServices.Margin = new Padding(3, 2, 3, 2);
            cbServices.Name = "cbServices";
            cbServices.Size = new Size(756, 23);
            cbServices.TabIndex = 7;
            cbServices.Text = "Seleccion un servicio";
            // 
            // cbBarber
            // 
            cbBarber.FormattingEnabled = true;
            cbBarber.Location = new Point(55, 338);
            cbBarber.Margin = new Padding(3, 2, 3, 2);
            cbBarber.Name = "cbBarber";
            cbBarber.Size = new Size(756, 23);
            cbBarber.TabIndex = 9;
            cbBarber.Text = "Selecciona un barbero";
            cbBarber.SelectedIndexChanged += cbBarber_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 282);
            label2.Name = "label2";
            label2.Size = new Size(256, 37);
            label2.TabIndex = 8;
            label2.Text = "Seleccionar Barber";
            // 
            // cbDate
            // 
            cbDate.FormattingEnabled = true;
            cbDate.Location = new Point(55, 444);
            cbDate.Margin = new Padding(3, 2, 3, 2);
            cbDate.Name = "cbDate";
            cbDate.Size = new Size(756, 23);
            cbDate.TabIndex = 11;
            cbDate.Text = "Selecciona un fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 388);
            label3.Name = "label3";
            label3.Size = new Size(243, 37);
            label3.TabIndex = 10;
            label3.Text = "Seleccionar Fecha";
            // 
            // cbHour
            // 
            cbHour.FormattingEnabled = true;
            cbHour.Location = new Point(55, 554);
            cbHour.Margin = new Padding(3, 2, 3, 2);
            cbHour.Name = "cbHour";
            cbHour.Size = new Size(756, 23);
            cbHour.TabIndex = 13;
            cbHour.Text = "Selecciona una hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(55, 496);
            label4.Name = "label4";
            label4.Size = new Size(228, 37);
            label4.TabIndex = 12;
            label4.Text = " Selecionar Hora";
            // 
            // btnNewReservation
            // 
            btnNewReservation.BackColor = Color.FromArgb(236, 140, 43);
            btnNewReservation.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNewReservation.ForeColor = Color.White;
            btnNewReservation.Location = new Point(968, 398);
            btnNewReservation.Margin = new Padding(3, 2, 3, 2);
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(180, 38);
            btnNewReservation.TabIndex = 15;
            btnNewReservation.Text = "Confirmar cita";
            btnNewReservation.UseVisualStyleBackColor = false;
            btnNewReservation.Click += btnNewReservation_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(55, 85);
            label5.Name = "label5";
            label5.Size = new Size(255, 37);
            label5.TabIndex = 16;
            label5.Text = "Ingrese su nombre";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(55, 136);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(756, 23);
            txtUser.TabIndex = 18;
            // 
            // FormAddReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(1684, 775);
            Controls.Add(txtUser);
            Controls.Add(label5);
            Controls.Add(btnNewReservation);
            Controls.Add(cbHour);
            Controls.Add(label4);
            Controls.Add(cbDate);
            Controls.Add(label3);
            Controls.Add(cbBarber);
            Controls.Add(label2);
            Controls.Add(cbServices);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddReservation";
            Text = "FormAddReservation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private LinkLabel lbBarber;
        private LinkLabel lbCities;
        private LinkLabel lbServices;
        private LinkLabel labelHome;
        private Label label1;
        private ComboBox cbServices;
        private ComboBox cbBarber;
        private Label label2;
        private ComboBox cbDate;
        private Label label3;
        private ComboBox cbHour;
        private Label label4;
        private Button btnNewReservation;
        private Label label5;
        private TextBox txtUser;
    }
}