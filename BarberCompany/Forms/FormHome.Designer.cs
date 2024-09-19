namespace BarberCompany.Forms
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            pbIcon = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbBarber = new LinkLabel();
            lbCities = new LinkLabel();
            lbServices = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            btnCities = new Button();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbIcon
            // 
            pbIcon.Image = (Image)resources.GetObject("pbIcon.Image");
            pbIcon.Location = new Point(780, 218);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(323, 303);
            pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIcon.TabIndex = 1;
            pbIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 140, 43);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbBarber);
            panel1.Controls.Add(lbCities);
            panel1.Controls.Add(lbServices);
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 86);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(362, 575);
            label1.Name = "label1";
            label1.Size = new Size(1226, 106);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido a El Mapache Bigotón";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(424, 696);
            label2.Name = "label2";
            label2.Size = new Size(1140, 41);
            label2.TabIndex = 5;
            label2.Text = "Disfruta de un ambiente acogedor y un servicio de primera clase en nuestra barbería.";
            // 
            // btnCities
            // 
            btnCities.BackColor = Color.FromArgb(236, 140, 43);
            btnCities.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCities.ForeColor = Color.White;
            btnCities.Location = new Point(870, 805);
            btnCities.Name = "btnCities";
            btnCities.Size = new Size(233, 69);
            btnCities.TabIndex = 6;
            btnCities.Text = "Agendar Cita";
            btnCities.UseVisualStyleBackColor = false;
            btnCities.Click += btnCities_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnCities);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pbIcon);
            Name = "FormHome";
            Text = "FormHome";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbIcon;
        private Panel panel1;
        private LinkLabel lbServices;
        private LinkLabel lbBarber;
        private LinkLabel lbCities;
        private Label label1;
        private Label label2;
        private Button btnCities;
        private PictureBox pictureBox1;
    }
}