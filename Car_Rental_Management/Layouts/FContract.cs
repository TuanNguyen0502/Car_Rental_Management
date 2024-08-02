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
            Initialize();
        }
        private void Initialize()
        {
            ContractList = DataAccess.Contracts;
        }
        private void LoadAllContracts()
        {
            foreach (Contract item in ContractList)
            {
                UC_Contract uC_Contract = new UC_Contract(item);
                flp_Contents.Controls.Add(uC_Contract);
            }
        }
    }
}
