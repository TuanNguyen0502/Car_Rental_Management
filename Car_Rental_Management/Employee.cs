using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public class Employee : Human
    {
        public string EmployeeID { get; set; } // Mã nhân viên
        public string Salary { get; set; } // Lương
        public DateTime StartDate { get; set; } // Ngày bắt đầu làm việc

        public Employee(string fullName, DateTime dateOfBirth, string cccd, string address, string phoneNumber, string email, string gender, string employeeID, string salary, DateTime startDate) : base(fullName, dateOfBirth, cccd, address, phoneNumber, email, gender)
        {
            EmployeeID = employeeID;
            Salary = salary;
            StartDate = startDate;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
