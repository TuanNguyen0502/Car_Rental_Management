using Car_Rental_Management.Layouts;
using Guna.UI2.WinForms;
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
    public partial class FMain : Form
    {
        private string eid;
        // List of data
        private List<Contract> contracts = new List<Contract>();
        private List<Customer> customers = new List<Customer>();
        private List<Employee> employees = new List<Employee>();
        private List<Ford> fords = new List<Ford>();
        private List<Mazda> mazdas = new List<Mazda>();
        private List<Mercedes> mercedes = new List<Mercedes>();
        private List<VinFast> vinFasts = new List<VinFast>();

        // Current form
        Form currentFormChild;

        public FMain(string eid)
        {
            this.eid = eid;
            InitializeData();
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            pnl_Container.BackgroundImage = null;
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Container.Controls.Add(childForm);
            pnl_Container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 156, b.Location.Y - 30);
            imgSlide.SendToBack();
        }

        private void btnDashboard_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }
        private void InitializeData()
        {
            InitializeEmployees();
        }

        private void InitializeEmployees()
        {
            // Employee 1
            DateTime Tuan_dob = new DateTime(2004, 02, 05);
            DateTime Tuan_startDate = new DateTime(2021, 07, 01);
            Employee Tuan = new Employee("Nguyen Ha Hong Tuan", Tuan_dob, "123456789", "Binh Duong", "0705488458", "nguyenhahongtuan@gmail.com",
                "Nam", "EID001", "5M $", Tuan_startDate);
            // Employee 2
            DateTime Vuong_dob = new DateTime(2004, 02, 06);
            DateTime Vuong_startDate = new DateTime(2021, 07, 01);
            Employee Vuong = new Employee("Nguyen Ha Hong Tuan", Vuong_dob, "123456789", "Binh Duong", "0705488458", "nguyenhahongtuan@gmail.com",
                "Nam", "EID001", "5M $", Vuong_startDate);
            // add to list
            employees.Add(Tuan);
            employees.Add(Vuong);
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCar());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDashboard(), pnl_Container);
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCar(), pnl_Container);
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FContract(), pnl_Container);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FClient(), pnl_Container);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
