namespace BarberCompany.Forms
{
    partial class FormUpdateBarber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateBarber));
            btnElimined = new Button();
            btnUpdateBarber = new Button();
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
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnElimined
            // 
            btnElimined.Location = new Point(682, 150);
            btnElimined.Name = "btnElimined";
            btnElimined.Size = new Size(94, 29);
            btnElimined.TabIndex = 41;
            btnElimined.Text = "Eliminar";
            btnElimined.UseVisualStyleBackColor = true;
            btnElimined.Click += btnElimined_Click;
            // 
            // btnUpdateBarber
            // 
            btnUpdateBarber.Location = new Point(682, 81);
            btnUpdateBarber.Name = "btnUpdateBarber";
            btnUpdateBarber.Size = new Size(94, 29);
            btnUpdateBarber.TabIndex = 40;
            btnUpdateBarber.Text = "Actualizar";
            btnUpdateBarber.UseVisualStyleBackColor = true;
            btnUpdateBarber.Click += btnUpdateBarber_Click;
            // 
            // txtFatherLastName
            // 
            txtFatherLastName.Enabled = false;
            txtFatherLastName.Location = new Point(379, 83);
            txtFatherLastName.Name = "txtFatherLastName";
            txtFatherLastName.Size = new Size(269, 27);
            txtFatherLastName.TabIndex = 39;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(379, 229);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(269, 27);
            txtContactNumber.TabIndex = 38;
            // 
            // txtAvailabilityBarber
            // 
            txtAvailabilityBarber.Location = new Point(379, 182);
            txtAvailabilityBarber.Name = "txtAvailabilityBarber";
            txtAvailabilityBarber.Size = new Size(269, 27);
            txtAvailabilityBarber.TabIndex = 37;
            // 
            // txtMotherLastName
            // 
            txtMotherLastName.Enabled = false;
            txtMotherLastName.Location = new Point(379, 133);
            txtMotherLastName.Name = "txtMotherLastName";
            txtMotherLastName.Size = new Size(269, 27);
            txtMotherLastName.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(379, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 27);
            txtName.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 182);
            label2.Name = "label2";
            label2.Size = new Size(165, 31);
            label2.TabIndex = 34;
            label2.Text = "Disponibilidad :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 77);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 33;
            label1.Text = "Apellido Paterno :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTelephoneNumber
            // 
            lbTelephoneNumber.AutoSize = true;
            lbTelephoneNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTelephoneNumber.Location = new Point(264, 229);
            lbTelephoneNumber.Name = "lbTelephoneNumber";
            lbTelephoneNumber.Size = new Size(109, 31);
            lbTelephoneNumber.TabIndex = 32;
            lbTelephoneNumber.Text = "Telefono :";
            lbTelephoneNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbAvilabilityBarber
            // 
            lbAvilabilityBarber.AutoSize = true;
            lbAvilabilityBarber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbAvilabilityBarber.Location = new Point(180, 127);
            lbAvilabilityBarber.Name = "lbAvilabilityBarber";
            lbAvilabilityBarber.Size = new Size(193, 31);
            lbAvilabilityBarber.TabIndex = 31;
            lbAvilabilityBarber.Text = "Apellido Materno :";
            lbAvilabilityBarber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // lbNameBarber
            // 
            lbNameBarber.AutoSize = true;
            lbNameBarber.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbNameBarber.Location = new Point(268, 32);
            lbNameBarber.Name = "lbNameBarber";
            lbNameBarber.Size = new Size(105, 31);
            lbNameBarber.TabIndex = 29;
            lbNameBarber.Text = "Nombre :";
            lbNameBarber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(379, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(269, 27);
            txtId.TabIndex = 42;
            // 
            // FormUpdateBarber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 309);
            Controls.Add(txtId);
            Controls.Add(btnElimined);
            Controls.Add(btnUpdateBarber);
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
            Name = "FormUpdateBarber";
            Text = "FormUpdateBarber";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnElimined;
        private Button btnUpdateBarber;
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
        private TextBox txtId;
    }
}