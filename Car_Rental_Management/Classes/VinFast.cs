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

        public VinFast(string name, string color, string licenseNumber, string fuelType, string transmission, string fuelCapacity, string fuelConsumption, string status, string engine, string power, string seats, string year, string condition, bool isElectric) : base(name, color, licenseNumber, fuelType, transmission, fuelCapacity, fuelConsumption, status, engine, power, seats, year, condition)
        {
            IsElectric = isElectric;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
