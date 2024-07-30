using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public class Mercedes : Car
    {
        public bool IsConvertible { get; set; } // Xe mui trần

        public Mercedes(string name, string licenseNumber, string color, string fuelType, string fuelCapacity, string fuelConsumption, string capacity, string transmission, string engine, string power, string year, string condition, string status, bool isConvertible)
            : base(name, licenseNumber, color, fuelType, fuelCapacity, fuelConsumption, capacity, transmission, engine, power, year, condition, status)
        {
            IsConvertible = isConvertible;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Mercedes: ");
            Console.WriteLine("Tên: " + Name);
            Console.WriteLine("Màu sắc: " + Color);
            Console.WriteLine("Biển số: " + LicenseNumber);
            Console.WriteLine("Loại nhiên liệu: " + FuelType);
            Console.WriteLine("Hộp số: " + Transmission);
            Console.WriteLine("Dung tích bình nhiên liệu: " + FuelCapacity);
            Console.WriteLine("Mức tiêu thụ nhiên liệu: " + FuelConsumption);
            Console.WriteLine("Trạng thái: " + Status);
            Console.WriteLine("Động cơ: " + Engine);
            Console.WriteLine("Công suất: " + Power);
            Console.WriteLine("Số chỗ ngồi: " + Capacity);
            Console.WriteLine("Năm sản xuất: " + Year);
            Console.WriteLine("Tình trạng: " + Condition);
            Console.WriteLine("Mui trần: " + (IsConvertible ? "Có" : "Không"));
        }
    }
}
