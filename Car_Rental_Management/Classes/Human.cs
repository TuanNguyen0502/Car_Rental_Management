using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management
{
    public abstract class Human
    {
        public string FullName { get; set; } // Họ tên
        public DateTime DateOfBirth { get; set; } // Ngày sinh
        public string CCCD { get; set; } // Số CCCD
        public string Address { get; set; } // Địa chỉ
        public string PhoneNumber { get; set; } // Số điện thoại
        public string Email { get; set; } // Email
        public string Gender { get; set; } // Giới tính

        public Human(string fullName, DateTime dateOfBirth, string cccd, string address, string phoneNumber, string email, string gender)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            CCCD = cccd;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Gender = gender;
        }

        public abstract void ShowInfo();
    }
}
