using Car_Rental_Management.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management
{
    public partial class FCustomer_Information : Form
    {
        Customer _customer = null;
        private List<Customer> customerList;
        public FCustomer_Information()
        {
            InitializeComponent();
            btn_Edit.Hide();
            btnOK.Show();
            customerList = DataAccess.Customers;
        }
        public FCustomer_Information(Customer customer)
        {
            InitializeComponent();
            btn_Edit.Show();
            btnOK.Hide();
            customerList = DataAccess.Customers;
            _customer = customer;
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FCustomer_Information_Load(object sender, EventArgs e)
        {
            if(_customer != null)
            {
                Print();
                Inaccessible();
            }
        }
        public void Print()
        {
            txt_FullName.Text = _customer.FullName;
            txtPhone.Text = _customer.PhoneNumber;
            txt_Address.Text = _customer.Address;
            txt_CCCD.Text = _customer.CCCD;
            txt_Email.Text = _customer.Email;
            txt_DrivingLicense.Text = _customer.DrivingLicense;
            cbx_Sex.Text = _customer.Gender;
            dtp_Birthday.Value = _customer.DateOfBirth;
        }
        public void Inaccessible()
        {
            txt_FullName.Enabled = false;
            txtPhone.Enabled = false;
            txt_Address.Enabled = false;
            txt_CCCD.Enabled = false;
            txt_Email.Enabled = false;
            txt_DrivingLicense.Enabled = false;
            cbx_Sex.Enabled = false;
            dtp_Birthday.Enabled = false;
        }
        public void Accessible()
        {
            txt_FullName.Enabled = true;
            txtPhone.Enabled = true;
            txt_Address.Enabled = true;
            txt_CCCD.Enabled = true;
            txt_Email.Enabled = true;
            txt_DrivingLicense.Enabled = true;
            cbx_Sex.Enabled = true;
            dtp_Birthday.Enabled = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            btnOK.Show();
            btn_Edit.Hide();
            Accessible();
        }
        public bool checkValid()
        {
            bool check = true;
            if (txt_FullName.Text == "" || txt_Email.Text == "" || txt_CCCD.Text == "" || txt_Address.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cá nhân của khách hàng");
                check = false;
            }
            int year = 0;
            if (Int32.TryParse(DateTime.Now.Year.ToString(), out year))
            {
                if ((year - dtp_Birthday.Value.Year) < 18)
                {
                    MessageBox.Show("Khách hàng chưa đủ 18 tuổi.");
                    check = false;
                }
            }
            return check;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {            
            if (checkValid()&&_customer==null)
            {
                int nextID = 1;
                var lastCus = customerList != null && customerList.Any()
                              ? (from cus in customerList orderby cus.CustomerID descending select cus).FirstOrDefault()
                              : null;

                if (lastCus != null)
                {
                    nextID = int.Parse(lastCus.CustomerID.Substring((lastCus.CustomerID.ToString()).Length - 3)) + 1;

                }
                string idCustomer = "Cus" + nextID.ToString().PadLeft(3, '0');
                Customer customer = new Customer(
                    txt_FullName.Text,
                    dtp_Birthday.Value,
                    txt_CCCD.Text,
                    txt_Address.Text,
                    txtPhone.Text,
                    txt_Email.Text,
                    this.cbx_Sex.Text,
                    idCustomer,
                    txt_DrivingLicense.Text
                );

                if (customerList != null)
                {
                    customerList.Add(customer);
                }
                else
                {
                    customerList = new List<Customer> { customer };
                }
            }
            else if(checkValid())
            {
                var customer = customerList.SingleOrDefault(t => t.CustomerID ==_customer.CustomerID);
                if (customer != null)
                    customerList.Remove(customer);
                Customer customer1 = new Customer(
                    txt_FullName.Text,
                    dtp_Birthday.Value,
                    txt_CCCD.Text,
                    txt_Address.Text,
                    txtPhone.Text,
                    txt_Email.Text,
                    this.cbx_Sex.Text,
                    _customer.CustomerID,
                    txt_DrivingLicense.Text
                );

                if (customerList != null)
                {
                    customerList.Add(customer1);
                }
                else
                {
                    customerList = new List<Customer> { customer1 };
                }
            }
            btnOK.Hide();
            btn_Edit.Show();
            Inaccessible();
        }
    }
}
