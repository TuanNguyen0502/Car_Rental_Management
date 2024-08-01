using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management.Classes
{
    public static class DataAccess
    {
        public static List<Human> Humans = new List<Human>
        {

        };

        public static List<Employee> Employees = new List<Employee>
        {

        };

        public static List<Car> Cars = new List<Car> 
        { 
            
        };

        public static List<Condition> Conditions = new List<Condition>
        {

        };

        public static List<Contract> Contracts = new List<Contract>
        {

        };

        public static List<Customer> Customers = new List<Customer>
        {

        };

        public static List<Ford> Fords = new List<Ford>
        {

        };

        public static List<FuelType> FuelTypes = new List<FuelType>
        {

        };

        public static List<Mazda> Mazdas = new List<Mazda>
        {

        };

        public static List<Mercedes> Mercedeses = new List<Mercedes>
        {

        };

        public static List<Status> Statuses = new List<Status>
        {

        };

        public static List<Transmission> Transmissions = new List<Transmission>
        {

        };

        public static List<VinFast> VinFasts = new List<VinFast>
        {

        };

        public static List<Account> Accounts = new List<Account>
        {
            new Account("admin", "@dmin1", "Emp001"),
        };

    }
}
