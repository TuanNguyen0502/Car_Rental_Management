namespace Car_Rental_Management
{
    partial class FCar
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
            this.textBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_Transmission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox_FuelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_Top = new Guna.UI2.WinForms.Guna2Panel();
            this.button_Reload = new Guna.UI2.WinForms.Guna2Button();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel_Center = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.AutoRoundedCorners = true;
            this.textBox_Search.BorderRadius = 27;
            this.textBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Search.DefaultText = "";
            this.textBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.ForeColor = System.Drawing.Color.Black;
            this.textBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.Location = new System.Drawing.Point(14, 19);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PasswordChar = '\0';
            this.textBox_Search.PlaceholderText = "Search...";
            this.textBox_Search.SelectedText = "";
            this.textBox_Search.Size = new System.Drawing.Size(293, 56);
            this.textBox_Search.TabIndex = 0;
            // 
            // comboBox_Transmission
            // 
            this.comboBox_Transmission.AutoRoundedCorners = true;
            this.comboBox_Transmission.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Transmission.BorderRadius = 27;
            this.comboBox_Transmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Transmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Transmission.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.comboBox_Transmission.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Transmission.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Transmission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_Transmission.ForeColor = System.Drawing.Color.White;
            this.comboBox_Transmission.ItemHeight = 50;
            this.comboBox_Transmission.Items.AddRange(new object[] {
            "Transmission (All)",
            "Manual",
            "Automatic"});
            this.comboBox_Transmission.Location = new System.Drawing.Point(521, 19);
            this.comboBox_Transmission.Name = "comboBox_Transmission";
            this.comboBox_Transmission.Size = new System.Drawing.Size(246, 56);
            this.comboBox_Transmission.StartIndex = 0;
            this.comboBox_Transmission.TabIndex = 3;
            this.comboBox_Transmission.SelectedIndexChanged += new System.EventHandler(this.comboBox_Transmission_SelectedIndexChanged);
            // 
            // comboBox_FuelType
            // 
            this.comboBox_FuelType.AutoRoundedCorners = true;
            this.comboBox_FuelType.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_FuelType.BorderRadius = 27;
            this.comboBox_FuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_FuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FuelType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.comboBox_FuelType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_FuelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_FuelType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_FuelType.ForeColor = System.Drawing.Color.White;
            this.comboBox_FuelType.ItemHeight = 50;
            this.comboBox_FuelType.Items.AddRange(new object[] {
            "Fuel Type (All)",
            "Gas",
            "Diesel Oil",
            "Electricity"});
            this.comboBox_FuelType.Location = new System.Drawing.Point(787, 19);
            this.comboBox_FuelType.Name = "comboBox_FuelType";
            this.comboBox_FuelType.Size = new System.Drawing.Size(218, 56);
            this.comboBox_FuelType.StartIndex = 0;
            this.comboBox_FuelType.TabIndex = 4;
            this.comboBox_FuelType.SelectedIndexChanged += new System.EventHandler(this.comboBox_FuelType_SelectedIndexChanged);
            // 
            // button_Add
            // 
            this.button_Add.AutoRoundedCorners = true;
            this.button_Add.BorderRadius = 29;
            this.button_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.button_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(1050, 19);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(118, 60);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "ADD";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 8, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1213, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "License";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(445, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(556, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fuel Type";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(693, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Capacity";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(810, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Transmission";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(955, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Condition";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1110, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Status";
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.button_Add);
            this.panel_Top.Controls.Add(this.tableLayoutPanel1);
            this.panel_Top.Controls.Add(this.textBox_Search);
            this.panel_Top.Controls.Add(this.comboBox_Transmission);
            this.panel_Top.Controls.Add(this.button_Reload);
            this.panel_Top.Controls.Add(this.button_Search);
            this.panel_Top.Controls.Add(this.comboBox_FuelType);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1213, 213);
            this.panel_Top.TabIndex = 1;
            // 
            // button_Reload
            // 
            this.button_Reload.AutoRoundedCorners = true;
            this.button_Reload.BackColor = System.Drawing.Color.White;
            this.button_Reload.BorderRadius = 29;
            this.button_Reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Reload.FillColor = System.Drawing.Color.White;
            this.button_Reload.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.button_Reload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Reload.ForeColor = System.Drawing.Color.White;
            this.button_Reload.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.button_Reload.Image = global::Car_Rental_Management.Properties.Resources.icons8_refresh_48;
            this.button_Reload.Location = new System.Drawing.Point(417, 19);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(80, 60);
            this.button_Reload.TabIndex = 2;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // button_Search
            // 
            this.button_Search.AutoRoundedCorners = true;
            this.button_Search.BackColor = System.Drawing.Color.White;
            this.button_Search.BorderRadius = 29;
            this.button_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Search.FillColor = System.Drawing.Color.White;
            this.button_Search.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.button_Search.Image = global::Car_Rental_Management.Properties.Resources.icons8_search_48;
            this.button_Search.Location = new System.Drawing.Point(315, 19);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(80, 60);
            this.button_Search.TabIndex = 1;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // flowLayoutPanel_Center
            // 
            this.flowLayoutPanel_Center.AutoScroll = true;
            this.flowLayoutPanel_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Center.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Center.Location = new System.Drawing.Point(0, 213);
            this.flowLayoutPanel_Center.Name = "flowLayoutPanel_Center";
            this.flowLayoutPanel_Center.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel_Center.Size = new System.Drawing.Size(1213, 498);
            this.flowLayoutPanel_Center.TabIndex = 2;
            this.flowLayoutPanel_Center.WrapContents = false;
            // 
            // FCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 711);
            this.Controls.Add(this.flowLayoutPanel_Center);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCar";
            this.Text = "FCar";
            this.Load += new System.EventHandler(this.FCar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2Button button_Reload;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_Transmission;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_FuelType;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel panel_Top;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Center;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}