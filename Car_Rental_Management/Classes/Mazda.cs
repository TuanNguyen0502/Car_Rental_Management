using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public class Mazda : Car
    {
        public bool HaveBluetooth { get; set; } // Có Bluetooth hay không
        public int USBPort { get; set; } // Số cổng USB
        
        public Mazda(string name, string color, string licenseNumber, string fuelType, string transmission, string fuelCapacity, string fuelConsumption, string status, string engine, string power, string seats, string year, string condition, bool haveBluetooth, int uSBPort) : base(name, color, licenseNumber, fuelType, transmission, fuelCapacity, fuelConsumption, status, engine, power, seats, year, condition)
        {
            HaveBluetooth = haveBluetooth;
            USBPort = uSBPort;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Mazda");
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
            Console.WriteLine("Số chỗ ngồi: " + Seats);
            Console.WriteLine("Năm sản xuất: " + Year);
            Console.WriteLine("Tình trạng: " + Condition);
            Console.WriteLine("Có Bluetooth: " + HaveBluetooth);
            Console.WriteLine("Số cổng USB: " + USBPort);
        }
    }
}
