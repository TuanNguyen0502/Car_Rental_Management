using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Management.Classes
{
    public class DataAccess
    {
        public List<Human> Humans = new List<Human>
        {

        };

        public List<Employee> Employees = new List<Employee>
        {

        };

        public List<Car> Cars = new List<Car> 
        { 
            
        };

        public List<Condition> Conditions = new List<Condition>
        {

        };

        public List<Contract> Contracts = new List<Contract>
        {

        };

        public List<Customer> Customers = new List<Customer>
        {

        };

        public List<Ford> Fords = new List<Ford>
        {

        };

        public List<FuelType> FuelTypes = new List<FuelType>
        {

        };

        public List<Mazda> Mazdas = new List<Mazda>
        {

        };

        public List<Mercedes> Mercedeses = new List<Mercedes>
        {

        };

        public List<Status> Statuses = new List<Status>
        {

        };

        public List<Transmission> Transmissions = new List<Transmission>
        {

        };

        public List<VinFast> VinFasts = new List<VinFast>
        {

        };

        public List<Account> Accounts = new List<Account>
        {
            new Account("admin", "@dmin1", "Emp001"),
        };

    }
}
