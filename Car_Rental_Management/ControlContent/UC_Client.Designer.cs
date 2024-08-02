namespace Car_Rental_Management.ControlContent
{
    partial class UC_Client
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Top = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpProperties = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_DrivingLicense = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cpb_Intitial_Img = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            this.tlpProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpb_Intitial_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.tlpProperties);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1117, 54);
            this.panel_Top.TabIndex = 5;
            // 
            // tlpProperties
            // 
            this.tlpProperties.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tlpProperties.ColumnCount = 9;
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tlpProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpProperties.Controls.Add(this.cpb_Intitial_Img, 0, 0);
            this.tlpProperties.Controls.Add(this.lbl_Phone, 3, 0);
            this.tlpProperties.Controls.Add(this.lbl_Email, 5, 0);
            this.tlpProperties.Controls.Add(this.lbl_CCCD, 3, 0);
            this.tlpProperties.Controls.Add(this.lbl_FullName, 1, 0);
            this.tlpProperties.Controls.Add(this.lbl_Gender, 2, 0);
            this.tlpProperties.Controls.Add(this.lbl_DrivingLicense, 5, 0);
            this.tlpProperties.Controls.Add(this.btn_Del, 8, 0);
            this.tlpProperties.Controls.Add(this.btn_Edit, 7, 0);
            this.tlpProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpProperties.ForeColor = System.Drawing.Color.Black;
            this.tlpProperties.Location = new System.Drawing.Point(0, 0);
            this.tlpProperties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpProperties.Name = "tlpProperties";
            this.tlpProperties.RowCount = 1;
            this.tlpProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperties.Size = new System.Drawing.Size(1117, 54);
            this.tlpProperties.TabIndex = 6;
            this.tlpProperties.Click += new System.EventHandler(this.tlp_Content_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Del.FillColor = System.Drawing.Color.Transparent;
            this.btn_Del.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Image = global::Car_Rental_Management.Properties.Resources.icons8_delete_30;
            this.btn_Del.Location = new System.Drawing.Point(1037, 3);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 48);
            this.btn_Del.TabIndex = 21;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.FillColor = System.Drawing.Color.Transparent;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = global::Car_Rental_Management.Properties.Resources.icons8_edit_30;
            this.btn_Edit.Location = new System.Drawing.Point(954, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(77, 48);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(856, 17);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(51, 20);
            this.lbl_Email.TabIndex = 19;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_DrivingLicense
            // 
            this.lbl_DrivingLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DrivingLicense.AutoSize = true;
            this.lbl_DrivingLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DrivingLicense.Location = new System.Drawing.Point(679, 17);
            this.lbl_DrivingLicense.Name = "lbl_DrivingLicense";
            this.lbl_DrivingLicense.Size = new System.Drawing.Size(126, 20);
            this.lbl_DrivingLicense.TabIndex = 18;
            this.lbl_DrivingLicense.Text = "Driving License";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CCCD.Location = new System.Drawing.Point(574, 17);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(58, 20);
            this.lbl_CCCD.TabIndex = 17;
            this.lbl_CCCD.Text = "CCCD";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(436, 17);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(56, 20);
            this.lbl_Phone.TabIndex = 16;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(293, 17);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(64, 20);
            this.lbl_Gender.TabIndex = 15;
            this.lbl_Gender.Text = "Gender";
            // 
            // cpb_Intitial_Img
            // 
            this.cpb_Intitial_Img.ImageRotate = 0F;
            this.cpb_Intitial_Img.Location = new System.Drawing.Point(3, 3);
            this.cpb_Intitial_Img.Name = "cpb_Intitial_Img";
            this.cpb_Intitial_Img.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpb_Intitial_Img.Size = new System.Drawing.Size(48, 48);
            this.cpb_Intitial_Img.TabIndex = 13;
            this.cpb_Intitial_Img.TabStop = false;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(144, 17);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(85, 20);
            this.lbl_FullName.TabIndex = 14;
            this.lbl_FullName.Text = "Full Name";
            // 
            // UC_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Top);
            this.Name = "UC_Client";
            this.Size = new System.Drawing.Size(1117, 54);
            this.Load += new System.EventHandler(this.UC_Client_Load);
            this.panel_Top.ResumeLayout(false);
            this.tlpProperties.ResumeLayout(false);
            this.tlpProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpb_Intitial_Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_Top;
        private System.Windows.Forms.TableLayoutPanel tlpProperties;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpb_Intitial_Img;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.Label lbl_DrivingLicense;
        private System.Windows.Forms.Label lbl_Email;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_Del;
    }
}
