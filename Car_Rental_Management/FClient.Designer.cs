namespace Car_Rental_Management
{
    partial class FClient
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
            this.pnl_ContainerContracts = new System.Windows.Forms.Panel();
            this.panel_Content = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_Tittle = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpProperties = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_DrivingLicense = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbb_Sex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnl_Search = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_ContainerContracts.SuspendLayout();
            this.panel_Tittle.SuspendLayout();
            this.tlpProperties.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ContainerContracts
            // 
            this.pnl_ContainerContracts.Controls.Add(this.panel_Content);
            this.pnl_ContainerContracts.Controls.Add(this.panel_Tittle);
            this.pnl_ContainerContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContainerContracts.Location = new System.Drawing.Point(0, 77);
            this.pnl_ContainerContracts.Name = "pnl_ContainerContracts";
            this.pnl_ContainerContracts.Size = new System.Drawing.Size(1359, 591);
            this.pnl_ContainerContracts.TabIndex = 11;
            // 
            // panel_Content
            // 
            this.panel_Content.Location = new System.Drawing.Point(0, 54);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1359, 537);
            this.panel_Content.TabIndex = 1;
            // 
            // panel_Tittle
            // 
            this.panel_Tittle.Controls.Add(this.tlpProperties);
            this.panel_Tittle.Location = new System.Drawing.Point(0, 0);
            this.panel_Tittle.Name = "panel_Tittle";
            this.panel_Tittle.Size = new System.Drawing.Size(1359, 54);
            this.panel_Tittle.TabIndex = 0;
            // 
            // tlpProperties
            // 
            this.tlpProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tlpProperties.ColumnCount = 8;
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.15113F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57096F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57096F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57096F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57096F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57096F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57096F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.4231F));
            this.tlpProperties.Controls.Add(this.lbl_Email, 6, 0);
            this.tlpProperties.Controls.Add(this.lbl_DrivingLicense, 5, 0);
            this.tlpProperties.Controls.Add(this.lbl_CCCD, 4, 0);
            this.tlpProperties.Controls.Add(this.lbl_FullName, 1, 0);
            this.tlpProperties.Controls.Add(this.lbl_Gender, 2, 0);
            this.tlpProperties.Controls.Add(this.lbl_Phone, 3, 0);
            this.tlpProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProperties.Location = new System.Drawing.Point(0, 0);
            this.tlpProperties.Name = "tlpProperties";
            this.tlpProperties.RowCount = 1;
            this.tlpProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperties.Size = new System.Drawing.Size(1359, 54);
            this.tlpProperties.TabIndex = 1;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(1044, 17);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(56, 20);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_DrivingLicense
            // 
            this.lbl_DrivingLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DrivingLicense.AutoSize = true;
            this.lbl_DrivingLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_DrivingLicense.ForeColor = System.Drawing.Color.White;
            this.lbl_DrivingLicense.Location = new System.Drawing.Point(831, 17);
            this.lbl_DrivingLicense.Name = "lbl_DrivingLicense";
            this.lbl_DrivingLicense.Size = new System.Drawing.Size(141, 20);
            this.lbl_DrivingLicense.TabIndex = 5;
            this.lbl_DrivingLicense.Text = "Driving License";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_CCCD.ForeColor = System.Drawing.Color.White;
            this.lbl_CCCD.Location = new System.Drawing.Point(701, 17);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(62, 20);
            this.lbl_CCCD.TabIndex = 4;
            this.lbl_CCCD.Text = "CCCD";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.White;
            this.lbl_FullName.Location = new System.Drawing.Point(175, 17);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(94, 20);
            this.lbl_FullName.TabIndex = 2;
            this.lbl_FullName.Text = "Full Name";
            this.lbl_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Gender.ForeColor = System.Drawing.Color.White;
            this.lbl_Gender.Location = new System.Drawing.Point(357, 17);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(70, 20);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Phone.ForeColor = System.Drawing.Color.White;
            this.lbl_Phone.Location = new System.Drawing.Point(531, 17);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(61, 20);
            this.lbl_Phone.TabIndex = 8;
            this.lbl_Phone.Text = "Phone";
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
            this.txtSearch.Location = new System.Drawing.Point(25, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(265, 43);
            this.txtSearch.TabIndex = 4;
            // 
            // cbb_Sex
            // 
            this.cbb_Sex.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Sex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Sex.BorderRadius = 20;
            this.cbb_Sex.DisplayMember = "0";
            this.cbb_Sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Sex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Sex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Sex.ForeColor = System.Drawing.Color.Gray;
            this.cbb_Sex.ItemHeight = 30;
            this.cbb_Sex.Items.AddRange(new object[] {
            "Gender(All)",
            "Male",
            "Female"});
            this.cbb_Sex.Location = new System.Drawing.Point(427, 19);
            this.cbb_Sex.Name = "cbb_Sex";
            this.cbb_Sex.Size = new System.Drawing.Size(175, 36);
            this.cbb_Sex.StartIndex = 0;
            this.cbb_Sex.TabIndex = 7;
            this.cbb_Sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.btnAdd);
            this.pnl_Search.Controls.Add(this.btnDel);
            this.pnl_Search.Controls.Add(this.txtSearch);
            this.pnl_Search.Controls.Add(this.cbb_Sex);
            this.pnl_Search.Controls.Add(this.btnSearch);
            this.pnl_Search.Controls.Add(this.btnRefresh);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1359, 77);
            this.pnl_Search.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Car_Rental_Management.Properties.Resources.icons8_add_30;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.Location = new System.Drawing.Point(1047, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            // 
            // btnDel
            // 
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.Red;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = global::Car_Rental_Management.Properties.Resources.icons8_delete_30;
            this.btnDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDel.Location = new System.Drawing.Point(1190, 17);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(137, 45);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
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
            this.btnSearch.Location = new System.Drawing.Point(296, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 43);
            this.btnSearch.TabIndex = 5;
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
            this.btnRefresh.Location = new System.Drawing.Point(360, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 43);
            this.btnRefresh.TabIndex = 6;
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 668);
            this.Controls.Add(this.pnl_ContainerContracts);
            this.Controls.Add(this.pnl_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FClient";
            this.Text = "FClient";
            this.Load += new System.EventHandler(this.FClient_Load);
            this.pnl_ContainerContracts.ResumeLayout(false);
            this.panel_Tittle.ResumeLayout(false);
            this.tlpProperties.ResumeLayout(false);
            this.tlpProperties.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ContainerContracts;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Sex;
        private Guna.UI2.WinForms.Guna2Panel pnl_Search;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Panel panel_Tittle;
        private System.Windows.Forms.TableLayoutPanel tlpProperties;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_DrivingLicense;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Phone;
        private Guna.UI2.WinForms.Guna2Panel panel_Content;
    }
}