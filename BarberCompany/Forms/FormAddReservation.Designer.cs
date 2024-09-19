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
            cbTime = new ComboBox();
            label4 = new Label();
            btnNewReservation = new Button();
            label9 = new Label();
            txtName = new TextBox();
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
            lbServices.LinkClicked += lbServices_LinkClicked;
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
            label1.Location = new Point(86, 236);
            label1.Name = "label1";
            label1.Size = new Size(346, 46);
            label1.TabIndex = 6;
            label1.Text = "Seleccionar Servicio ";
            // 
            // cbServices
            // 
            cbServices.FormattingEnabled = true;
            cbServices.Items.AddRange(new object[] { "Corte de cabello", "Corte de barba" });
            cbServices.Location = new Point(86, 309);
            cbServices.Name = "cbServices";
            cbServices.Size = new Size(863, 28);
            cbServices.TabIndex = 7;
            cbServices.Text = "Seleccion un servicio";
            // 
            // cbBarber
            // 
            cbBarber.FormattingEnabled = true;
            cbBarber.Location = new Point(86, 431);
            cbBarber.Name = "cbBarber";
            cbBarber.Size = new Size(863, 28);
            cbBarber.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 356);
            label2.Name = "label2";
            label2.Size = new Size(317, 46);
            label2.TabIndex = 8;
            label2.Text = "Seleccionar Barber";
            // 
            // cbDate
            // 
            cbDate.FormattingEnabled = true;
            cbDate.Location = new Point(86, 572);
            cbDate.Name = "cbDate";
            cbDate.Size = new Size(863, 28);
            cbDate.TabIndex = 11;
            cbDate.Text = "Selecciona un fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(86, 497);
            label3.Name = "label3";
            label3.Size = new Size(300, 46);
            label3.TabIndex = 10;
            label3.Text = "Seleccionar Fecha";
            // 
            // cbTime
            // 
            cbTime.FormattingEnabled = true;
            cbTime.Location = new Point(86, 718);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(863, 28);
            cbTime.TabIndex = 13;
            cbTime.Text = "Selecciona una hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(86, 642);
            label4.Name = "label4";
            label4.Size = new Size(282, 46);
            label4.TabIndex = 12;
            label4.Text = " Selecionar Hora";
            // 
            // btnNewReservation
            // 
            btnNewReservation.BackColor = Color.FromArgb(236, 140, 43);
            btnNewReservation.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNewReservation.ForeColor = Color.White;
            btnNewReservation.Location = new Point(1204, 392);
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(206, 51);
            btnNewReservation.TabIndex = 15;
            btnNewReservation.Text = "Confirmar cita";
            btnNewReservation.UseVisualStyleBackColor = false;
            btnNewReservation.Click += btnNewReservation_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(86, 108);
            label9.Name = "label9";
            label9.Size = new Size(318, 46);
            label9.TabIndex = 16;
            label9.Text = "Ingrese su nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(86, 175);
            txtName.Name = "txtName";
            txtName.Size = new Size(863, 27);
            txtName.TabIndex = 17;
            // 
            // FormAddReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(1924, 1033);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(btnNewReservation);
            Controls.Add(cbTime);
            Controls.Add(label4);
            Controls.Add(cbDate);
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
        private ComboBox cbTime;
        private Label label4;
        private Button btnNewReservation;
        private Label label9;
        private TextBox txtName;
    }
}