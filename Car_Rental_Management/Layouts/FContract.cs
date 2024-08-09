using Car_Rental_Management.Classes;
using Car_Rental_Management.ControlContent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management.Layouts
{
    public partial class FContract : Form
    {
        private List<Contract> ContractList;
        public FContract()
        {
            InitializeComponent();
            ContractList = DataAccess.Contracts;
        }
        private void FContract_Load(object sender, EventArgs e)
        {
            Initialize();
            LoadAllContracts();
        }

        private void ClearPanel()
        {
            flp_Contents.Controls.Clear();
        }
        private void Initialize()
        {
            flp_Contents.Controls.Clear();
            UC_Contract uc = new UC_Contract();
            flp_Contents.Controls.Add(uc);
        }
        private void LoadAllContracts()
        {
            foreach (Contract item in ContractList)
            {
                UC_Contract uC_Contract = new UC_Contract(item);
                flp_Contents.Controls.Add(uC_Contract);
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Initialize();
            string words = txtSearch.Text.ToLower(); // Chuyển chuỗi tìm kiếm sang chữ thường
            foreach (Contract contract in ContractList)
            {
                if (contract.ContractID.ToLower().Contains(words) ||
                    contract.Customer.FullName.ToLower().Contains(words) ||
                    contract.Car.Name.ToLower().Contains(words))
                {
                    flp_Contents.Controls.Add(new UC_Contract(contract));
                }
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            Initialize();
            LoadAllContracts();
        }

        private void cbb_StatusRent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Initialize();
            string selectedValue = cbb_StatusRent.SelectedItem.ToString();

            foreach (Contract contract in ContractList)
            {
                TimeSpan number_of_hire = contract.DateReturn - contract.DateHire;
                int distance = number_of_hire.Days;

                // Xác định trạng thái thuê xe
                string statusHireCar = (distance > 0) ? "Đang cho thuê" : "Đã trả";

                // Logic lọc theo trạng thái được chọn
                bool isMatch = (statusHireCar == selectedValue);

                if (isMatch)
                {
                    flp_Contents.Controls.Add(new UC_Contract(contract));
                }
            }

        }
    }
}
