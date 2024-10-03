namespace BarberCompany.UserControls
{
    partial class UserControlReservation
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
            lbServices = new Label();
            label1 = new Label();
            lbBarber = new Label();
            lbName = new Label();
            label2 = new Label();
            btnElimined = new Button();
            lbTelephoneInfo = new Label();
            lbNameInfo = new Label();
            lbBarberInfo = new Label();
            lbDate = new Label();
            lbId = new Label();
            lbHour = new Label();
            SuspendLayout();
            // 
            // lbServices
            // 
            lbServices.AutoSize = true;
            lbServices.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbServices.ForeColor = Color.White;
            lbServices.Location = new Point(56, 15);
            lbServices.Name = "lbServices";
            lbServices.Size = new Size(145, 46);
            lbServices.TabIndex = 0;
            lbServices.Text = "Cita No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 74);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 1;
            label1.Text = "Fecha y Hora :";
            // 
            // lbBarber
            // 
            lbBarber.AutoSize = true;
            lbBarber.Font = new Font("Segoe UI", 13.8F);
            lbBarber.ForeColor = Color.White;
            lbBarber.Location = new Point(56, 131);
            lbBarber.Name = "lbBarber";
            lbBarber.Size = new Size(105, 31);
            lbBarber.TabIndex = 2;
            lbBarber.Text = "Barbero :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 13.8F);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(56, 185);
            lbName.Name = "lbName";
            lbName.Size = new Size(109, 31);
            lbName.TabIndex = 3;
            lbName.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 243);
            label2.Name = "label2";
            label2.Size = new Size(111, 31);
            label2.TabIndex = 4;
            label2.Text = "Telefono :";
            // 
            // btnElimined
            // 
            btnElimined.BackColor = Color.FromArgb(236, 140, 43);
            btnElimined.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnElimined.ForeColor = Color.White;
            btnElimined.Location = new Point(518, 121);
            btnElimined.Name = "btnElimined";
            btnElimined.Size = new Size(176, 51);
            btnElimined.TabIndex = 8;
            btnElimined.Text = "Cancelar";
            btnElimined.UseVisualStyleBackColor = false;
            btnElimined.Click += btnElimined_Click;
            // 
            // lbTelephoneInfo
            // 
            lbTelephoneInfo.AutoSize = true;
            lbTelephoneInfo.Font = new Font("Segoe UI", 13.8F);
            lbTelephoneInfo.ForeColor = Color.White;
            lbTelephoneInfo.Location = new Point(192, 243);
            lbTelephoneInfo.Name = "lbTelephoneInfo";
            lbTelephoneInfo.Size = new Size(111, 31);
            lbTelephoneInfo.TabIndex = 12;
            lbTelephoneInfo.Text = "Telefono :";
            // 
            // lbNameInfo
            // 
            lbNameInfo.AutoSize = true;
            lbNameInfo.Font = new Font("Segoe UI", 13.8F);
            lbNameInfo.ForeColor = Color.White;
            lbNameInfo.Location = new Point(192, 185);
            lbNameInfo.Name = "lbNameInfo";
            lbNameInfo.Size = new Size(109, 31);
            lbNameInfo.TabIndex = 11;
            lbNameInfo.Text = "Nombre :";
            // 
            // lbBarberInfo
            // 
            lbBarberInfo.AutoSize = true;
            lbBarberInfo.Font = new Font("Segoe UI", 13.8F);
            lbBarberInfo.ForeColor = Color.White;
            lbBarberInfo.Location = new Point(192, 131);
            lbBarberInfo.Name = "lbBarberInfo";
            lbBarberInfo.Size = new Size(105, 31);
            lbBarberInfo.TabIndex = 10;
            lbBarberInfo.Text = "Barbero :";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 13.8F);
            lbDate.ForeColor = Color.White;
            lbDate.Location = new Point(337, 74);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(84, 31);
            lbDate.TabIndex = 9;
            lbDate.Text = "Fecha :";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI", 13.8F);
            lbId.ForeColor = Color.White;
            lbId.Location = new Point(192, 26);
            lbId.Name = "lbId";
            lbId.Size = new Size(34, 31);
            lbId.TabIndex = 13;
            lbId.Text = "Id";
            // 
            // lbHour
            // 
            lbHour.AutoSize = true;
            lbHour.Font = new Font("Segoe UI", 13.8F);
            lbHour.ForeColor = Color.White;
            lbHour.Location = new Point(219, 74);
            lbHour.Name = "lbHour";
            lbHour.Size = new Size(84, 31);
            lbHour.TabIndex = 14;
            lbHour.Text = "Fecha :";
            // 
            // UserControlReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 67, 13);
            Controls.Add(lbHour);
            Controls.Add(lbId);
            Controls.Add(lbTelephoneInfo);
            Controls.Add(lbNameInfo);
            Controls.Add(lbBarberInfo);
            Controls.Add(lbDate);
            Controls.Add(btnElimined);
            Controls.Add(label2);
            Controls.Add(lbName);
            Controls.Add(lbBarber);
            Controls.Add(label1);
            Controls.Add(lbServices);
            Name = "UserControlReservation";
            Size = new Size(708, 293);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbServices;
        private Label label1;
        private Label lbBarber;
        private Label lbName;
        private Label label2;
        private Button btnElimined;
        private Label lbTelephoneInfo;
        private Label lbNameInfo;
        private Label lbBarberInfo;
        private Label lbDate;
        private Label lbId;
        private Label lbHour;
    }
}
