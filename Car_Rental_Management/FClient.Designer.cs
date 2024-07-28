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
            this.cbb_StatusRent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnl_Tasbar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.ptc_Ava = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Tasbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_Ava)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ContainerContracts
            // 
            this.pnl_ContainerContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContainerContracts.Location = new System.Drawing.Point(0, 77);
            this.pnl_ContainerContracts.Name = "pnl_ContainerContracts";
            this.pnl_ContainerContracts.Size = new System.Drawing.Size(1359, 591);
            this.pnl_ContainerContracts.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(157, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search contract...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(265, 43);
            this.txtSearch.TabIndex = 4;
            // 
            // cbb_StatusRent
            // 
            this.cbb_StatusRent.BackColor = System.Drawing.Color.White;
            this.cbb_StatusRent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_StatusRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_StatusRent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_StatusRent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_StatusRent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_StatusRent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_StatusRent.ForeColor = System.Drawing.Color.White;
            this.cbb_StatusRent.ItemHeight = 30;
            this.cbb_StatusRent.Items.AddRange(new object[] {
            "Tất cả",
            "Đang thuê",
            "Đã trả",
            "Đã đặt cọc"});
            this.cbb_StatusRent.Location = new System.Drawing.Point(560, 16);
            this.cbb_StatusRent.Name = "cbb_StatusRent";
            this.cbb_StatusRent.Size = new System.Drawing.Size(175, 36);
            this.cbb_StatusRent.TabIndex = 7;
            // 
            // pnl_Tasbar
            // 
            this.pnl_Tasbar.Controls.Add(this.btnAdd);
            this.pnl_Tasbar.Controls.Add(this.btnDel);
            this.pnl_Tasbar.Controls.Add(this.ptc_Ava);
            this.pnl_Tasbar.Controls.Add(this.txtSearch);
            this.pnl_Tasbar.Controls.Add(this.cbb_StatusRent);
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
            // ptc_Ava
            // 
            this.ptc_Ava.ImageRotate = 0F;
            this.ptc_Ava.Location = new System.Drawing.Point(10, 7);
            this.ptc_Ava.Name = "ptc_Ava";
            this.ptc_Ava.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptc_Ava.Size = new System.Drawing.Size(64, 64);
            this.ptc_Ava.TabIndex = 0;
            this.ptc_Ava.TabStop = false;
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
            this.guna2Button1.Location = new System.Drawing.Point(428, 17);
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
            this.guna2Button2.Location = new System.Drawing.Point(494, 17);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(60, 43);
            this.guna2Button2.TabIndex = 6;
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
            this.pnl_Tasbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptc_Ava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ContainerContracts;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_StatusRent;
        private Guna.UI2.WinForms.Guna2Panel pnl_Tasbar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptc_Ava;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDel;
    }
}