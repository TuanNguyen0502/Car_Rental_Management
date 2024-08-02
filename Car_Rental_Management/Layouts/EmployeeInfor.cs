using Car_Rental_Management.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Car_Rental_Management.Layouts
{

    public partial class EmployeeInfor : Form
    {
        List<Employee> employees = DataAccess.Employees;
        private bool _isEmployeeInfor = true;

        public EmployeeInfor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeInfor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            lbErrorName.Visible = false;
            lbErrorCCCD.Visible = false;
            lbErrorSalary.Visible = false;
            string fullName=txtName.Text;
            if (txtName.Text == "")
            {
                lbErrorName.Visible = true;
                lbErrorName.Text = "Vui lòng điền họ và tên";
                _isEmployeeInfor = false;


            }
            

                DateTime dateOfBirth= dayDOB.Value.Date; 

         
            string cccd=txtCCCD.Text;
            if (cccd.Trim().Length!=11) 
            {
                lbErrorCCCD.Visible = true;
                lbErrorCCCD.Text = "Lỗi định dạng";
                _isEmployeeInfor = false;

            } 
            else 
            {
                for(int i=0; i<11; i++)
                {   
                    if (cccd[i]<0 && cccd[i]>9)
                    {
                        lbErrorCCCD.Visible = true;
                        lbErrorCCCD.Text = "Lỗi định dạng";
                        _isEmployeeInfor = false;
                        break;
                    }
                 
                }
                
            }
            

            string address=txtDiachi.Text;
            string phoneNumber=txtSĐT.Text;
            string email=txtEmail.Text;
            string gender="";
            if (radNam.Checked) gender = "Nam";
            else if (radNu.Checked) gender = "Nu";
            else
            {
                lbErrorGender.Visible = true;
                lbErrorGender.Text = "Vui lòng chọn giới tính";
                _isEmployeeInfor = false;
            }
            string employeeID=txtID.Text.Trim();

            int salary=0;

            try
            {
                salary = Convert.ToInt32(txtSalary.Text);
            }
            catch (FormatException)
            {
                lbErrorSalary.Visible = true;
                lbErrorSalary.Text = "Giá trị salary không hợp lệ";
                _isEmployeeInfor = false;
            }
            catch (OverflowException)
            {
                lbErrorSalary.Visible = true;
                lbErrorSalary.Text = "Giá trị salary quá lớn.";
                _isEmployeeInfor = false;
            }

            DateTime startDate=DateTime.Now;
            if(_isEmployeeInfor)
            {
                Employee employee = new Employee(fullName, dateOfBirth, cccd, address, phoneNumber, email, gender, employeeID, salary.ToString(), startDate);
                employees.Add(employee);
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void showListEmployee()
        //{
        //    listEmployee.Items.Clear();
        //    foreach (Employee e in employees)
        //    {
        //        listEmployee.Items.Add(e.FullName);
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            foreach(Employee employee in employees)
            {                
                if (employee.EmployeeID == id) {
                    employees.Remove(employee);
                    break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lbErrorName.Visible = false;
            lbErrorCCCD.Visible = false;
            lbErrorSalary.Visible = false;
            string fullName = txtName.Text;
            if (txtName.Text == "")
            {
                lbErrorName.Visible = true;
                lbErrorName.Text = "Vui lòng điền họ và tên";
                _isEmployeeInfor = false;


            }


            DateTime dateOfBirth = dayDOB.Value.Date;


            string cccd = txtCCCD.Text;
            if (cccd.Trim().Length != 11)
            {
                lbErrorCCCD.Visible = true;
                lbErrorCCCD.Text = "Lỗi định dạng";
                _isEmployeeInfor = false;

            }
            else
            {
                for (int i = 0; i < 11; i++)
                {
                    if (cccd[i] < 0 && cccd[i] > 9)
                    {
                        lbErrorCCCD.Visible = true;
                        lbErrorCCCD.Text = "Lỗi định dạng";
                        _isEmployeeInfor = false;
                        break;
                    }

                }

            }


            string address = txtDiachi.Text;
            string phoneNumber = txtSĐT.Text;
            string email = txtEmail.Text;
            string gender = "";
            if (radNam.Checked) gender = "Nam";
            else if (radNu.Checked) gender = "Nu";
            else
            {
                lbErrorGender.Visible = true;
                lbErrorGender.Text = "Vui lòng chọn giới tính";
                _isEmployeeInfor = false;
            }
            string employeeID = txtID.Text.Trim();

            int salary = 0;

            try
            {
                salary = Convert.ToInt32(txtSalary.Text);
            }
            catch (FormatException)
            {
                lbErrorSalary.Visible = true;
                lbErrorSalary.Text = "Giá trị salary không hợp lệ";
                _isEmployeeInfor = false;
            }
            catch (OverflowException)
            {
                lbErrorSalary.Visible = true;
                lbErrorSalary.Text = "Giá trị salary quá lớn.";
                _isEmployeeInfor = false;
            }

            DateTime startDate = DateTime.Now;
            if (_isEmployeeInfor)
            {
                Employee employee = new Employee(fullName, dateOfBirth, cccd, address, phoneNumber, email, gender, employeeID, salary.ToString(), startDate);

                for (int i = 0; i < employees.Count; i++) {
                    if (employees[i].EmployeeID == employeeID) {
                        employees[i] = employee;
                    }
                }
            }

            
        }
    }
}
