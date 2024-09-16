namespace BarberCompany
{
    partial class UserControlBarber
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBarber));
            lbNameBarber = new Label();
            pictureBox1 = new PictureBox();
            lbAvilabilityBarber = new Label();
            lbTelephoneNumber = new Label();
            lbFatherName = new Label();
            lbMother = new Label();
            lbId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbNameBarber
            // 
            lbNameBarber.AutoSize = true;
            lbNameBarber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbNameBarber.Location = new Point(19, 182);
            lbNameBarber.Name = "lbNameBarber";
            lbNameBarber.Size = new Size(105, 31);
            lbNameBarber.TabIndex = 0;
            lbNameBarber.Text = "Nombre :";
            lbNameBarber.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbAvilabilityBarber
            // 
            lbAvilabilityBarber.AutoSize = true;
            lbAvilabilityBarber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbAvilabilityBarber.Location = new Point(47, 237);
            lbAvilabilityBarber.Name = "lbAvilabilityBarber";
            lbAvilabilityBarber.Size = new Size(165, 31);
            lbAvilabilityBarber.TabIndex = 2;
            lbAvilabilityBarber.Text = "Disponibilidad :";
            lbAvilabilityBarber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTelephoneNumber
            // 
            lbTelephoneNumber.AutoSize = true;
            lbTelephoneNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTelephoneNumber.Location = new Point(61, 289);
            lbTelephoneNumber.Name = "lbTelephoneNumber";
            lbTelephoneNumber.Size = new Size(109, 31);
            lbTelephoneNumber.TabIndex = 3;
            lbTelephoneNumber.Text = "Telefono :";
            lbTelephoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbFatherName
            // 
            lbFatherName.AutoSize = true;
            lbFatherName.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbFatherName.Location = new Point(130, 182);
            lbFatherName.Name = "lbFatherName";
            lbFatherName.Size = new Size(94, 31);
            lbFatherName.TabIndex = 4;
            lbFatherName.Text = "Apellido";
            lbFatherName.TextAlign = ContentAlignment.TopCenter;
            lbFatherName.Visible = false;
            // 
            // lbMother
            // 
            lbMother.AutoSize = true;
            lbMother.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbMother.Location = new Point(76, 320);
            lbMother.Name = "lbMother";
            lbMother.Size = new Size(94, 31);
            lbMother.TabIndex = 5;
            lbMother.Text = "Apellido";
            lbMother.TextAlign = ContentAlignment.MiddleCenter;
            lbMother.Visible = false;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbId.Location = new Point(3, 83);
            lbId.Name = "lbId";
            lbId.Size = new Size(32, 31);
            lbId.TabIndex = 6;
            lbId.Text = "Id";
            lbId.TextAlign = ContentAlignment.MiddleCenter;
            lbId.Visible = false;
            // 
            // UserControlBarber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            Controls.Add(lbId);
            Controls.Add(lbMother);
            Controls.Add(lbFatherName);
            Controls.Add(lbTelephoneNumber);
            Controls.Add(lbAvilabilityBarber);
            Controls.Add(pictureBox1);
            Controls.Add(lbNameBarber);
            Name = "UserControlBarber";
            Size = new Size(258, 345);
            Click += UserControlBarber_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        public Label lbNameBarber;
        public Label lbAvilabilityBarber;
        public Label lbTelephoneNumber;
        public Label lbFatherName;
        public Label lbMother;
        public Label lbId;
    }
}
