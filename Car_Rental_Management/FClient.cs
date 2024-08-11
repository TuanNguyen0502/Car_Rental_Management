using Car_Rental_Management.Classes;
using Car_Rental_Management.ControlContent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            flowLayoutPanel_Center.Controls.Clear();
            foreach (var client in customerList)
            {
                UC_Client ucClient = new UC_Client(client);
                flowLayoutPanel_Center.Controls.Add(ucClient);
            }
        }
        #region Các sự kiện của button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FCustomer_Information newCustomer = new FCustomer_Information();
            newCustomer.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FClient_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = customerList.Where(t =>
        (t.FullName?.Contains(txtSearch.Text) ?? false) ||
        (t.DrivingLicense?.Contains(txtSearch.Text) ?? false) ||
        (t.Address?.Contains(txtSearch.Text) ?? false) ||
        (t.CCCD?.Contains(txtSearch.Text) ?? false) ||
        (t.Email?.Contains(txtSearch.Text) ?? false) ||
        (t.PhoneNumber?.Contains(txtSearch.Text) ?? false)
    ).ToList();
            flowLayoutPanel_Center.Controls.Clear();
            foreach (var client in search)
            {
                UC_Client ucClient = new UC_Client(client);
                flowLayoutPanel_Center.Controls.Add(ucClient);
            }
        }

        private void cbb_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Sex.Text != "Gender(All)")
            {
                var search = customerList.Where(t =>
        (t.Gender?.Contains(cbb_Sex.Text) ?? false)).ToList();
                flowLayoutPanel_Center.Controls.Clear();
                foreach (var client in search)
                {
                    UC_Client ucClient = new UC_Client(client);
                    flowLayoutPanel_Center.Controls.Add(ucClient);
                }
            }
            else FClient_Load(sender, e);
        }
        #endregion
    }
}
