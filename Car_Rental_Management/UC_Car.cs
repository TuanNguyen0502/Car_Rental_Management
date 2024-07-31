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
        public UC_Car(Car car)
        {
            InitializeComponent();
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

        }
    }
}
