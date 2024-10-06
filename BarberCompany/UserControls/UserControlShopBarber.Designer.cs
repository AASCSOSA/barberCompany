namespace BarberCompany.UserControls
{
    partial class UserControlShopBarber
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbCityShop = new Label();
            lbNumShop = new Label();
            lbAddressShop = new Label();
            lbNameShop = new Label();
            label9 = new Label();
            lbIdShop = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label4.Location = new Point(162, 261);
            label4.Name = "label4";
            label4.Size = new Size(95, 31);
            label4.TabIndex = 7;
            label4.Text = "Ciudad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label3.Location = new Point(72, 198);
            label3.Name = "label3";
            label3.Size = new Size(185, 31);
            label3.TabIndex = 6;
            label3.Text = "Número exterior :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label2.Location = new Point(140, 138);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 5;
            label2.Text = "Dirección :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label1.Location = new Point(13, 70);
            label1.Name = "label1";
            label1.Size = new Size(244, 31);
            label1.TabIndex = 4;
            label1.Text = "Nombre de la sucursal :";
            // 
            // lbCityShop
            // 
            lbCityShop.AutoSize = true;
            lbCityShop.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            lbCityShop.Location = new Point(287, 261);
            lbCityShop.Name = "lbCityShop";
            lbCityShop.Size = new Size(95, 31);
            lbCityShop.TabIndex = 11;
            lbCityShop.Text = "Ciudad :";
            // 
            // lbNumShop
            // 
            lbNumShop.AutoSize = true;
            lbNumShop.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            lbNumShop.Location = new Point(287, 198);
            lbNumShop.Name = "lbNumShop";
            lbNumShop.Size = new Size(185, 31);
            lbNumShop.TabIndex = 10;
            lbNumShop.Text = "Número exterior :";
            // 
            // lbAddressShop
            // 
            lbAddressShop.AutoSize = true;
            lbAddressShop.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            lbAddressShop.Location = new Point(287, 138);
            lbAddressShop.Name = "lbAddressShop";
            lbAddressShop.Size = new Size(117, 31);
            lbAddressShop.TabIndex = 9;
            lbAddressShop.Text = "Dirección :";
            // 
            // lbNameShop
            // 
            lbNameShop.AutoSize = true;
            lbNameShop.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            lbNameShop.Location = new Point(287, 70);
            lbNameShop.Name = "lbNameShop";
            lbNameShop.Size = new Size(244, 31);
            lbNameShop.TabIndex = 8;
            lbNameShop.Text = "Nombre de la sucursal :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label9.Location = new Point(115, 14);
            label9.Name = "label9";
            label9.Size = new Size(142, 31);
            label9.TabIndex = 12;
            label9.Text = "Sucursal No :";
            // 
            // lbIdShop
            // 
            lbIdShop.AutoSize = true;
            lbIdShop.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            lbIdShop.Location = new Point(287, 14);
            lbIdShop.Name = "lbIdShop";
            lbIdShop.Size = new Size(142, 31);
            lbIdShop.TabIndex = 13;
            lbIdShop.Text = "Sucursal No :";
            // 
            // UserControlShopBarber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 67, 13);
            Controls.Add(lbIdShop);
            Controls.Add(label9);
            Controls.Add(lbCityShop);
            Controls.Add(lbNumShop);
            Controls.Add(lbAddressShop);
            Controls.Add(lbNameShop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlShopBarber";
            Size = new Size(544, 301);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbCityShop;
        private Label lbNumShop;
        private Label lbAddressShop;
        private Label lbNameShop;
        private Label label9;
        private Label lbIdShop;
    }
}
