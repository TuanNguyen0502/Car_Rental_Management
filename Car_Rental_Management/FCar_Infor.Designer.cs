namespace Car_Rental_Management
{
    partial class FCar_Infor
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.uC_CarInformation1 = new Car_Rental_Management.UC_CarInformation();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.button_Exit);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(833, 130);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car";
            // 
            // button_Exit
            // 
            this.button_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Exit.FillColor = System.Drawing.Color.Transparent;
            this.button_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Exit.ForeColor = System.Drawing.Color.Transparent;
            this.button_Exit.Image = global::Car_Rental_Management.Properties.Resources.icons8_x_48__1_;
            this.button_Exit.ImageSize = new System.Drawing.Size(60, 40);
            this.button_Exit.Location = new System.Drawing.Point(703, 26);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(85, 65);
            this.button_Exit.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = global::Car_Rental_Management.Properties.Resources.icons8_more_50;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(79, 70);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // uC_CarInformation1
            // 
            this.uC_CarInformation1.AutoScroll = true;
            this.uC_CarInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_CarInformation1.Location = new System.Drawing.Point(0, 130);
            this.uC_CarInformation1.Name = "uC_CarInformation1";
            this.uC_CarInformation1.Padding = new System.Windows.Forms.Padding(20);
            this.uC_CarInformation1.Size = new System.Drawing.Size(833, 524);
            this.uC_CarInformation1.TabIndex = 3;
            // 
            // FCar_Infor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(833, 654);
            this.Controls.Add(this.uC_CarInformation1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCar_Infor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car_Infor";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button button_Exit;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private UC_CarInformation uC_CarInformation1;
    }
}