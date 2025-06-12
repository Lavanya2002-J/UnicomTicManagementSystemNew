using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Views;
using UnicomTICManagementSystem.Repositories;


namespace UnicomTicManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseManager.InitializeDatabase();
            Application.Run(new LoginForm());
        }
    }
}
