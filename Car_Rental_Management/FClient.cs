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

namespace Car_Rental_Management
{
    public partial class FClient : Form
    {
        private List<Customer> customerList;
        public FClient()
        {
            customerList = DataAccess.Customers;
            InitializeComponent();
        }

        private void FClient_Load(object sender, EventArgs e)
        {
            foreach (var client in customerList)
            {
                UC_Client ucClient = new UC_Client(client);
                flowLayoutPanel_Center.Controls.Add(ucClient);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FCustomer_Information newCustomer = new FCustomer_Information();
            newCustomer.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FClient_Load(sender, e);
        }
    }
}
