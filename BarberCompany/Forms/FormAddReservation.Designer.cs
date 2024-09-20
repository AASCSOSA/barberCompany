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
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            plResumen = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbResumen = new Label();
            btnNewReservation = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            plResumen.SuspendLayout();
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
            panel1.Location = new Point(1, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 97);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 54);
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
            lbBarber.Location = new Point(1728, 27);
            lbBarber.Name = "lbBarber";
            lbBarber.Size = new Size(130, 38);
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
            lbCities.Location = new Point(1621, 27);
            lbCities.Name = "lbCities";
            lbCities.Size = new Size(78, 38);
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
            lbServices.Location = new Point(1469, 27);
            lbServices.Name = "lbServices";
            lbServices.Size = new Size(127, 38);
            lbServices.TabIndex = 3;
            lbServices.TabStop = true;
            lbServices.Text = "Servicios";
            // 
            // labelHome
            // 
            labelHome.ActiveLinkColor = Color.Gainsboro;
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.LinkColor = Color.White;
            labelHome.Location = new Point(1355, 27);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(85, 38);
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
            label1.Location = new Point(72, 124);
            label1.Name = "label1";
            label1.Size = new Size(346, 46);
            label1.TabIndex = 6;
            label1.Text = "Seleccionar Servicio ";
            // 
            // cbServices
            // 
            cbServices.FormattingEnabled = true;
            cbServices.Location = new Point(72, 197);
            cbServices.Name = "cbServices";
            cbServices.Size = new Size(863, 28);
            cbServices.TabIndex = 7;
            cbServices.Text = "Seleccion un servicio";
            // 
            // cbBarber
            // 
            cbBarber.FormattingEnabled = true;
            cbBarber.Location = new Point(72, 319);
            cbBarber.Name = "cbBarber";
            cbBarber.Size = new Size(863, 28);
            cbBarber.TabIndex = 9;
            cbBarber.Text = "Selecciona un barbero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(72, 244);
            label2.Name = "label2";
            label2.Size = new Size(317, 46);
            label2.TabIndex = 8;
            label2.Text = "Seleccionar Barber";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(72, 460);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(863, 28);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Selecciona un fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 385);
            label3.Name = "label3";
            label3.Size = new Size(300, 46);
            label3.TabIndex = 10;
            label3.Text = "Seleccionar Fecha";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(72, 606);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(863, 28);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "Selecciona una hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 530);
            label4.Name = "label4";
            label4.Size = new Size(282, 46);
            label4.TabIndex = 12;
            label4.Text = " Selecionar Hora";
            // 
            // plResumen
            // 
            plResumen.BackColor = Color.FromArgb(121, 67, 13);
            plResumen.Controls.Add(label8);
            plResumen.Controls.Add(label7);
            plResumen.Controls.Add(label6);
            plResumen.Controls.Add(label5);
            plResumen.Controls.Add(lbResumen);
            plResumen.Location = new Point(72, 670);
            plResumen.Name = "plResumen";
            plResumen.Size = new Size(1589, 292);
            plResumen.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(50, 247);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 19;
            label8.Text = "Hora : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(50, 201);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 18;
            label7.Text = "Fecha :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 141);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 17;
            label6.Text = "Barbero :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 80);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 16;
            label5.Text = "Servicio :";
            // 
            // lbResumen
            // 
            lbResumen.AutoSize = true;
            lbResumen.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResumen.ForeColor = Color.White;
            lbResumen.Location = new Point(29, 16);
            lbResumen.Name = "lbResumen";
            lbResumen.Size = new Size(344, 46);
            lbResumen.TabIndex = 15;
            lbResumen.Text = "Resumen de Reserva";
            // 
            // btnNewReservation
            // 
            btnNewReservation.BackColor = Color.FromArgb(236, 140, 43);
            btnNewReservation.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNewReservation.ForeColor = Color.White;
            btnNewReservation.Location = new Point(848, 970);
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(206, 51);
            btnNewReservation.TabIndex = 15;
            btnNewReservation.Text = "Confirmar cita";
            btnNewReservation.UseVisualStyleBackColor = false;
            // 
            // FormAddReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(1924, 1033);
            Controls.Add(btnNewReservation);
            Controls.Add(plResumen);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(cbBarber);
            Controls.Add(label2);
            Controls.Add(cbServices);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormAddReservation";
            Text = "FormAddReservation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            plResumen.ResumeLayout(false);
            plResumen.PerformLayout();
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
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Panel plResumen;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lbResumen;
        private Button btnNewReservation;
    }
}