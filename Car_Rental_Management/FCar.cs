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
        private List<Mazda> mazdas;
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
            mazdas = DataAccess.Mazdas;
            mercedes = DataAccess.Mercedeses;
            vinfasts = DataAccess.VinFasts;

            foreach (var ford in fords)
            {
                UC_Car ucCar = new UC_Car(ford, CarBrand.Ford);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
            foreach (var mazda in mazdas)
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
    }
}
