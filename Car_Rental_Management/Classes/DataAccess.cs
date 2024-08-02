using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management.Classes
{
    public static class DataAccess
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee("Lê Quang Minh", new DateTime(2002,08,12), "0502434869123", "Bình Định", "0883241576", "minhlq@student.com", "Nam", "Emp001", "12000000", new DateTime(2023, 01, 01)),
            new Employee("Nguyễn Thị Lan", new DateTime(1995, 05, 24), "0502434871234", "Hà Nội", "0987654321", "lannt@student.com", "Nữ", "Emp002", "13000000", new DateTime(2021, 02, 01)),
            new Employee("Trần Văn An", new DateTime(1988, 11, 15), "0502434875678", "TP. Hồ Chí Minh", "0912345678", "antran@student.com", "Nam", "Emp003", "14000000", new DateTime(2019, 03, 01)),
            new Employee("Phạm Thị Bích", new DateTime(1993, 07, 09), "0502434878912", "Đà Nẵng", "0908765432", "bichpt@student.com", "Nữ", "Emp004", "15000000", new DateTime(2020, 04, 01)),
            new Employee("Lê Văn Cường", new DateTime(1985, 12, 20), "0502434882345", "Hải Phòng", "0943216789", "cuonglv@student.com", "Nam", "Emp005", "16000000", new DateTime(2018, 05, 01)),
            new Employee("Đặng Thị Dung", new DateTime(1992, 09, 13), "0502434885678", "Cần Thơ", "0934567890", "dungdt@student.com", "Nữ", "Emp006", "17000000", new DateTime(2022, 06, 01)),
            new Employee("Hoàng Văn Hùng", new DateTime(1990, 02, 11), "0502434889123", "Thanh Hóa", "0923456781", "hungvh@student.com", "Nam", "Emp007", "18000000", new DateTime(2017, 07, 01)),
            new Employee("Vũ Thị Lan Anh", new DateTime(1996, 06, 05), "0502434892345", "Nghệ An", "0912345672", "lananhvt@student.com", "Nữ", "Emp008", "19000000", new DateTime(2021, 08, 01)),
            new Employee("Nguyễn Văn Minh", new DateTime(1994, 03, 22), "0502434895678", "Quảng Nam", "0901234563", "minhnv@student.com", "Nam", "Emp009", "20000000", new DateTime(2016, 09, 01)),
            new Employee("Trần Thị Ngọc", new DateTime(1991, 01, 30), "0502434898912", "Bà Rịa - Vũng Tàu", "0937894561", "ngoctt@student.com", "Nữ", "Emp010", "21000000", new DateTime(2020, 10, 01)),
            new Employee("Phạm Văn Phúc", new DateTime(1989, 04, 16), "0502434801234", "Bắc Ninh", "0945678912", "phucpv@student.com", "Nam", "Emp011", "22000000", new DateTime(2015, 11, 01)),
            new Employee("Đinh Thị Quỳnh", new DateTime(1997, 08, 18), "0502434805678", "Thái Bình", "0912345674", "quynhdt@student.com", "Nữ", "Emp012", "23000000", new DateTime(2019, 12, 01)),
            new Employee("Lê Văn Sơn", new DateTime(1998, 10, 23), "0502434809123", "Nam Định", "0934567812", "sonlv@student.com", "Nam", "Emp013", "24000000", new DateTime(2022, 01, 01)),
            new Employee("Trương Thị Tâm", new DateTime(1995, 11, 29), "0502434812345", "Ninh Bình", "0901234565", "tamt@student.com", "Nữ", "Emp014", "25000000", new DateTime(2018, 02, 01))
        };

        public static List<Contract> Contracts = new List<Contract>
        {

        };

        public static List<Customer> Customers = new List<Customer>
        {
            new Customer("Trần Trung Quân", new DateTime(2001, 09, 09), "052304054203", "TP. Hồ Chí Minh", "0325188392", "quantt@cus.com", "Nam", "Cus011", "B2"),
            new Customer("Nguyễn Thị Hoa", new DateTime(1990, 12, 25), "052304054204", "Hà Nội", "0357891234", "hoant@cus.com", "Nữ", "Cus012", "B1"),
            new Customer("Lê Văn Bảo", new DateTime(1985, 05, 10), "052304054205", "Đà Nẵng", "0389123456", "baolv@cus.com", "Nam", "Cus013", "C3"),
            new Customer("Phạm Thị Hồng", new DateTime(1995, 03, 15), "052304054206", "Bình Dương", "0345678901", "hongpt@cus.com", "Nữ", "Cus014", "B1"),
            new Customer("Trần Văn Cường", new DateTime(1988, 07, 21), "052304054207", "Hải Phòng", "0367890123", "cuongtv@cus.com", "Nam", "Cus015", "A3"),
            new Customer("Đặng Thị Ngọc", new DateTime(1992, 11, 30), "052304054208", "Cần Thơ", "0334567890", "ngocdt@cus.com", "Nữ", "Cus016", "B2"),
            new Customer("Hoàng Văn Minh", new DateTime(1991, 02, 17), "052304054209", "Quảng Ninh", "0378901234", "minhhv@cus.com", "Nam", "Cus017", "C1"),
            new Customer("Nguyễn Thị Lan", new DateTime(1994, 06, 25), "052304054210", "Nghệ An", "0312345678", "lannt@cus.com", "Nữ", "Cus018", "A2"),
            new Customer("Trần Văn Hùng", new DateTime(1987, 08, 11), "052304054211", "Bắc Ninh", "0356789012", "hungtv@cus.com", "Nam", "Cus019", "C3"),
            new Customer("Phạm Văn Hoàng", new DateTime(1993, 04, 09), "052304054212", "Thanh Hóa", "0345678912", "hoangpv@cus.com", "Nam", "Cus020", "B1"),
            new Customer("Vũ Thị Mai", new DateTime(1996, 01, 14), "052304054213", "Hải Dương", "0389012345", "maivt@cus.com", "Nữ", "Cus021", "B1"),
            new Customer("Ngô Văn Nam", new DateTime(1990, 10, 23), "052304054214", "Quảng Nam", "0336789012", "namnv@cus.com", "Nam", "Cus022", "C2"),
            new Customer("Lê Thị Thảo", new DateTime(1998, 05, 18), "052304054215", "Bình Phước", "0313456789", "thaolt@cus.com", "Nữ", "Cus023", "B3"),
            new Customer("Trần Văn Tú", new DateTime(1986, 09, 30), "052304054216", "Bình Định", "0325678901", "tutv@cus.com", "Nam", "Cus024", "A2"),
            new Customer("Phạm Thị Thủy", new DateTime(1992, 02, 28), "052304054217", "Hà Nam", "0347890123", "thuypt@cus.com", "Nữ", "Cus025", "C1"),
            new Customer("Hoàng Văn Phúc", new DateTime(1994, 11, 22), "052304054218", "Bắc Giang", "0358901234", "phuchv@cus.com", "Nam", "Cus026", "B2"),
            new Customer("Nguyễn Văn Tuấn", new DateTime(1989, 06, 16), "052304054219", "Nam Định", "0379012345", "tuannv@cus.com", "Nam", "Cus027", "A3"),
            new Customer("Trần Thị Hạnh", new DateTime(1995, 12, 05), "052304054220", "Hưng Yên", "0337890123", "hanhtt@cus.com", "Nữ", "Cus028", "B1"),
            new Customer("Đỗ Văn Khánh", new DateTime(1991, 04, 20), "052304054221", "Thái Nguyên", "0346789012", "khanhdv@cus.com", "Nam", "Cus029", "C2"),
            new Customer("Phạm Thị Lan Anh", new DateTime(1997, 08, 08), "052304054222", "Hà Tĩnh", "0327890123", "lananhpt@cus.com", "Nữ", "Cus030", "B1")
        };

        public static List<Ford> Fords = new List<Ford>
        {
            // Ford
            new Ford("Ford 1", "72S2-7383", "Red and black", Classes.FuelType.Diesel, "500 L", "100 Km/L", 7, Classes.Transmission.Automatic, "V8", "1000 HP", "2024", Classes.Condition.New, Classes.Status.Available, true),

            new Ford("Ford 2", "83J1-8392", "Blue", Classes.FuelType.Gas, "400 L", "80 Km/L", 5, Classes.Transmission.Manual, "V6", "800 HP", "2022", Classes.Condition.Old, Classes.Status.Rented, false),

            new Ford("Ford 3", "92K3-0294", "White", Classes.FuelType.Electric, "300 L", "200 Km/L", 4, Classes.Transmission.Automatic, "Electric", "500 HP", "2023", Classes.Condition.Repairing, Classes.Status.Maintenance, true),

            new Ford("Ford 4", "01L4-1029", "Green", Classes.FuelType.Hybrid, "350 L", "150 Km/L", 6, Classes.Transmission.Manual, "Hybrid", "750 HP", "2021", Classes.Condition.Breakdown, Classes.Status.Available, false),

            new Ford("Ford 5", "65M5-3847", "Black", Classes.FuelType.Hydrogen, "450 L", "120 Km/L", 8, Classes.Transmission.Automatic, "V10", "1100 HP", "2020", Classes.Condition.Else, Classes.Status.Rented, true),
        };

        public static List<Mazda> Mazdas = new List<Mazda>
        {
            // Mazda
            new Mazda("Mazda 1", "21A1-2345", "Red", Classes.FuelType.Gas, "450 L", "90 Km/L", 5, Classes.Transmission.Automatic, "I4", "150 HP", "2022", Classes.Condition.New, Classes.Status.Available, true, 2),

            new Mazda("Mazda 2", "32B2-3456", "Blue", Classes.FuelType.Diesel, "500 L", "85 Km/L", 5, Classes.Transmission.Manual, "V6", "180 HP", "2021", Classes.Condition.Old, Classes.Status.Rented, false, 1),

            new Mazda("Mazda 3", "43C3-4567", "White", Classes.FuelType.Electric, "300 L", "200 Km/L", 4, Classes.Transmission.Automatic, "Electric", "200 HP", "2023", Classes.Condition.Repairing, Classes.Status.Maintenance, true, 3),

            new Mazda("Mazda 4", "54D4-5678", "Black", Classes.FuelType.Hybrid, "350 L", "120 Km/L", 6, Classes.Transmission.Manual, "Hybrid", "220 HP", "2020", Classes.Condition.Breakdown, Classes.Status.Available, false, 2),

            new Mazda("Mazda 5", "65E5-6789", "Silver", Classes.FuelType.Hydrogen, "400 L", "100 Km/L", 5, Classes.Transmission.Automatic, "Hydrogen", "170 HP", "2024", Classes.Condition.Else, Classes.Status.Rented, true, 4),
        };

        public static List<Mercedes> Mercedeses = new List<Mercedes>
        {
            // Mercedes
            new Mercedes("Mercedes 1", "12F1-1234", "Black", Classes.FuelType.Gas, "600 L", "80 Km/L", 4, Classes.Transmission.Automatic, "V8", "500 HP", "2022", Classes.Condition.New, Classes.Status.Available, true),

            new Mercedes("Mercedes 2", "23G2-2345", "White", Classes.FuelType.Diesel, "700 L", "70 Km/L", 5, Classes.Transmission.Manual, "V6", "400 HP", "2021", Classes.Condition.Old, Classes.Status.Rented, false),

            new Mercedes("Mercedes 3", "34H3-3456", "Silver", Classes.FuelType.Hybrid, "550 L", "90 Km/L", 4, Classes.Transmission.Automatic, "Hybrid", "450 HP", "2023", Classes.Condition.Repairing, Classes.Status.Maintenance, true),

            new Mercedes("Mercedes 4", "45I4-4567", "Blue", Classes.FuelType.Electric, "500 L", "100 Km/L", 4, Classes.Transmission.Manual, "Electric", "300 HP", "2020", Classes.Condition.Breakdown, Classes.Status.Available, false),

            new Mercedes("Mercedes 5", "56J5-5678", "Red", Classes.FuelType.Hydrogen, "650 L", "75 Km/L", 4, Classes.Transmission.Automatic, "Hydrogen", "350 HP", "2024", Classes.Condition.Else, Classes.Status.Rented, true),
        };

        public static List<Status> Statuses = new List<Status>
        {

        };

        public static List<VinFast> VinFasts = new List<VinFast>
        {
            // VinFast
            new VinFast("VinFast 1", "78K1-7890", "Green", Classes.FuelType.Electric, "400 L", "150 Km/L", 5, Classes.Transmission.Automatic, "Electric", "200 HP", "2022", Classes.Condition.New, Classes.Status.Available, true),

            new VinFast("VinFast 2", "89L2-8901", "Blue", Classes.FuelType.Gas, "500 L", "100 Km/L", 7, Classes.Transmission.Manual, "V6", "300 HP", "2021", Classes.Condition.Old, Classes.Status.Rented, false),

            new VinFast("VinFast 3", "90M3-9012", "Red", Classes.FuelType.Diesel, "550 L", "90 Km/L", 6, Classes.Transmission.Automatic, "V8", "350 HP", "2023", Classes.Condition.Repairing, Classes.Status.Maintenance, false),

            new VinFast("VinFast 4", "01N4-0123", "White", Classes.FuelType.Hybrid, "450 L", "120 Km/L", 5, Classes.Transmission.Manual, "Hybrid", "250 HP", "2020", Classes.Condition.Breakdown, Classes.Status.Available, false),

            new VinFast("VinFast 5", "12O5-1234", "Silver", Classes.FuelType.Hydrogen, "600 L", "110 Km/L", 4, Classes.Transmission.Automatic, "Hydrogen", "400 HP", "2024", Classes.Condition.Else, Classes.Status.Rented, false),
        };

        public static List<Car> GetAllCars()
        {
            List<Car> Cars = new List<Car>();
            Cars.AddRange(Fords.Cast<Car>());
            Cars.AddRange(Mazdas.Cast<Car>());
            Cars.AddRange(Mercedeses.Cast<Car>());
            Cars.AddRange(VinFasts.Cast<Car>());
            return Cars;
        }
        public static List<Account> Accounts = new List<Account>
        {
            new Account("admin", "admin", "Emp001"),
        };

    }
}
