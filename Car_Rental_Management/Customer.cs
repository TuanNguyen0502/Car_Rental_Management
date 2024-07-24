using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public class Customer : Human
    {
        public string CustomerID { get; set; } // Mã khách hàng
        public string DrivingLicense { get; set; } // Bằng lái xe

        public Customer(string fullName, DateTime dateOfBirth, string cccd, string address, string phoneNumber, string email, string gender, string customerID, string drivingLicense) : base(fullName, dateOfBirth, cccd, address, phoneNumber, email, gender)
        {
            CustomerID = customerID;
            DrivingLicense = drivingLicense;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
