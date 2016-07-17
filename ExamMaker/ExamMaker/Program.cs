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

        public static User LoggedInUser = appRepository.UserRepository.GetAll().First();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuScreen(appRepository));
        }
    }
}
