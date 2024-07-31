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
        private List<Ford> fords = new List<Ford>();
        private List<Mazda> mazdas = new List<Mazda>();
        private List<Mercedes> mercedes = new List<Mercedes>();
        private List<VinFast> vinfasts = new List<VinFast>();

        public FCar()
        {
            InitializeData();
            InitializeComponent();
        }

        private void InitializeData()
        {
            // Ford
            fords.Add(new Ford("Ford 1", "72S2-7383", "Red and black", Classes.FuelType.Diesel, "500 L", "100 Km/L", 7, Classes.Transmission.Automatic, "V8", "1000 HP", "2024", Classes.Condition.New, Classes.Status.Available, true));

            fords.Add(new Ford("Ford 2", "83J1-8392", "Blue", Classes.FuelType.Gas, "400 L", "80 Km/L", 5, Classes.Transmission.Manual, "V6", "800 HP", "2022", Classes.Condition.Old, Classes.Status.Rented, false));

            fords.Add(new Ford("Ford 3", "92K3-0294", "White", Classes.FuelType.Electric, "300 L", "200 Km/L", 4, Classes.Transmission.Automatic, "Electric", "500 HP", "2023", Classes.Condition.Repairing, Classes.Status.Maintenance, true));

            fords.Add(new Ford("Ford 4", "01L4-1029", "Green", Classes.FuelType.Hybrid, "350 L", "150 Km/L", 6, Classes.Transmission.Manual, "Hybrid", "750 HP", "2021", Classes.Condition.Breakdown, Classes.Status.Available, false));

            fords.Add(new Ford("Ford 5", "65M5-3847", "Black", Classes.FuelType.Hydrogen, "450 L", "120 Km/L", 8, Classes.Transmission.Automatic, "V10", "1100 HP", "2020", Classes.Condition.Else, Classes.Status.Rented, true));

            // Mazda
            mazdas.Add(new Mazda("Mazda 1", "21A1-2345", "Red", Classes.FuelType.Gas, "450 L", "90 Km/L", 5, Classes.Transmission.Automatic, "I4", "150 HP", "2022", Classes.Condition.New, Classes.Status.Available, true, 2));

            mazdas.Add(new Mazda("Mazda 2", "32B2-3456", "Blue", Classes.FuelType.Diesel, "500 L", "85 Km/L", 5, Classes.Transmission.Manual, "V6", "180 HP", "2021", Classes.Condition.Old, Classes.Status.Rented, false, 1));

            mazdas.Add(new Mazda("Mazda 3", "43C3-4567", "White", Classes.FuelType.Electric, "300 L", "200 Km/L", 4, Classes.Transmission.Automatic, "Electric", "200 HP", "2023", Classes.Condition.Repairing, Classes.Status.Maintenance, true, 3));

            mazdas.Add(new Mazda("Mazda 4", "54D4-5678", "Black", Classes.FuelType.Hybrid, "350 L", "120 Km/L", 6, Classes.Transmission.Manual, "Hybrid", "220 HP", "2020", Classes.Condition.Breakdown, Classes.Status.Available, false, 2));

            mazdas.Add(new Mazda("Mazda 5", "65E5-6789", "Silver", Classes.FuelType.Hydrogen, "400 L", "100 Km/L", 5, Classes.Transmission.Automatic, "Hydrogen", "170 HP", "2024", Classes.Condition.Else, Classes.Status.Rented, true, 4));

            // Mercedes
            mercedes.Add(new Mercedes("Mercedes 1", "12F1-1234", "Black", Classes.FuelType.Gas, "600 L", "80 Km/L", 4, Classes.Transmission.Automatic, "V8", "500 HP", "2022", Classes.Condition.New, Classes.Status.Available, true));

            mercedes.Add(new Mercedes("Mercedes 2", "23G2-2345", "White", Classes.FuelType.Diesel, "700 L", "70 Km/L", 5, Classes.Transmission.Manual, "V6", "400 HP", "2021", Classes.Condition.Old, Classes.Status.Rented, false));

            mercedes.Add(new Mercedes("Mercedes 3", "34H3-3456", "Silver", Classes.FuelType.Hybrid, "550 L", "90 Km/L", 4, Classes.Transmission.Automatic, "Hybrid", "450 HP", "2023", Classes.Condition.Repairing, Classes.Status.Maintenance, true));

            mercedes.Add(new Mercedes("Mercedes 4", "45I4-4567", "Blue", Classes.FuelType.Electric, "500 L", "100 Km/L", 4, Classes.Transmission.Manual, "Electric", "300 HP", "2020", Classes.Condition.Breakdown, Classes.Status.Available, false));

            mercedes.Add(new Mercedes("Mercedes 5", "56J5-5678", "Red", Classes.FuelType.Hydrogen, "650 L", "75 Km/L", 4, Classes.Transmission.Automatic, "Hydrogen", "350 HP", "2024", Classes.Condition.Else, Classes.Status.Rented, true));

            // VinFast
            vinfasts.Add(new VinFast("VinFast 1", "78K1-7890", "Green", Classes.FuelType.Electric, "400 L", "150 Km/L", 5, Classes.Transmission.Automatic, "Electric", "200 HP", "2022", Classes.Condition.New, Classes.Status.Available, true));

            vinfasts.Add(new VinFast("VinFast 2", "89L2-8901", "Blue", Classes.FuelType.Gas, "500 L", "100 Km/L", 7, Classes.Transmission.Manual, "V6", "300 HP", "2021", Classes.Condition.Old, Classes.Status.Rented, false));

            vinfasts.Add(new VinFast("VinFast 3", "90M3-9012", "Red", Classes.FuelType.Diesel, "550 L", "90 Km/L", 6, Classes.Transmission.Automatic, "V8", "350 HP", "2023", Classes.Condition.Repairing, Classes.Status.Maintenance, false));

            vinfasts.Add(new VinFast("VinFast 4", "01N4-0123", "White", Classes.FuelType.Hybrid, "450 L", "120 Km/L", 5, Classes.Transmission.Manual, "Hybrid", "250 HP", "2020", Classes.Condition.Breakdown, Classes.Status.Available, false));

            vinfasts.Add(new VinFast("VinFast 5", "12O5-1234", "Silver", Classes.FuelType.Hydrogen, "600 L", "110 Km/L", 4, Classes.Transmission.Automatic, "Hydrogen", "400 HP", "2024", Classes.Condition.Else, Classes.Status.Rented, false));
        }

        private void FCar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

        }
    }
}
