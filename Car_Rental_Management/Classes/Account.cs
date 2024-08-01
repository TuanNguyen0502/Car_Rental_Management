using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management.Classes
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EID { get; set; }

        public Account(string username, string password, string eid)
        {
            Username = username;
            Password = password;
            EID = eid;
        }
    }
}
