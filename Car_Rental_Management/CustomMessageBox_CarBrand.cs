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
    public partial class CustomMessageBox_CarBrand : Form
    {
        public CarBrand SelectedOption { get; private set; }

        public CustomMessageBox_CarBrand()
        {
            InitializeComponent();
        }

        private void button_Ford_Click(object sender, EventArgs e)
        {
            SelectedOption = CarBrand.Ford;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Mazda_Click(object sender, EventArgs e)
        {
            SelectedOption = CarBrand.Mazda;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Mercedes_Click(object sender, EventArgs e)
        {
            SelectedOption = CarBrand.Mercedes;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Vinfast_Click(object sender, EventArgs e)
        {
            SelectedOption = CarBrand.VinFast;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
