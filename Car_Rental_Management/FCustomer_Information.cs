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
        public FCustomer_Information()
        {
            InitializeComponent();
            if (txt_FullName.Text == "")
                btn_Edit.Hide();
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
        }
        public void Inaccessible()
        {
            txt_FullName.Enabled = false;
            txtPhone.Enabled = false;
            txt_Address.Enabled = false;
            txt_CCCD.Enabled = false;
            txt_Email.Enabled = false;
        }
        public void Accessible()
        {
            txt_FullName.Enabled = true;
            txtPhone.Enabled = true;
            txt_Address.Enabled = true;
            txt_CCCD.Enabled = true;
            txt_Email.Enabled = true;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
