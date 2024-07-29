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
        public FClient()
        {
            InitializeComponent();
        }

        private void FClient_Load(object sender, EventArgs e)
        {
            UC_Client client = new UC_Client();
            panel_Content.Controls.Add(client);
        }
    }
}
