namespace Car_Rental_Management
{
    partial class FDashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelVehicles = new System.Windows.Forms.Panel();
            this.lblVehicles = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblnumVehicles = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelVehiclesIssued = new System.Windows.Forms.Panel();
            this.lblnumVehiclesIssued = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVehiclesIssued = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelVehiclesReturned = new System.Windows.Forms.Panel();
            this.lblnumVehiclesReturned = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVehiclesReturned = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelVehiclesAvailable = new System.Windows.Forms.Panel();
            this.lblnumVehiclesAvailable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVehiclesAvailable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelDamagedLost = new System.Windows.Forms.Panel();
            this.lblnumDamagedLost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDamagedLost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelClients = new System.Windows.Forms.Panel();
            this.lblnumClients = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblClients = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelClientsInPossession = new System.Windows.Forms.Panel();
            this.lblnumClientsInPossession = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblClientsInPossession = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelRevenue = new System.Windows.Forms.Panel();
            this.lblnumRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.lblTrans = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelVehicles.SuspendLayout();
            this.panelVehiclesIssued.SuspendLayout();
            this.panelVehiclesReturned.SuspendLayout();
            this.panelVehiclesAvailable.SuspendLayout();
            this.panelDamagedLost.SuspendLayout();
            this.panelClients.SuspendLayout();
            this.panelClientsInPossession.SuspendLayout();
            this.panelRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panelRevenue, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelClientsInPossession, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelClients, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelDamagedLost, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelVehiclesAvailable, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelVehiclesReturned, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelVehiclesIssued, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelVehicles, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1122, 164);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelVehicles
            // 
            this.panelVehicles.BackColor = System.Drawing.Color.Violet;
            this.panelVehicles.Controls.Add(this.lblnumVehicles);
            this.panelVehicles.Controls.Add(this.lblVehicles);
            this.panelVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVehicles.Location = new System.Drawing.Point(3, 3);
            this.panelVehicles.Name = "panelVehicles";
            this.panelVehicles.Size = new System.Drawing.Size(274, 76);
            this.panelVehicles.TabIndex = 1;
            // 
            // lblVehicles
            // 
            this.lblVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblVehicles.ForeColor = System.Drawing.Color.White;
            this.lblVehicles.Location = new System.Drawing.Point(9, 9);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(75, 22);
            this.lblVehicles.TabIndex = 0;
            this.lblVehicles.Text = "Vehicles";
            // 
            // lblnumVehicles
            // 
            this.lblnumVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblnumVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumVehicles.ForeColor = System.Drawing.Color.White;
            this.lblnumVehicles.Location = new System.Drawing.Point(9, 37);
            this.lblnumVehicles.Name = "lblnumVehicles";
            this.lblnumVehicles.Size = new System.Drawing.Size(31, 31);
            this.lblnumVehicles.TabIndex = 1;
            this.lblnumVehicles.Text = "10";
            // 
            // panelVehiclesIssued
            // 
            this.panelVehiclesIssued.BackColor = System.Drawing.Color.SteelBlue;
            this.panelVehiclesIssued.Controls.Add(this.lblnumVehiclesIssued);
            this.panelVehiclesIssued.Controls.Add(this.lblVehiclesIssued);
            this.panelVehiclesIssued.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVehiclesIssued.Location = new System.Drawing.Point(283, 3);
            this.panelVehiclesIssued.Name = "panelVehiclesIssued";
            this.panelVehiclesIssued.Size = new System.Drawing.Size(274, 76);
            this.panelVehiclesIssued.TabIndex = 2;
            // 
            // lblnumVehiclesIssued
            // 
            this.lblnumVehiclesIssued.BackColor = System.Drawing.Color.Transparent;
            this.lblnumVehiclesIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumVehiclesIssued.ForeColor = System.Drawing.Color.White;
            this.lblnumVehiclesIssued.Location = new System.Drawing.Point(9, 37);
            this.lblnumVehiclesIssued.Name = "lblnumVehiclesIssued";
            this.lblnumVehiclesIssued.Size = new System.Drawing.Size(17, 31);
            this.lblnumVehiclesIssued.TabIndex = 1;
            this.lblnumVehiclesIssued.Text = "4";
            // 
            // lblVehiclesIssued
            // 
            this.lblVehiclesIssued.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiclesIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblVehiclesIssued.ForeColor = System.Drawing.Color.White;
            this.lblVehiclesIssued.Location = new System.Drawing.Point(9, 9);
            this.lblVehiclesIssued.Name = "lblVehiclesIssued";
            this.lblVehiclesIssued.Size = new System.Drawing.Size(136, 22);
            this.lblVehiclesIssued.TabIndex = 0;
            this.lblVehiclesIssued.Text = "Vehicles Issued";
            // 
            // panelVehiclesReturned
            // 
            this.panelVehiclesReturned.BackColor = System.Drawing.Color.LimeGreen;
            this.panelVehiclesReturned.Controls.Add(this.lblnumVehiclesReturned);
            this.panelVehiclesReturned.Controls.Add(this.lblVehiclesReturned);
            this.panelVehiclesReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVehiclesReturned.Location = new System.Drawing.Point(563, 3);
            this.panelVehiclesReturned.Name = "panelVehiclesReturned";
            this.panelVehiclesReturned.Size = new System.Drawing.Size(274, 76);
            this.panelVehiclesReturned.TabIndex = 3;
            // 
            // lblnumVehiclesReturned
            // 
            this.lblnumVehiclesReturned.BackColor = System.Drawing.Color.Transparent;
            this.lblnumVehiclesReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumVehiclesReturned.ForeColor = System.Drawing.Color.White;
            this.lblnumVehiclesReturned.Location = new System.Drawing.Point(9, 37);
            this.lblnumVehiclesReturned.Name = "lblnumVehiclesReturned";
            this.lblnumVehiclesReturned.Size = new System.Drawing.Size(17, 31);
            this.lblnumVehiclesReturned.TabIndex = 1;
            this.lblnumVehiclesReturned.Text = "0";
            // 
            // lblVehiclesReturned
            // 
            this.lblVehiclesReturned.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiclesReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblVehiclesReturned.ForeColor = System.Drawing.Color.White;
            this.lblVehiclesReturned.Location = new System.Drawing.Point(9, 9);
            this.lblVehiclesReturned.Name = "lblVehiclesReturned";
            this.lblVehiclesReturned.Size = new System.Drawing.Size(157, 22);
            this.lblVehiclesReturned.TabIndex = 0;
            this.lblVehiclesReturned.Text = "Vehicles Returned";
            // 
            // panelVehiclesAvailable
            // 
            this.panelVehiclesAvailable.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelVehiclesAvailable.Controls.Add(this.lblnumVehiclesAvailable);
            this.panelVehiclesAvailable.Controls.Add(this.lblVehiclesAvailable);
            this.panelVehiclesAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVehiclesAvailable.Location = new System.Drawing.Point(843, 3);
            this.panelVehiclesAvailable.Name = "panelVehiclesAvailable";
            this.panelVehiclesAvailable.Size = new System.Drawing.Size(276, 76);
            this.panelVehiclesAvailable.TabIndex = 4;
            // 
            // lblnumVehiclesAvailable
            // 
            this.lblnumVehiclesAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblnumVehiclesAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumVehiclesAvailable.ForeColor = System.Drawing.Color.White;
            this.lblnumVehiclesAvailable.Location = new System.Drawing.Point(9, 37);
            this.lblnumVehiclesAvailable.Name = "lblnumVehiclesAvailable";
            this.lblnumVehiclesAvailable.Size = new System.Drawing.Size(17, 31);
            this.lblnumVehiclesAvailable.TabIndex = 1;
            this.lblnumVehiclesAvailable.Text = "6";
            // 
            // lblVehiclesAvailable
            // 
            this.lblVehiclesAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblVehiclesAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblVehiclesAvailable.ForeColor = System.Drawing.Color.White;
            this.lblVehiclesAvailable.Location = new System.Drawing.Point(9, 9);
            this.lblVehiclesAvailable.Name = "lblVehiclesAvailable";
            this.lblVehiclesAvailable.Size = new System.Drawing.Size(157, 22);
            this.lblVehiclesAvailable.TabIndex = 0;
            this.lblVehiclesAvailable.Text = "Vehicles Available";
            // 
            // panelDamagedLost
            // 
            this.panelDamagedLost.BackColor = System.Drawing.Color.Crimson;
            this.panelDamagedLost.Controls.Add(this.lblnumDamagedLost);
            this.panelDamagedLost.Controls.Add(this.lblDamagedLost);
            this.panelDamagedLost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDamagedLost.Location = new System.Drawing.Point(3, 85);
            this.panelDamagedLost.Name = "panelDamagedLost";
            this.panelDamagedLost.Size = new System.Drawing.Size(274, 76);
            this.panelDamagedLost.TabIndex = 5;
            // 
            // lblnumDamagedLost
            // 
            this.lblnumDamagedLost.BackColor = System.Drawing.Color.Transparent;
            this.lblnumDamagedLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumDamagedLost.ForeColor = System.Drawing.Color.White;
            this.lblnumDamagedLost.Location = new System.Drawing.Point(9, 37);
            this.lblnumDamagedLost.Name = "lblnumDamagedLost";
            this.lblnumDamagedLost.Size = new System.Drawing.Size(17, 31);
            this.lblnumDamagedLost.TabIndex = 1;
            this.lblnumDamagedLost.Text = "0";
            // 
            // lblDamagedLost
            // 
            this.lblDamagedLost.BackColor = System.Drawing.Color.Transparent;
            this.lblDamagedLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDamagedLost.ForeColor = System.Drawing.Color.White;
            this.lblDamagedLost.Location = new System.Drawing.Point(9, 9);
            this.lblDamagedLost.Name = "lblDamagedLost";
            this.lblDamagedLost.Size = new System.Drawing.Size(131, 22);
            this.lblDamagedLost.TabIndex = 0;
            this.lblDamagedLost.Text = "Damaged/ Lost";
            // 
            // panelClients
            // 
            this.panelClients.BackColor = System.Drawing.Color.Purple;
            this.panelClients.Controls.Add(this.lblnumClients);
            this.panelClients.Controls.Add(this.lblClients);
            this.panelClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClients.Location = new System.Drawing.Point(283, 85);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(274, 76);
            this.panelClients.TabIndex = 6;
            // 
            // lblnumClients
            // 
            this.lblnumClients.BackColor = System.Drawing.Color.Transparent;
            this.lblnumClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumClients.ForeColor = System.Drawing.Color.White;
            this.lblnumClients.Location = new System.Drawing.Point(9, 37);
            this.lblnumClients.Name = "lblnumClients";
            this.lblnumClients.Size = new System.Drawing.Size(17, 31);
            this.lblnumClients.TabIndex = 1;
            this.lblnumClients.Text = "3";
            // 
            // lblClients
            // 
            this.lblClients.BackColor = System.Drawing.Color.Transparent;
            this.lblClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblClients.ForeColor = System.Drawing.Color.White;
            this.lblClients.Location = new System.Drawing.Point(9, 9);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(62, 22);
            this.lblClients.TabIndex = 0;
            this.lblClients.Text = "Clients";
            // 
            // panelClientsInPossession
            // 
            this.panelClientsInPossession.BackColor = System.Drawing.Color.Orange;
            this.panelClientsInPossession.Controls.Add(this.lblnumClientsInPossession);
            this.panelClientsInPossession.Controls.Add(this.lblClientsInPossession);
            this.panelClientsInPossession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientsInPossession.Location = new System.Drawing.Point(563, 85);
            this.panelClientsInPossession.Name = "panelClientsInPossession";
            this.panelClientsInPossession.Size = new System.Drawing.Size(274, 76);
            this.panelClientsInPossession.TabIndex = 7;
            // 
            // lblnumClientsInPossession
            // 
            this.lblnumClientsInPossession.BackColor = System.Drawing.Color.Transparent;
            this.lblnumClientsInPossession.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumClientsInPossession.ForeColor = System.Drawing.Color.White;
            this.lblnumClientsInPossession.Location = new System.Drawing.Point(9, 37);
            this.lblnumClientsInPossession.Name = "lblnumClientsInPossession";
            this.lblnumClientsInPossession.Size = new System.Drawing.Size(17, 31);
            this.lblnumClientsInPossession.TabIndex = 1;
            this.lblnumClientsInPossession.Text = "4";
            // 
            // lblClientsInPossession
            // 
            this.lblClientsInPossession.BackColor = System.Drawing.Color.Transparent;
            this.lblClientsInPossession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblClientsInPossession.ForeColor = System.Drawing.Color.White;
            this.lblClientsInPossession.Location = new System.Drawing.Point(9, 9);
            this.lblClientsInPossession.Name = "lblClientsInPossession";
            this.lblClientsInPossession.Size = new System.Drawing.Size(186, 22);
            this.lblClientsInPossession.TabIndex = 0;
            this.lblClientsInPossession.Text = "Clients In Possession";
            // 
            // panelRevenue
            // 
            this.panelRevenue.BackColor = System.Drawing.Color.Green;
            this.panelRevenue.Controls.Add(this.lblnumRevenue);
            this.panelRevenue.Controls.Add(this.lblRevenue);
            this.panelRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRevenue.Location = new System.Drawing.Point(843, 85);
            this.panelRevenue.Name = "panelRevenue";
            this.panelRevenue.Size = new System.Drawing.Size(276, 76);
            this.panelRevenue.TabIndex = 8;
            // 
            // lblnumRevenue
            // 
            this.lblnumRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblnumRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumRevenue.ForeColor = System.Drawing.Color.White;
            this.lblnumRevenue.Location = new System.Drawing.Point(9, 37);
            this.lblnumRevenue.Name = "lblnumRevenue";
            this.lblnumRevenue.Size = new System.Drawing.Size(94, 31);
            this.lblnumRevenue.TabIndex = 1;
            this.lblnumRevenue.Text = "$420.00";
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Location = new System.Drawing.Point(9, 9);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(75, 22);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "Revenue";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(12, 205);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(265, 43);
            this.txtSearch.TabIndex = 8;
            // 
            // cbbStatus
            // 
            this.cbbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbStatus.BorderRadius = 20;
            this.cbbStatus.DisplayMember = "0";
            this.cbbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbStatus.ForeColor = System.Drawing.Color.Gray;
            this.cbbStatus.ItemHeight = 30;
            this.cbbStatus.Items.AddRange(new object[] {
            "Status(All)",
            "Returned",
            "Rented"});
            this.cbbStatus.Location = new System.Drawing.Point(389, 208);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(122, 36);
            this.cbbStatus.StartIndex = 0;
            this.cbbStatus.TabIndex = 11;
            this.cbbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Car_Rental_Management.Properties.Resources.icons8_find_16;
            this.btnSearch.Location = new System.Drawing.Point(283, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 39);
            this.btnSearch.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::Car_Rental_Management.Properties.Resources.icons8_refresh_16;
            this.btnRefresh.Location = new System.Drawing.Point(336, 207);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(45, 39);
            this.btnRefresh.TabIndex = 10;
            // 
            // lblTrans
            // 
            this.lblTrans.BackColor = System.Drawing.Color.Transparent;
            this.lblTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTrans.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrans.Location = new System.Drawing.Point(12, 176);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(168, 22);
            this.lblTrans.TabIndex = 2;
            this.lblTrans.Text = "Today Transactions";
            // 
            // FDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1122, 613);
            this.Controls.Add(this.lblTrans);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDashboard";
            this.Text = "FDashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelVehicles.ResumeLayout(false);
            this.panelVehicles.PerformLayout();
            this.panelVehiclesIssued.ResumeLayout(false);
            this.panelVehiclesIssued.PerformLayout();
            this.panelVehiclesReturned.ResumeLayout(false);
            this.panelVehiclesReturned.PerformLayout();
            this.panelVehiclesAvailable.ResumeLayout(false);
            this.panelVehiclesAvailable.PerformLayout();
            this.panelDamagedLost.ResumeLayout(false);
            this.panelDamagedLost.PerformLayout();
            this.panelClients.ResumeLayout(false);
            this.panelClients.PerformLayout();
            this.panelClientsInPossession.ResumeLayout(false);
            this.panelClientsInPossession.PerformLayout();
            this.panelRevenue.ResumeLayout(false);
            this.panelRevenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelVehicles;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVehicles;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnumVehicles;
        private System.Windows.Forms.Panel panelRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnumRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRevenue;
        private System.Windows.Forms.Panel panelClientsInPossession;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnumClientsInPossession;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClientsInPossession;
        private System.Windows.Forms.Panel panelClients;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnumClients;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClients;
        private System.Windows.Forms.Panel panelDamagedLost;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnumDamagedLost;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDamagedLost;
        private System.Windows.Forms.Panel panelVehiclesAvailable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnumVehiclesAvailable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVehiclesAvailable;
        private System.Windows.Forms.Panel panelVehiclesReturned;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnumVehiclesReturned;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVehiclesReturned;
        private System.Windows.Forms.Panel panelVehiclesIssued;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnumVehiclesIssued;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVehiclesIssued;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbbStatus;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTrans;
    }
}