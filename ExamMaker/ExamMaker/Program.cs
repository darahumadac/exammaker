using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;
using ExamMaker.Views;

namespace ExamMaker
{
    public static class Program
    {
        private static IAppDataSource datasource = new SqlRepository();
        private static AppRepository appRepository = new AppRepository(datasource);
        //TODO: Add login screen
        //TODO: Add manage user feature
        public static User LoggedInUser;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen(appRepository));
        }
    }
}
