﻿namespace Car_Rental_Management
{
    partial class FMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnClients = new Guna.UI2.WinForms.Guna2Button();
            this.btnContracts = new Guna.UI2.WinForms.Guna2Button();
            this.btnVehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.btnClients);
            this.panelMenu.Controls.Add(this.btnContracts);
            this.panelMenu.Controls.Add(this.btnVehicles);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.imgSlide);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(237, 660);
            this.panelMenu.TabIndex = 0;
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.White;
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(237, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.pnl_Container.Size = new System.Drawing.Size(1103, 660);
            this.pnl_Container.TabIndex = 1;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BorderRadius = 22;
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnProfile.CheckedState.Image = global::Car_Rental_Management.Properties.Resources.icons8_admin_settings_male_48__1_;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = global::Car_Rental_Management.Properties.Resources.icons8_admin_settings_male_48;
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.Location = new System.Drawing.Point(28, 355);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(194, 43);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseTransparentBackground = true;
            this.btnProfile.CheckedChanged += new System.EventHandler(this.btnDashboard_CheckedChanged);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.BorderRadius = 22;
            this.btnClients.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnClients.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnClients.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnClients.CheckedState.Image = global::Car_Rental_Management.Properties.Resources.icons8_client_50__1_;
            this.btnClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnClients.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Image = global::Car_Rental_Management.Properties.Resources.icons8_client_50;
            this.btnClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClients.Location = new System.Drawing.Point(28, 290);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(194, 43);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Clients";
            this.btnClients.UseTransparentBackground = true;
            this.btnClients.CheckedChanged += new System.EventHandler(this.btnDashboard_CheckedChanged);
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.Color.Transparent;
            this.btnContracts.BorderRadius = 22;
            this.btnContracts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnContracts.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnContracts.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnContracts.CheckedState.Image = global::Car_Rental_Management.Properties.Resources.icons8_contract_48__1_;
            this.btnContracts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContracts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContracts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContracts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContracts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnContracts.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnContracts.ForeColor = System.Drawing.Color.White;
            this.btnContracts.Image = global::Car_Rental_Management.Properties.Resources.icons8_contract_48;
            this.btnContracts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnContracts.Location = new System.Drawing.Point(28, 225);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(194, 43);
            this.btnContracts.TabIndex = 3;
            this.btnContracts.Text = "Contracts";
            this.btnContracts.UseTransparentBackground = true;
            this.btnContracts.CheckedChanged += new System.EventHandler(this.btnDashboard_CheckedChanged);
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicles.BorderRadius = 22;
            this.btnVehicles.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVehicles.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnVehicles.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnVehicles.CheckedState.Image = global::Car_Rental_Management.Properties.Resources.icons8_car_50__1_;
            this.btnVehicles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVehicles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVehicles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVehicles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnVehicles.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.HoverState.Image = global::Car_Rental_Management.Properties.Resources.icons8_car_50;
            this.btnVehicles.Image = global::Car_Rental_Management.Properties.Resources.icons8_car_50;
            this.btnVehicles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVehicles.Location = new System.Drawing.Point(28, 160);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(194, 43);
            this.btnVehicles.TabIndex = 2;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseTransparentBackground = true;
            this.btnVehicles.CheckedChanged += new System.EventHandler(this.btnDashboard_CheckedChanged);
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 22;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDashboard.CheckedState.Image = global::Car_Rental_Management.Properties.Resources.icons8_dashboard_50__1_;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Car_Rental_Management.Properties.Resources.icons8_dashboard_50;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Location = new System.Drawing.Point(28, 89);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(194, 43);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseTransparentBackground = true;
            this.btnDashboard.CheckedChanged += new System.EventHandler(this.btnDashboard_CheckedChanged);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = global::Car_Rental_Management.Properties.Resources.New_Project__3_;
            this.imgSlide.Location = new System.Drawing.Point(198, 59);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(55, 98);
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            // 
            // FMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1340, 660);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button btnVehicles;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnClients;
        private Guna.UI2.WinForms.Guna2Button btnContracts;
        private System.Windows.Forms.Panel pnl_Container;
    }
}

