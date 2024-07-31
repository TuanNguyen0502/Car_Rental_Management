using Car_Rental_Management.Classes;
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

        public Mazda(string name, string licenseNumber, string color, FuelType fuelType, string fuelCapacity, string fuelConsumption, int capacity, Transmission transmission, string engine, string power, string year, Condition condition, Status status, bool haveBluetooth, int USBPort)
            : base(name, licenseNumber, color, fuelType, fuelCapacity, fuelConsumption, capacity, transmission, engine, power, year, condition, status)
        {
            HaveBluetooth = haveBluetooth;
            this.USBPort = USBPort;
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
            Console.WriteLine("Số chỗ ngồi: " + Capacity);
            Console.WriteLine("Năm sản xuất: " + Year);
            Console.WriteLine("Tình trạng: " + Condition);
            Console.WriteLine("Có Bluetooth: " + HaveBluetooth);
            Console.WriteLine("Số cổng USB: " + USBPort);
        }
    }
}
