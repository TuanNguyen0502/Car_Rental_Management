using Car_Rental_Management.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management
{
    public partial class UC_Car : UserControl
    {
        public UC_Car(Car car, CarBrand carBrand)
        {
            InitializeComponent();
            if (carBrand == CarBrand.Ford)
            {
                Ford ford = (Ford)car;
            }
            else if (carBrand == CarBrand.Mazda)
            {
                Mazda mazda = (Mazda)car;
            }
            else if (carBrand == CarBrand.Mercedes)
            {
                Mercedes mercedes = (Mercedes)car;
            }
            else if (carBrand == CarBrand.VinFast)
            {
                VinFast vinFast = (VinFast)car;
            }
            label_License.Text = car.LicenseNumber;
            label_Color.Text = car.Color;
            label_Year.Text = car.Year;
            label_FuelType.Text = car.FuelType.ToString();
            label_Capacity.Text = car.Capacity.ToString();
            label_Transmission.Text = car.Transmission.ToString();
            label_Condition.Text = car.Condition.ToString();
            label_Status.Text = car.Status.ToString();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            FCar_Infor fcar_Infor = new FCar_Infor();
            fcar_Infor.ShowDialog();
        }
    }
}
