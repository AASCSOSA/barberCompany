﻿namespace BarberCompany.Forms
{
    partial class FormShopBarber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShopBarber));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbBarber = new LinkLabel();
            lbCities = new LinkLabel();
            lbServices = new LinkLabel();
            labelHome = new LinkLabel();
            label1 = new Label();
            btnNewShopBarber = new Button();
            flwShopsBarber = new FlowLayoutPanel();
            lbShopBarber = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 140, 43);
            panel1.Controls.Add(lbShopBarber);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbBarber);
            panel1.Controls.Add(lbCities);
            panel1.Controls.Add(lbServices);
            panel1.Controls.Add(labelHome);
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 96);
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
            lbBarber.Location = new Point(1447, 29);
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
            lbCities.Location = new Point(1340, 29);
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
            lbServices.Location = new Point(1188, 29);
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
            labelHome.Location = new Point(1074, 29);
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
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 118);
            label1.Name = "label1";
            label1.Size = new Size(195, 50);
            label1.TabIndex = 6;
            label1.Text = "Sucursales";
            // 
            // btnNewShopBarber
            // 
            btnNewShopBarber.BackColor = Color.FromArgb(236, 140, 43);
            btnNewShopBarber.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNewShopBarber.ForeColor = Color.White;
            btnNewShopBarber.Location = new Point(937, 188);
            btnNewShopBarber.Name = "btnNewShopBarber";
            btnNewShopBarber.Size = new Size(206, 51);
            btnNewShopBarber.TabIndex = 8;
            btnNewShopBarber.Text = "Agregar Sucursal";
            btnNewShopBarber.UseVisualStyleBackColor = false;
            btnNewShopBarber.Click += btnNewShopBarber_Click;
            // 
            // flwShopsBarber
            // 
            flwShopsBarber.AutoScroll = true;
            flwShopsBarber.BackColor = Color.FromArgb(41, 41, 41);
            flwShopsBarber.Location = new Point(12, 305);
            flwShopsBarber.Name = "flwShopsBarber";
            flwShopsBarber.Size = new Size(1891, 716);
            flwShopsBarber.TabIndex = 9;
            // 
            // lbShopBarber
            // 
            lbShopBarber.ActiveLinkColor = Color.Gainsboro;
            lbShopBarber.AutoSize = true;
            lbShopBarber.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbShopBarber.LinkColor = Color.White;
            lbShopBarber.Location = new Point(1592, 29);
            lbShopBarber.Name = "lbShopBarber";
            lbShopBarber.Size = new Size(148, 38);
            lbShopBarber.TabIndex = 9;
            lbShopBarber.TabStop = true;
            lbShopBarber.Text = "Sucursales";
            lbShopBarber.LinkClicked += lbShopBarber_LinkClicked;
            // 
            // FormShopBarber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(1924, 1033);
            Controls.Add(flwShopsBarber);
            Controls.Add(btnNewShopBarber);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormShopBarber";
            Text = "FormShopBarber";
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
        private Button btnNewShopBarber;
        private FlowLayoutPanel flwShopsBarber;
        private LinkLabel lbShopBarber;
    }
}