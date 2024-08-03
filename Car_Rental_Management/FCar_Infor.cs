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
    public partial class FCar_Infor : Form
    {
        private Car car;
        private Ford ford;
        private Mazda mazda;
        private Mercedes mercedes;
        private VinFast vinFast;

        public FCar_Infor(Ford ford)
        {
            InitializeComponent();
            this.ford = ford;
            car = ford;
            label_CarModel.Text = CarBrand.Ford.ToString();
            InitializeData();
            checkBox_SoundProof.Visible = true;
            checkBox_SoundProof.Checked = ford.IsSoundproof;
        }
        public FCar_Infor(Mazda mazda)
        {
            InitializeComponent();
            this.mazda = mazda;
            car = mazda;
            label_CarModel.Text = CarBrand.Mazda.ToString();
            InitializeData();
            checkBox_Bluetooth.Visible = true;
            label_USBport.Visible = true;
            textBox_USBport.Visible = true;
            checkBox_Bluetooth.Checked = mazda.HaveBluetooth;
            textBox_USBport.Text = mazda.USBPort.ToString();
        }
        public FCar_Infor(Mercedes mercedes)
        {
            InitializeComponent();
            this.mercedes = mercedes;
            car = mercedes;
            label_CarModel.Text = CarBrand.Mercedes.ToString();
            InitializeData();
            checkBox_Convertible.Visible = true;
            checkBox_Convertible.Checked = mercedes.IsConvertible;
        }
        public FCar_Infor(VinFast vinFast)
        {
            InitializeComponent();
            this.vinFast = vinFast;
            car = vinFast;
            label_CarModel.Text = CarBrand.VinFast.ToString();
            InitializeData();
            checkBox_Electric.Visible = true;
            checkBox_Electric.Checked = vinFast.IsElectric;
        }

        private void InitializeData()
        {
            textBox_Name.Text = car.Name;
            textBox_LicenseNumber.Text = car.LicenseNumber;
            textBox_Color.Text = car.Color;
            comboBox_FuelType.Text = car.FuelType.ToString();
            textBox_FuelCapacity.Text = car.FuelCapacity.ToString();
            textBox_FuelConsumption.Text = car.FuelConsumption.ToString();
            comboBox_Capacity.Text = car.Capacity.ToString();
            comboBox_Transmission.Text = car.Transmission.ToString();
            textBox_Engine.Text = car.Engine;
            textBox_Power.Text = car.Power.ToString();
            textBox_Year.Text = car.Year.ToString();
            comboBox_Condition.Text = car.Condition.ToString();
            comboBox_Status.Text = car.Status.ToString();
        }
    }
}
