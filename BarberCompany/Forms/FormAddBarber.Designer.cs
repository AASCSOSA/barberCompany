namespace BarberCompany.Forms
{
    partial class FormAddBarber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBarber));
            btnAddBarber = new Button();
            txtFatherLastName = new TextBox();
            txtContactNumber = new TextBox();
            txtAvailabilityBarber = new TextBox();
            txtMotherLastName = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lbTelephoneNumber = new Label();
            lbAvilabilityBarber = new Label();
            pictureBox1 = new PictureBox();
            lbNameBarber = new Label();
            btnCanceled = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddBarber
            // 
            btnAddBarber.Location = new Point(681, 84);
            btnAddBarber.Name = "btnAddBarber";
            btnAddBarber.Size = new Size(94, 29);
            btnAddBarber.TabIndex = 27;
            btnAddBarber.Text = "Agregar";
            btnAddBarber.UseVisualStyleBackColor = true;
            btnAddBarber.Click += btnAddBarber_Click;
            // 
            // txtFatherLastName
            // 
            txtFatherLastName.Location = new Point(378, 86);
            txtFatherLastName.Name = "txtFatherLastName";
            txtFatherLastName.Size = new Size(269, 27);
            txtFatherLastName.TabIndex = 26;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(378, 232);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(269, 27);
            txtContactNumber.TabIndex = 25;
            // 
            // txtAvailabilityBarber
            // 
            txtAvailabilityBarber.Location = new Point(378, 185);
            txtAvailabilityBarber.Name = "txtAvailabilityBarber";
            txtAvailabilityBarber.Size = new Size(269, 27);
            txtAvailabilityBarber.TabIndex = 24;
            // 
            // txtMotherLastName
            // 
            txtMotherLastName.Location = new Point(378, 136);
            txtMotherLastName.Name = "txtMotherLastName";
            txtMotherLastName.Size = new Size(269, 27);
            txtMotherLastName.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Location = new Point(378, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 27);
            txtName.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 185);
            label2.Name = "label2";
            label2.Size = new Size(165, 31);
            label2.TabIndex = 21;
            label2.Text = "Disponibilidad :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 80);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 20;
            label1.Text = "Apellido Paterno :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTelephoneNumber
            // 
            lbTelephoneNumber.AutoSize = true;
            lbTelephoneNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTelephoneNumber.Location = new Point(263, 232);
            lbTelephoneNumber.Name = "lbTelephoneNumber";
            lbTelephoneNumber.Size = new Size(109, 31);
            lbTelephoneNumber.TabIndex = 19;
            lbTelephoneNumber.Text = "Telefono :";
            lbTelephoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbAvilabilityBarber
            // 
            lbAvilabilityBarber.AutoSize = true;
            lbAvilabilityBarber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbAvilabilityBarber.Location = new Point(179, 130);
            lbAvilabilityBarber.Name = "lbAvilabilityBarber";
            lbAvilabilityBarber.Size = new Size(193, 31);
            lbAvilabilityBarber.TabIndex = 18;
            lbAvilabilityBarber.Text = "Apellido Materno :";
            lbAvilabilityBarber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lbNameBarber
            // 
            lbNameBarber.AutoSize = true;
            lbNameBarber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbNameBarber.Location = new Point(267, 35);
            lbNameBarber.Name = "lbNameBarber";
            lbNameBarber.Size = new Size(105, 31);
            lbNameBarber.TabIndex = 16;
            lbNameBarber.Text = "Nombre :";
            lbNameBarber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCanceled
            // 
            btnCanceled.Location = new Point(681, 153);
            btnCanceled.Name = "btnCanceled";
            btnCanceled.Size = new Size(94, 29);
            btnCanceled.TabIndex = 28;
            btnCanceled.Text = "Cancelar";
            btnCanceled.UseVisualStyleBackColor = true;
            btnCanceled.Click += btnCanceled_Click;
            // 
            // FormAddBarber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 298);
            Controls.Add(btnCanceled);
            Controls.Add(btnAddBarber);
            Controls.Add(txtFatherLastName);
            Controls.Add(txtContactNumber);
            Controls.Add(txtAvailabilityBarber);
            Controls.Add(txtMotherLastName);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbTelephoneNumber);
            Controls.Add(lbAvilabilityBarber);
            Controls.Add(pictureBox1);
            Controls.Add(lbNameBarber);
            Name = "FormAddBarber";
            Text = "FormAddBarber";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBarber;
        private TextBox txtFatherLastName;
        private TextBox txtContactNumber;
        private TextBox txtAvailabilityBarber;
        private TextBox txtMotherLastName;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Label lbTelephoneNumber;
        private Label lbAvilabilityBarber;
        private PictureBox pictureBox1;
        private Label lbNameBarber;
        private Button btnCanceled;
    }
}