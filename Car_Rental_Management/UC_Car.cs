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
        private Car car;
        private Ford ford;
        private Mazda mazda;
        private Mercedes mercedes;
        private VinFast vinFast;
        private bool isFord = false;
        private bool isMazda = false;
        private bool isMercedes = false;
        private bool isVinFast = false;

        public UC_Car(Car car, CarBrand carBrand)
        {
            InitializeComponent();
            if (carBrand == CarBrand.Ford)
            {
                ford = (Ford)car;
                isFord = true;
            }
            else if (carBrand == CarBrand.Mazda)
            {
                mazda = (Mazda)car;
                isMazda = true;
            }
            else if (carBrand == CarBrand.Mercedes)
            {
                mercedes = (Mercedes)car;
                isMercedes = true;
            }
            else if (carBrand == CarBrand.VinFast)
            {
                vinFast = (VinFast)car;
                isVinFast = true;
            }
            label_Name.Text = car.Name;
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
            FCar_Infor fcar_Infor;
            if (isFord)
            {
                fcar_Infor = new FCar_Infor(ford);
            }
            else if (isMazda)
            {
                fcar_Infor = new FCar_Infor(mazda);
            }
            else if (isMercedes)
            {
                fcar_Infor = new FCar_Infor(mercedes);
            }
            else
            {
                fcar_Infor = new FCar_Infor(vinFast);
            }
            fcar_Infor.ShowDialog();
        }
    }
}
