using Car_Rental_Management.ControlContent;
using Car_Rental_Management.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management
{
    internal static class Program
    {
        private static MainFormManager mainFormManager;

        public static MainFormManager MainFormManager
        {
            get { return mainFormManager; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //mainFormManager = new MainFormManager();
            //mainFormManager.CurrentForm = new FLogin();
            //Application.Run(mainFormManager);
            Application.Run(new EmployeeInfor());
        }
    }
}
