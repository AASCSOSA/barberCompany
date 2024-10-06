namespace BarberCompany.Forms
{
    partial class FormAddBarberShop
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNameShop = new TextBox();
            txtAddress = new TextBox();
            txtNumAddress = new TextBox();
            txtCity = new TextBox();
            btnAddShop = new Button();
            btnCanceled = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(244, 31);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la sucursal :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label2.Location = new Point(162, 97);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 1;
            label2.Text = "Dirección :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label3.Location = new Point(94, 157);
            label3.Name = "label3";
            label3.Size = new Size(185, 31);
            label3.TabIndex = 2;
            label3.Text = "Número exterior :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic);
            label4.Location = new Point(184, 220);
            label4.Name = "label4";
            label4.Size = new Size(95, 31);
            label4.TabIndex = 3;
            label4.Text = "Ciudad :";
            // 
            // txtNameShop
            // 
            txtNameShop.Location = new Point(295, 29);
            txtNameShop.Name = "txtNameShop";
            txtNameShop.Size = new Size(328, 27);
            txtNameShop.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(295, 100);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(328, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtNumAddress
            // 
            txtNumAddress.Location = new Point(295, 164);
            txtNumAddress.Name = "txtNumAddress";
            txtNumAddress.Size = new Size(328, 27);
            txtNumAddress.TabIndex = 6;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(295, 226);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(328, 27);
            txtCity.TabIndex = 7;
            // 
            // btnAddShop
            // 
            btnAddShop.Location = new Point(652, 62);
            btnAddShop.Name = "btnAddShop";
            btnAddShop.Size = new Size(94, 29);
            btnAddShop.TabIndex = 8;
            btnAddShop.Text = "Agregar";
            btnAddShop.UseVisualStyleBackColor = true;
            btnAddShop.Click += btnAddShop_Click;
            // 
            // btnCanceled
            // 
            btnCanceled.Location = new Point(652, 143);
            btnCanceled.Name = "btnCanceled";
            btnCanceled.Size = new Size(94, 29);
            btnCanceled.TabIndex = 9;
            btnCanceled.Text = "Cancelar";
            btnCanceled.UseVisualStyleBackColor = true;
            btnCanceled.Click += btnCanceled_Click;
            // 
            // FormAddBarberShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 304);
            Controls.Add(btnCanceled);
            Controls.Add(btnAddShop);
            Controls.Add(txtCity);
            Controls.Add(txtNumAddress);
            Controls.Add(txtAddress);
            Controls.Add(txtNameShop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddBarberShop";
            Text = "FormAddBarberShop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNameShop;
        private TextBox txtAddress;
        private TextBox txtNumAddress;
        private TextBox txtCity;
        private Button btnAddShop;
        private Button btnCanceled;
    }
}