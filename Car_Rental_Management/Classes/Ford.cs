using Car_Rental_Management.Classes;
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

        public Ford(string name, string licenseNumber, string color, FuelType fuelType, string fuelCapacity, string fuelConsumption, int capacity, Transmission transmission, string engine, string power, string year, Condition condition, Status status, bool isSoundProof)
            : base(name, licenseNumber, color, fuelType, fuelCapacity, fuelConsumption, capacity, transmission, engine, power, year, condition, status)
        {
            IsSoundproof = isSoundProof;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
