namespace Car_Rental_Management
{
    partial class Form1
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
            this.pnl_Content = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_Container = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Contract = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Content
            // 
            this.pnl_Content.Controls.Add(this.btn_Contract);
            this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Content.Location = new System.Drawing.Point(0, 0);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(200, 660);
            this.pnl_Content.TabIndex = 0;
            // 
            // pnl_Container
            // 
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(200, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1140, 660);
            this.pnl_Container.TabIndex = 1;
            // 
            // btn_Contract
            // 
            this.btn_Contract.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Contract.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Contract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Contract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Contract.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Contract.ForeColor = System.Drawing.Color.White;
            this.btn_Contract.Location = new System.Drawing.Point(14, 115);
            this.btn_Contract.Name = "btn_Contract";
            this.btn_Contract.Size = new System.Drawing.Size(180, 45);
            this.btn_Contract.TabIndex = 0;
            this.btn_Contract.Text = "Hợp đồng";
            this.btn_Contract.Click += new System.EventHandler(this.btn_Contract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 660);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Content);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Content;
        private Guna.UI2.WinForms.Guna2Panel pnl_Container;
        private Guna.UI2.WinForms.Guna2Button btn_Contract;
    }
}

