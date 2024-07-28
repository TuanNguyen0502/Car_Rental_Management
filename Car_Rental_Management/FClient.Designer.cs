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
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbb_Sex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnl_Tasbar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpProperties = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Prossession = new System.Windows.Forms.Label();
            this.lbl_Rent = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_ContainerContracts.SuspendLayout();
            this.pnl_Tasbar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tlpProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ContainerContracts
            // 
            this.pnl_ContainerContracts.Controls.Add(this.guna2Panel1);
            this.pnl_ContainerContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContainerContracts.Location = new System.Drawing.Point(0, 77);
            this.pnl_ContainerContracts.Name = "pnl_ContainerContracts";
            this.pnl_ContainerContracts.Size = new System.Drawing.Size(1359, 591);
            this.pnl_ContainerContracts.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderThickness = 2;
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
            this.cbb_Sex.BorderThickness = 2;
            this.cbb_Sex.DisplayMember = "0";
            this.cbb_Sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Sex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Sex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbb_Sex.ItemHeight = 40;
            this.cbb_Sex.Items.AddRange(new object[] {
            "Gender(All)",
            "Male",
            "Female"});
            this.cbb_Sex.Location = new System.Drawing.Point(428, 18);
            this.cbb_Sex.Name = "cbb_Sex";
            this.cbb_Sex.Size = new System.Drawing.Size(175, 46);
            this.cbb_Sex.StartIndex = 0;
            this.cbb_Sex.TabIndex = 7;
            this.cbb_Sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_Tasbar
            // 
            this.pnl_Tasbar.Controls.Add(this.btnAdd);
            this.pnl_Tasbar.Controls.Add(this.btnDel);
            this.pnl_Tasbar.Controls.Add(this.txtSearch);
            this.pnl_Tasbar.Controls.Add(this.cbb_Sex);
            this.pnl_Tasbar.Controls.Add(this.guna2Button1);
            this.pnl_Tasbar.Controls.Add(this.guna2Button2);
            this.pnl_Tasbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tasbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tasbar.Name = "pnl_Tasbar";
            this.pnl_Tasbar.Size = new System.Drawing.Size(1359, 77);
            this.pnl_Tasbar.TabIndex = 10;
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
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Car_Rental_Management.Properties.Resources.icons8_find_16;
            this.guna2Button1.Location = new System.Drawing.Point(296, 19);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(60, 43);
            this.guna2Button1.TabIndex = 5;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Car_Rental_Management.Properties.Resources.icons8_refresh_16;
            this.guna2Button2.Location = new System.Drawing.Point(362, 19);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(60, 43);
            this.guna2Button2.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tlpProperties);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1359, 54);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tlpProperties
            // 
            this.tlpProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tlpProperties.ColumnCount = 8;
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32498F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32498F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32498F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32498F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32498F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32498F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.28821F));
            this.tlpProperties.Controls.Add(this.lbl_ID, 6, 0);
            this.tlpProperties.Controls.Add(this.lbl_Prossession, 5, 0);
            this.tlpProperties.Controls.Add(this.lbl_Rent, 4, 0);
            this.tlpProperties.Controls.Add(this.lbl_FullName, 1, 0);
            this.tlpProperties.Controls.Add(this.lbl_Sex, 2, 0);
            this.tlpProperties.Controls.Add(this.label1, 3, 0);
            this.tlpProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProperties.Location = new System.Drawing.Point(0, 0);
            this.tlpProperties.Name = "tlpProperties";
            this.tlpProperties.RowCount = 1;
            this.tlpProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperties.Size = new System.Drawing.Size(1359, 54);
            this.tlpProperties.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(1075, 22);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(57, 20);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Text = "Spent";
            // 
            // lbl_Prossession
            // 
            this.lbl_Prossession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Prossession.AutoSize = true;
            this.lbl_Prossession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Prossession.ForeColor = System.Drawing.Color.White;
            this.lbl_Prossession.Location = new System.Drawing.Point(869, 22);
            this.lbl_Prossession.Name = "lbl_Prossession";
            this.lbl_Prossession.Size = new System.Drawing.Size(140, 16);
            this.lbl_Prossession.TabIndex = 5;
            this.lbl_Prossession.Text = "In Prossession";
            // 
            // lbl_Rent
            // 
            this.lbl_Rent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Rent.AutoSize = true;
            this.lbl_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Rent.ForeColor = System.Drawing.Color.White;
            this.lbl_Rent.Location = new System.Drawing.Point(743, 22);
            this.lbl_Rent.Name = "lbl_Rent";
            this.lbl_Rent.Size = new System.Drawing.Size(58, 16);
            this.lbl_Rent.TabIndex = 4;
            this.lbl_Rent.Text = "Rent";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Sex.ForeColor = System.Drawing.Color.White;
            this.lbl_Sex.Location = new System.Drawing.Point(404, 21);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(45, 16);
            this.lbl_Sex.TabIndex = 3;
            this.lbl_Sex.Text = "Sex";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.White;
            this.lbl_FullName.Location = new System.Drawing.Point(208, 20);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(96, 16);
            this.lbl_FullName.TabIndex = 2;
            this.lbl_FullName.Text = "Full Name";
            this.lbl_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(567, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phone";
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 668);
            this.Controls.Add(this.pnl_ContainerContracts);
            this.Controls.Add(this.pnl_Tasbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FClient";
            this.Text = "FClient";
            this.pnl_ContainerContracts.ResumeLayout(false);
            this.pnl_Tasbar.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tlpProperties.ResumeLayout(false);
            this.tlpProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ContainerContracts;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Sex;
        private Guna.UI2.WinForms.Guna2Panel pnl_Tasbar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tlpProperties;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Prossession;
        private System.Windows.Forms.Label lbl_Rent;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label label1;
    }
}