﻿using Car_Rental_Management.Layouts;
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

        public FMain()
        {
            InitializeComponent();
            InitializeData();
        }

        private void OpenChildForm(Form childForm, Panel panel_Contains)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            panel_Contains.BackgroundImage = null;
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Contains.Controls.Add(childForm);
            panel_Contains.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Contract_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FContract(), pnl_Container);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {

        }
        private void InitializeData()
        {

        }

        private void InitializeEmployees()
        {
            DateTime Tuan_dob = new DateTime(2004, 02, 05);
            DateTime Tuan_startDate = new DateTime(2021, 07, 01);
            Employee Tuan = new Employee("Nguyen Ha Hong Tuan", Tuan_dob, "123456789", "Binh Duong", "0705488458", "nguyenhahongtuan@gmail.com",
                "Nam", "EID001", "5M $", Tuan_startDate);
        }
    }
}
