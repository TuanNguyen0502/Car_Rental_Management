using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public abstract class Car
    {
        public string Name { get; set; } // Tên
        public string Color { get; set; } // Màu sắc
        public string LicenseNumber { get; set; } // Biển số
        public string FuelType { get; set; } // Loại nhiên liệu (Xăng, Dầu, ...)
        public string Transmission { get; set; } // Hộp số (Số tự động, Số sàn, ...)
        public string FuelCapacity { get; set; } // Dung tích bình nhiên liệu
        public string FuelConsumption { get; set; } // Mức tiêu thụ nhiên liệu
        public string Status { get; set; } // Trạng thái (Đã cho thuê, Chưa cho thuê, ...)
        public string Engine { get; set; } // Động cơ
        public string Power { get; set; } // Công suất
        public string Capacity { get; set; } // Số chỗ ngồi
        public string Year { get; set; } // Năm sản xuất
        public string Condition { get; set; } // Tình trạng (Mới, Cũ, ...)

        public Car(string name, string licenseNumber, string color, string fuelType, string fuelCapacity, string fuelConsumption, string capacity, string transmission, string engine, string power, string year, string condition, string status)
        {
            Name = name;
            Color = color;
            LicenseNumber = licenseNumber;
            FuelType = fuelType;
            Transmission = transmission;
            FuelCapacity = fuelCapacity;
            FuelConsumption = fuelConsumption;
            Status = status;
            Engine = engine;
            Power = power;
            Capacity = capacity;
            Year = year;
            Condition = condition;
        }

        public abstract void ShowInfo();
    }
}
