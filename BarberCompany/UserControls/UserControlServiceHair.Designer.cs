namespace BarberCompany.UserControls
{
    partial class UserControlServiceHair
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cabello = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbNameService = new Label();
            lbDescriptionService = new Label();
            lbCostService = new Label();
            ((System.ComponentModel.ISupportInitialize)Cabello).BeginInit();
            SuspendLayout();
            // 
            // Cabello
            // 
            Cabello.Location = new Point(97, 10);
            Cabello.Name = "Cabello";
            Cabello.Size = new Size(228, 241);
            Cabello.SizeMode = PictureBoxSizeMode.StretchImage;
            Cabello.TabIndex = 0;
            Cabello.TabStop = false;
            // 
            // label1
            // 
            label1.AccessibleDescription = "lbNameService";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 283);
            label1.Name = "label1";
            label1.Size = new Size(113, 35);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AccessibleDescription = "lbServiceDescription";
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 371);
            label2.Name = "label2";
            label2.Size = new Size(151, 35);
            label2.TabIndex = 2;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AccessibleDescription = "lbServiceCost";
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(91, 447);
            label3.Name = "label3";
            label3.Size = new Size(84, 35);
            label3.TabIndex = 3;
            label3.Text = "Costo:";
            // 
            // lbNameService
            // 
            lbNameService.AccessibleDescription = "lbNombreServicio";
            lbNameService.AutoSize = true;
            lbNameService.Font = new Font("Segoe UI", 15F);
            lbNameService.ForeColor = Color.White;
            lbNameService.Location = new Point(200, 283);
            lbNameService.Name = "lbNameService";
            lbNameService.Size = new Size(189, 35);
            lbNameService.TabIndex = 4;
            lbNameService.Text = "nombreServicio";
            // 
            // lbDescriptionService
            // 
            lbDescriptionService.AccessibleDescription = "lbServiceDescripcionNombre";
            lbDescriptionService.AutoSize = true;
            lbDescriptionService.Font = new Font("Segoe UI", 15F);
            lbDescriptionService.ForeColor = Color.White;
            lbDescriptionService.Location = new Point(184, 371);
            lbDescriptionService.Name = "lbDescriptionService";
            lbDescriptionService.Size = new Size(239, 35);
            lbDescriptionService.TabIndex = 5;
            lbDescriptionService.Text = "DescripciónNombre";
            // 
            // lbCostService
            // 
            lbCostService.AccessibleDescription = "lbServiceCostCosto";
            lbCostService.AutoSize = true;
            lbCostService.Font = new Font("Segoe UI", 15F);
            lbCostService.ForeColor = Color.White;
            lbCostService.Location = new Point(200, 447);
            lbCostService.Name = "lbCostService";
            lbCostService.Size = new Size(143, 35);
            lbCostService.TabIndex = 6;
            lbCostService.Text = "CostoCosto";
            // 
            // UserControlServiceHair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 67, 13);
            Controls.Add(lbCostService);
            Controls.Add(lbDescriptionService);
            Controls.Add(lbNameService);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cabello);
            Name = "UserControlServiceHair";
            Size = new Size(423, 519);
            ((System.ComponentModel.ISupportInitialize)Cabello).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Cabello;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbNameService;
        private Label lbDescriptionService;
        private Label lbCostService;
    }
}
