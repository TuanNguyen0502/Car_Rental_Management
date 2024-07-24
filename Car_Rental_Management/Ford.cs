using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public class Ford : Car
    {
        public bool IsSoundproof { get; set; } // Có cách âm

        public Ford(string name, string color, string licenseNumber, string fuelType, string transmission, string fuelCapacity, string fuelConsumption, string status, string engine, string power, string seats, string year, string condition, bool isSoundproof) : base(name, color, licenseNumber, fuelType, transmission, fuelCapacity, fuelConsumption, status, engine, power, seats, year, condition)
        {
            IsSoundproof = isSoundproof;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
