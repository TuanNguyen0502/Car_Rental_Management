namespace Car_Rental_Management.Layouts
{
    partial class FContract
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnl_Tasbar = new Guna.UI2.WinForms.Guna2Panel();
            this.ptc_Ava = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbb_StatusRent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.flp_Contents = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_ContractContent1 = new Car_Rental_Management.ControlContent.UC_ContractContent();
            this.pnl_Tasbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_Ava)).BeginInit();
            this.flp_Contents.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnl_Tasbar
            // 
            this.pnl_Tasbar.Controls.Add(this.ptc_Ava);
            this.pnl_Tasbar.Controls.Add(this.txtSearch);
            this.pnl_Tasbar.Controls.Add(this.cbb_StatusRent);
            this.pnl_Tasbar.Controls.Add(this.guna2Button1);
            this.pnl_Tasbar.Controls.Add(this.guna2Button2);
            this.pnl_Tasbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tasbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tasbar.Name = "pnl_Tasbar";
            this.pnl_Tasbar.Size = new System.Drawing.Size(1362, 77);
            this.pnl_Tasbar.TabIndex = 9;
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
            this.cbb_StatusRent.Size = new System.Drawing.Size(205, 36);
            this.cbb_StatusRent.TabIndex = 7;
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
            // flp_Contents
            // 
            this.flp_Contents.Controls.Add(this.uC_ContractContent1);
            this.flp_Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Contents.Location = new System.Drawing.Point(0, 77);
            this.flp_Contents.Name = "flp_Contents";
            this.flp_Contents.Size = new System.Drawing.Size(1362, 652);
            this.flp_Contents.TabIndex = 10;
            // 
            // uC_ContractContent1
            // 
            this.uC_ContractContent1.Location = new System.Drawing.Point(3, 3);
            this.uC_ContractContent1.Name = "uC_ContractContent1";
            this.uC_ContractContent1.Size = new System.Drawing.Size(1358, 57);
            this.uC_ContractContent1.TabIndex = 0;
            // 
            // FContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 729);
            this.Controls.Add(this.flp_Contents);
            this.Controls.Add(this.pnl_Tasbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FContract";
            this.Text = "FContract";
            this.pnl_Tasbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptc_Ava)).EndInit();
            this.flp_Contents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnl_Tasbar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptc_Ava;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_StatusRent;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.FlowLayoutPanel flp_Contents;
        private ControlContent.UC_ContractContent uC_ContractContent1;
    }
}