using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management.ControlContent
{
    public partial class UC_Client : UserControl
    {
        private Customer _customer;
        private List<Customer> customerList;
        public UC_Client(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            LoadData();
            this.Load += new System.EventHandler(this.UC_Client_Load);
        }
        public void LoadData()
        {
            if (_customer != null)
            {
                lbl_CCCD.Text= _customer.CCCD.ToString();
                lbl_DrivingLicense.Text= _customer.DrivingLicense.ToString();
                lbl_Email.Text= _customer.Email.ToString();
                lbl_FullName.Text= _customer.FullName.ToString();
                lbl_Gender.Text= _customer.Gender.ToString();
                lbl_Phone.Text = _customer.PhoneNumber.ToString();
            }
        }
        private void UC_Client_Load(object sender, EventArgs e)
        {
            string name = lbl_FullName.Text;
            string initials = GetInitials(name);
            int avatarSize = 45; // Adjust size as needed
            Color backgroundColor = Color.Purple;
            Color textColor = Color.White;

            Bitmap avatar = CreateInitialsAvatar(initials, avatarSize, backgroundColor, textColor);
            cpb_Intitial_Img.Image = avatar;
            cpb_Intitial_Img.SizeMode = PictureBoxSizeMode.CenterImage;
            cpb_Intitial_Img.Size = new Size(avatarSize, avatarSize);
            cpb_Intitial_Img.Location = new Point(4, 4);
        }

            private string GetInitials(string name)
            {
                string[] parts = name.Split(' ');
                if (parts.Length >= 2)
                {
                    return $"{parts[0][0]}{parts[1][0]}";
                }
                else if (parts.Length == 1)
                {
                    return parts[0][0].ToString();
                }
                return string.Empty;
            }

            private Bitmap CreateInitialsAvatar(string initials, int size, Color backgroundColor, Color textColor)
            {
                Bitmap bitmap = new Bitmap(size, size);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Set the smoothing mode to AntiAlias for better quality
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    // Draw the background circle
                    using (SolidBrush brush = new SolidBrush(backgroundColor))
                    {
                        g.FillEllipse(brush, 0, 0, size, size);
                    }

                    // Draw the initials
                    using (Font font = new Font("Arial", size / 2, FontStyle.Bold, GraphicsUnit.Pixel))
                    using (SolidBrush brush = new SolidBrush(textColor))
                    {
                        SizeF textSize = g.MeasureString(initials, font);
                        PointF location = new PointF((size - textSize.Width) / 2, (size - textSize.Height) / 2);
                        g.DrawString(initials, font, brush, location);
                    }
                }
                return bitmap;
            }

        private void tlp_Content_Click(object sender, EventArgs e)
        {
            FCustomer_Information customer_Information = new FCustomer_Information(_customer);
            customer_Information.ShowDialog();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if(_customer != null)
            {
                var customer = customerList.SingleOrDefault(t => t.CustomerID == _customer.CustomerID);
                if (customer != null)
                    customerList.Remove(customer);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            FCustomer_Information customer_Information = new FCustomer_Information(_customer);
            customer_Information.ShowDialog();
        }
    }
}
