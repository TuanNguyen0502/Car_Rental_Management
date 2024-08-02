using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public class Contract
    {
        public string ContractID { get; set; } // Mã hợp đồng
        public string Content { get; set; } // Nội dung hợp đồng
        public DateTime DateHire { get; set; } // Ngày thuê
        public DateTime DateReturn { get; set; } // Ngày trả
        public string RentCost { get; set; } // Giá thuê
        public string CustomerID { get; set; } // Mã khách hàng
        public string LicenseNumber { get; set; } // Biển số xe
        public string EmployeeID { get; set; } // Mã nhân viên

        public Customer Customer { get; set; } // Khách hàng
        public Car Car { get; set; } // Xe
        public Employee Employee { get; set; } // Nhân viên

        public Contract(string contractID, string content, DateTime dateHire, DateTime dateReturn, string rentCost, Car car, Customer cus)
        {
            ContractID = contractID;
            Content = content;
            DateHire = dateHire;
            DateReturn = dateReturn;
            RentCost = rentCost;
            Car = car;
            Customer = cus;
        }
    }
}
