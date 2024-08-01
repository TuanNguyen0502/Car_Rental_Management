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
    public partial class FLogin : Form
    {
        private List<Account> accounts;

        public FLogin()
        {
            InitializeData();
            InitializeComponent();
        }

        private void InitializeData()
        {
            accounts = DataAccess.Accounts;
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = checkBox_ShowPass.Checked ? '\0' : '*';
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            bool isFound = accounts.Any(account => account.Username == textBox_Account.Text && account.Password == textBox_Password.Text);
            if (!isFound)
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Login successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string eid = accounts.Find(account => account.Username == textBox_Account.Text).EID;
                Program.MainFormManager.CurrentForm = new FMain(eid);
            }
        }
    }
}
