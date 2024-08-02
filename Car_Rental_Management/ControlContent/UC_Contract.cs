using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management.ControlContent
{
    public partial class UC_Contract : UserControl
    {
        private Contract _contract;
        public UC_Contract(Contract contract)
        {
            InitializeComponent();
            _contract = contract;
            SetData();
        }
        public UC_Contract()
        {
            InitializeComponent();
        } 
        private void Initialize()
        {
        }
        private void SetData()
        {
            TimeSpan difference = _contract.DateReturn - DateTime.Now;

            // Lấy số ngày từ đối tượng TimeSpan
            int numberOfDays_Hire = difference.Days;

            this.lbl_DayRent.Text = _contract.DateHire.ToShortDateString();
            this.lbl_Vehicle.Text = _contract.Car.Name;
            this.lbl_Client.Text = _contract.Customer.FullName;
            if(numberOfDays_Hire > 0)
            {
                this.lbl_Status.Text = "Đang cho thuê";
            }
            else
            {
                this.lbl_Status.Text = "Đã trả";
            }
            this.lbl_ReturnDate.Text = _contract.DateReturn.ToShortDateString();
            this.lbl_Price.Text = _contract.RentCost;
            this.lbl_DayNumbers.Text = numberOfDays_Hire.ToString();
            this.lbl_Total.Text = Convert.ToString(numberOfDays_Hire * Convert.ToDouble(_contract.RentCost));
               
        }
    }
}
