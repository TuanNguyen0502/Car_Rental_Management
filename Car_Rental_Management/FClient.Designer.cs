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
            this.panel_Top = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbb_Sex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.tlpProperties = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.lbl_DrivingLicense = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Center = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Top.SuspendLayout();
            this.tlpProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.btnAdd);
            this.panel_Top.Controls.Add(this.txtSearch);
            this.panel_Top.Controls.Add(this.cbb_Sex);
            this.panel_Top.Controls.Add(this.btnSearch);
            this.panel_Top.Controls.Add(this.btnRefresh);
            this.panel_Top.Controls.Add(this.tlpProperties);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1213, 189);
            this.panel_Top.TabIndex = 3;
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
            this.btnAdd.Location = new System.Drawing.Point(1026, 34);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 45);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(43, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(298, 45);
            this.txtSearch.TabIndex = 8;
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
            "Nam",
            "Nữ"});
            this.cbb_Sex.Location = new System.Drawing.Point(462, 34);
            this.cbb_Sex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_Sex.Name = "cbb_Sex";
            this.cbb_Sex.Size = new System.Drawing.Size(196, 36);
            this.cbb_Sex.StartIndex = 0;
            this.cbb_Sex.TabIndex = 11;
            this.cbb_Sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbb_Sex.SelectedIndexChanged += new System.EventHandler(this.cbb_Sex_SelectedIndexChanged);
            this.cbb_Sex.Click += new System.EventHandler(this.cbb_Sex_SelectedIndexChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(348, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 45);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(399, 34);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(48, 45);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tlpProperties
            // 
            this.tlpProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tlpProperties.ColumnCount = 8;
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.5F));
            this.tlpProperties.Controls.Add(this.lbl_FullName, 1, 0);
            this.tlpProperties.Controls.Add(this.lbl_Gender, 2, 0);
            this.tlpProperties.Controls.Add(this.lbl_Phone, 3, 0);
            this.tlpProperties.Controls.Add(this.lbl_CCCD, 4, 0);
            this.tlpProperties.Controls.Add(this.lbl_DrivingLicense, 5, 0);
            this.tlpProperties.Controls.Add(this.lbl_Email, 6, 0);
            this.tlpProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpProperties.ForeColor = System.Drawing.Color.Black;
            this.tlpProperties.Location = new System.Drawing.Point(0, 121);
            this.tlpProperties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpProperties.Name = "tlpProperties";
            this.tlpProperties.RowCount = 1;
            this.tlpProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperties.Size = new System.Drawing.Size(1213, 68);
            this.tlpProperties.TabIndex = 6;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.White;
            this.lbl_FullName.Location = new System.Drawing.Point(143, 21);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(118, 25);
            this.lbl_FullName.TabIndex = 3;
            this.lbl_FullName.Text = "Full Name";
            this.lbl_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Gender.ForeColor = System.Drawing.Color.White;
            this.lbl_Gender.Location = new System.Drawing.Point(309, 21);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(89, 25);
            this.lbl_Gender.TabIndex = 4;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Phone.ForeColor = System.Drawing.Color.White;
            this.lbl_Phone.Location = new System.Drawing.Point(465, 21);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(79, 25);
            this.lbl_Phone.TabIndex = 9;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_CCCD.ForeColor = System.Drawing.Color.White;
            this.lbl_CCCD.Location = new System.Drawing.Point(617, 21);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(76, 25);
            this.lbl_CCCD.TabIndex = 10;
            this.lbl_CCCD.Text = "CCCD";
            // 
            // lbl_DrivingLicense
            // 
            this.lbl_DrivingLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DrivingLicense.AutoSize = true;
            this.lbl_DrivingLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_DrivingLicense.ForeColor = System.Drawing.Color.White;
            this.lbl_DrivingLicense.Location = new System.Drawing.Point(759, 9);
            this.lbl_DrivingLicense.Name = "lbl_DrivingLicense";
            this.lbl_DrivingLicense.Size = new System.Drawing.Size(94, 50);
            this.lbl_DrivingLicense.TabIndex = 11;
            this.lbl_DrivingLicense.Text = "Driving License";
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(922, 21);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(70, 25);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "Email";
            // 
            // flowLayoutPanel_Center
            // 
            this.flowLayoutPanel_Center.AutoScroll = true;
            this.flowLayoutPanel_Center.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Center.Location = new System.Drawing.Point(0, 189);
            this.flowLayoutPanel_Center.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel_Center.Name = "flowLayoutPanel_Center";
            this.flowLayoutPanel_Center.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel_Center.Size = new System.Drawing.Size(1213, 525);
            this.flowLayoutPanel_Center.TabIndex = 4;
            this.flowLayoutPanel_Center.WrapContents = false;
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 711);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.flowLayoutPanel_Center);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FClient";
            this.Text = "FClient";
            this.Load += new System.EventHandler(this.FClient_Load);
            this.panel_Top.ResumeLayout(false);
            this.tlpProperties.ResumeLayout(false);
            this.tlpProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_Top;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Sex;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tlpProperties;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Center;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.Label lbl_DrivingLicense;
        private System.Windows.Forms.Label lbl_Email;
    }
}