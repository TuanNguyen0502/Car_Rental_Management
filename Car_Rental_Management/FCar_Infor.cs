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
        private CarBrand carBrand;

        public FCar_Infor(CarBrand carbrand)
        {
            InitializeComponent();
            InitializeControls(carbrand);
            button_Add.Visible = true;
            button_Update.Visible = false;
        }
        public FCar_Infor(Ford ford)
        {
            InitializeComponent();
            this.ford = ford;
            car = ford;
            label_CarModel.Text = CarBrand.Ford.ToString();
            InitializeData();
            InitializeControls(CarBrand.Ford);
            checkBox_SoundProof.Checked = ford.IsSoundproof;
        }
        public FCar_Infor(Mazda mazda)
        {
            InitializeComponent();
            this.mazda = mazda;
            car = mazda;
            label_CarModel.Text = CarBrand.Mazda.ToString();
            InitializeData();
            InitializeControls(CarBrand.Mazda);
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
            InitializeControls(CarBrand.Mercedes);
            checkBox_Convertible.Checked = mercedes.IsConvertible;
        }
        public FCar_Infor(VinFast vinFast)
        {
            InitializeComponent();
            this.vinFast = vinFast;
            car = vinFast;
            label_CarModel.Text = CarBrand.VinFast.ToString();
            InitializeData();
            InitializeControls(CarBrand.VinFast);
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

        private void InitializeControls(CarBrand carbrand)
        {
            if (carbrand == CarBrand.Ford)
            {
                checkBox_SoundProof.Visible = true;
            }
            else if (carbrand == CarBrand.Mazda)
            {
                checkBox_Bluetooth.Visible = true;
                label_USBport.Visible = true;
                textBox_USBport.Visible = true;
            }
            else if (carbrand == CarBrand.Mercedes)
            {
                checkBox_Convertible.Visible = true;
            }
            else if (carbrand == CarBrand.VinFast)
            {
                checkBox_Electric.Visible = true;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            FuelType selectedFuelType = (FuelType)comboBox_FuelType.SelectedItem;
            Transmission selectedTransmission = (Transmission)comboBox_Transmission.SelectedItem;
            Condition selectedCondition = (Condition)comboBox_Condition.SelectedItem;
            Status selectedStatus = (Status)comboBox_Status.SelectedItem;

            if (carBrand == CarBrand.Ford)
            {
                Ford new_Ford = new Ford(
                    textBox_Name.Text, 
                    textBox_LicenseNumber.Text, 
                    textBox_Color.Text,
                    selectedFuelType,
                    textBox_FuelCapacity.Text,
                    textBox_FuelConsumption.Text, 
                    Int32.Parse(comboBox_Capacity.SelectedItem.ToString()), 
                    selectedTransmission,
                    textBox_Engine.Text, 
                    textBox_Power.Text, 
                    textBox_Year.Text,
                    selectedCondition,
                    selectedStatus,
                    checkBox_SoundProof.Checked);
                DataAccess.AddFord(new_Ford);
            }
            else if (carBrand == CarBrand.Mazda)
            {
                Mazda new_Mazda = new Mazda(
                    textBox_Name.Text,
                    textBox_LicenseNumber.Text,
                    textBox_Color.Text,
                    selectedFuelType,
                    textBox_FuelCapacity.Text,
                    textBox_FuelConsumption.Text,
                    Int32.Parse(comboBox_Capacity.SelectedItem.ToString()),
                    selectedTransmission,
                    textBox_Engine.Text,
                    textBox_Power.Text,
                    textBox_Year.Text,
                    selectedCondition,
                    selectedStatus,
                    checkBox_Bluetooth.Checked,
                    Int32.Parse(textBox_USBport.Text));
            }
            else if (carBrand == CarBrand.Mercedes)
            {
                Mercedes new_Mercedes = new Mercedes(
                    textBox_Name.Text,
                    textBox_LicenseNumber.Text,
                    textBox_Color.Text,
                    selectedFuelType,
                    textBox_FuelCapacity.Text,
                    textBox_FuelConsumption.Text,
                    Int32.Parse(comboBox_Capacity.SelectedItem.ToString()),
                    selectedTransmission,
                    textBox_Engine.Text,
                    textBox_Power.Text,
                    textBox_Year.Text,
                    selectedCondition,
                    selectedStatus,
                    checkBox_Convertible.Checked);
            }
            else if (carBrand == CarBrand.VinFast)
            {
                VinFast new_VinFast = new VinFast(
                    textBox_Name.Text,
                    textBox_LicenseNumber.Text,
                    textBox_Color.Text,
                    selectedFuelType, 
                    textBox_FuelCapacity.Text, 
                    textBox_FuelConsumption.Text, 
                    Int32.Parse(comboBox_Capacity.SelectedItem.ToString()), 
                    selectedTransmission, 
                    textBox_Engine.Text, 
                    textBox_Power.Text, 
                    textBox_Year.Text, 
                    selectedCondition, 
                    selectedStatus,
                    checkBox_Electric.Checked);
            }
            this.Close();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
