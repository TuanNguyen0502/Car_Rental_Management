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
        public UC_Client()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.UC_Client_Load);
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


    }
}
