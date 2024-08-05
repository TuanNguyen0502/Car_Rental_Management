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
    public partial class FCar : Form
    {
        private List<Ford> fords;
        private List<Mazda> mazda;
        private List<Mercedes> mercedes;
        private List<VinFast> vinfasts;

        public FCar()
        {
            InitializeComponent();
        }

        private void FCar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            fords = DataAccess.Fords;
            mazda = DataAccess.Mazdas;
            mercedes = DataAccess.Mercedeses;
            vinfasts = DataAccess.VinFasts;
            LoadUC();
        }
        private void LoadData(string search)
        {
            fords = DataAccess.Fords
                .Where(f => (f.Name.ToLower().Contains(search.ToLower()) ||
                       f.Year.ToLower().Contains(search.ToLower()) ||
                       f.LicenseNumber.ToLower().Contains(search.ToLower()) ||
                       f.Color.ToLower().Contains(search.ToLower()) ||
                       f.FuelType.ToString().ToLower().Contains(search.ToLower()) || 
                       f.FuelCapacity.ToLower().Contains(search.ToLower()) || 
                       f.FuelConsumption.ToLower().Contains(search.ToLower()) ||
                       f.Capacity.ToString().ToLower().Contains(search.ToLower()) || 
                       f.Transmission.ToString().ToLower().Contains(search.ToLower()) || 
                       f.Engine.ToLower().Contains(search.ToLower()) || 
                       f.Power.ToLower().Contains(search.ToLower()) || 
                       f.Year.ToLower().Contains(search.ToLower()) || 
                       f.Condition.ToString().ToLower().Contains(search.ToLower()) || 
                       f.Status.ToString().ToLower().Contains(search.ToLower())))
                .ToList();
            mazda = DataAccess.Mazdas
                .Where(f => (f.Name.ToLower().Contains(search.ToLower()) ||
                       f.Year.ToLower().Contains(search.ToLower()) ||
                       f.LicenseNumber.ToLower().Contains(search.ToLower()) ||
                       f.Color.ToLower().Contains(search.ToLower()) ||
                       f.FuelType.ToString().ToLower().Contains(search.ToLower()) ||
                       f.FuelCapacity.ToLower().Contains(search.ToLower()) ||
                       f.FuelConsumption.ToLower().Contains(search.ToLower()) ||
                       f.Capacity.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Transmission.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Engine.ToLower().Contains(search.ToLower()) ||
                       f.Power.ToLower().Contains(search.ToLower()) ||
                       f.Year.ToLower().Contains(search.ToLower()) ||
                       f.Condition.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Status.ToString().ToLower().Contains(search.ToLower())))
                .ToList();
            mercedes = DataAccess.Mercedeses
                .Where(f => (f.Name.ToLower().Contains(search.ToLower()) ||
                       f.Year.ToLower().Contains(search.ToLower()) ||
                       f.LicenseNumber.ToLower().Contains(search.ToLower()) ||
                       f.Color.ToLower().Contains(search.ToLower()) ||
                       f.FuelType.ToString().ToLower().Contains(search.ToLower()) ||
                       f.FuelCapacity.ToLower().Contains(search.ToLower()) ||
                       f.FuelConsumption.ToLower().Contains(search.ToLower()) ||
                       f.Capacity.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Transmission.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Engine.ToLower().Contains(search.ToLower()) ||
                       f.Power.ToLower().Contains(search.ToLower()) ||
                       f.Year.ToLower().Contains(search.ToLower()) ||
                       f.Condition.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Status.ToString().ToLower().Contains(search.ToLower())))
                .ToList();
            vinfasts = DataAccess.VinFasts
                .Where(f => (f.Name.ToLower().Contains(search.ToLower()) ||
                       f.Year.ToLower().Contains(search.ToLower()) ||
                       f.LicenseNumber.ToLower().Contains(search.ToLower()) ||
                       f.Color.ToLower().Contains(search.ToLower()) ||
                       f.FuelType.ToString().ToLower().Contains(search.ToLower()) ||
                       f.FuelCapacity.ToLower().Contains(search.ToLower()) ||
                       f.FuelConsumption.ToLower().Contains(search.ToLower()) ||
                       f.Capacity.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Transmission.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Engine.ToLower().Contains(search.ToLower()) ||
                       f.Power.ToLower().Contains(search.ToLower()) ||
                       f.Year.ToLower().Contains(search.ToLower()) ||
                       f.Condition.ToString().ToLower().Contains(search.ToLower()) ||
                       f.Status.ToString().ToLower().Contains(search.ToLower())))
                .ToList();
            LoadUC();
        }

        private void LoadUC()
        {
            foreach (var ford in fords)
            {
                UC_Car ucCar = new UC_Car(ford, CarBrand.Ford);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
            foreach (var mazda in mazda)
            {
                UC_Car ucCar = new UC_Car(mazda, CarBrand.Mazda);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
            foreach (var mercede in mercedes)
            {
                UC_Car ucCar = new UC_Car(mercede, CarBrand.Mercedes);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
            foreach (var vinfast in vinfasts)
            {
                UC_Car ucCar = new UC_Car(vinfast, CarBrand.VinFast);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_Center.Controls.Clear();
            LoadData();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using (CustomMessageBox_CarBrand customMessageBox = new CustomMessageBox_CarBrand())
            {
                if (customMessageBox.ShowDialog() == DialogResult.OK)
                {
                    FCar_Infor fCar_Infor = new FCar_Infor(customMessageBox.SelectedOption);
                    fCar_Infor.ShowDialog();
                }
            }
        }

        private void comboBox_Transmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Transmission.SelectedIndex == 0) // Transmission(All)
            {
                flowLayoutPanel_Center.Controls.Clear();
                LoadData();
            }
            else if (comboBox_Transmission.SelectedIndex == 1) // Manual
            {
                flowLayoutPanel_Center.Controls.Clear();
                LoadData(Transmission.Manual.ToString());
            }
            else if (comboBox_Transmission.SelectedIndex == 2) // Automatic
            {
                flowLayoutPanel_Center.Controls.Clear();
                LoadData(Transmission.Automatic.ToString());
            }
        }

        private void comboBox_FuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_FuelType.SelectedIndex == 0) // FuelType(All)
            {
                flowLayoutPanel_Center.Controls.Clear();
                LoadData();
            }
            else if (comboBox_FuelType.SelectedIndex == 1) // Gas
            {
                flowLayoutPanel_Center.Controls.Clear();
                LoadData(FuelType.Gas.ToString());
            }
            else if (comboBox_FuelType.SelectedIndex == 2) // Diesel
            {
                flowLayoutPanel_Center.Controls.Clear();
                LoadData(FuelType.Diesel.ToString());
            }
            else if (comboBox_FuelType.SelectedIndex == 3) // Electric
            {
                flowLayoutPanel_Center.Controls.Clear();
                LoadData(FuelType.Electric.ToString());
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_Center.Controls.Clear();
            LoadData(textBox_Search.Text);
        }
    }
}
