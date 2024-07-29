using Car_Rental_Management.Layouts;
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
        Form currentFormChild;
        public FMain()
        {
            InitializeComponent();
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

    }
}
