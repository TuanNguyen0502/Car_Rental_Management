using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public class VinFast : Car
    {
        public bool IsElectric { get; set; } // Xe điện

        public VinFast(string name, string licenseNumber, string color, string fuelType, string fuelCapacity, string fuelConsumption, string capacity, string transmission, string engine, string power, string year, string condition, string status, bool isElectric)
            : base(name, licenseNumber, color, fuelType, fuelCapacity, fuelConsumption, capacity, transmission, engine, power, year, condition, status)
        {
            IsElectric = isElectric;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
