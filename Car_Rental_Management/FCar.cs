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
            InitializeData();
            InitializeComponent();
        }

        private void InitializeData()
        {
            fords = DataAccess.Fords;
            mazdas = DataAccess.Mazdas;
            mercedes = DataAccess.Mercedeses;
            vinfasts = DataAccess.VinFasts;
        }

        private void FCar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            foreach (var ford in fords)
            {
                UC_Car ucCar = new UC_Car(ford);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
            foreach (var mazda in mazdas)
            {
                UC_Car ucCar = new UC_Car(mazda);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
            foreach (var mercede in mercedes)
            {
                UC_Car ucCar = new UC_Car(mercede);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
            foreach (var vinfast in vinfasts)
            {
                UC_Car ucCar = new UC_Car(vinfast);
                flowLayoutPanel_Center.Controls.Add(ucCar);
            }
        }
    }
}
