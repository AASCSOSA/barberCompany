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
            btnElimined = new Button();
            lbNameInfo = new Label();
            lbBarberInfo = new Label();
            lbDate = new Label();
            lbHour = new Label();
            lbId = new Label();
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
            label1.Text = "Hora y Fecha :";
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
            // btnElimined
            // 
            btnElimined.BackColor = Color.FromArgb(236, 140, 43);
            btnElimined.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnElimined.ForeColor = Color.White;
            btnElimined.Location = new Point(461, 131);
            btnElimined.Name = "btnElimined";
            btnElimined.Size = new Size(176, 51);
            btnElimined.TabIndex = 8;
            btnElimined.Text = "Cancelar";
            btnElimined.UseVisualStyleBackColor = false;
            btnElimined.Click += btnElimined_Click;
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
            lbDate.Location = new Point(293, 74);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(84, 31);
            lbDate.TabIndex = 9;
            lbDate.Text = "Fecha :";
            // 
            // lbHour
            // 
            lbHour.AutoSize = true;
            lbHour.Font = new Font("Segoe UI", 13.8F);
            lbHour.ForeColor = Color.White;
            lbHour.Location = new Point(207, 74);
            lbHour.Name = "lbHour";
            lbHour.Size = new Size(74, 31);
            lbHour.TabIndex = 13;
            lbHour.Text = "Hora :";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI", 13.8F);
            lbId.ForeColor = Color.White;
            lbId.Location = new Point(207, 26);
            lbId.Name = "lbId";
            lbId.Size = new Size(47, 31);
            lbId.TabIndex = 14;
            lbId.Text = "ID :";
            // 
            // UserControlReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 67, 13);
            Controls.Add(lbId);
            Controls.Add(lbHour);
            Controls.Add(lbNameInfo);
            Controls.Add(lbBarberInfo);
            Controls.Add(lbDate);
            Controls.Add(btnElimined);
            Controls.Add(lbName);
            Controls.Add(lbBarber);
            Controls.Add(label1);
            Controls.Add(lbServices);
            Name = "UserControlReservation";
            Size = new Size(671, 293);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbServices;
        private Label label1;
        private Label lbBarber;
        private Label lbName;
        private Button btnElimined;
        private Label lbNameInfo;
        private Label lbBarberInfo;
        private Label lbDate;
        private Label lbHour;
        private Label lbId;
    }
}
