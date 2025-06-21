using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Repositories;
using UNICOMTIC_MANAGEMENT.View;

namespace UNICOMTIC_MANAGEMENT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseManager.CreateTable();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainFrom());

            Application.Run(new ExamForm());
        }
    }
}
