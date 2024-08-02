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
    public partial class FDashboard : Form
    {
        List<Car> cars = DataAccess.GetAllCars();
        public FDashboard()
        {
            InitializeComponent();
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            lblnumVehicles.Text = getNumOfVehicles().ToString();
            lblnumVehiclesRented.Text = getNumOfRentedVehicles().ToString();
            lblnumVehiclesAvailable.Text = getNumOfAvailableVehicles().ToString();
            lblnumVehiclesIssued.Text = getNumOfMaintenanceVehicles().ToString();
        }

        public int getNumOfVehicles()
        {
            return cars.Count;
        }
        public int getNumOfRentedVehicles()
        {
            return cars.Count(c => c.Status == Status.Rented);
        }

        public int getNumOfAvailableVehicles()
        {
            return cars.Count(c => c.Status == Status.Available);
        }

        public int getNumOfMaintenanceVehicles()
        {
            return cars.Count(c => c.Status == Status.Maintenance);
        }
    }
}
