using System;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;
using ExamMaker.Presenters.Views;
using ExamMaker.Views.Basic;

namespace ExamMaker.Views
{
    public partial class MainMenuScreen : Form
    {
        private AppRepository _appRepository;
        private readonly LoginScreen _loginScreen;


        public MainMenuScreen(AppRepository appRepository, LoginScreen loginScreen)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _appRepository = appRepository;
            _loginScreen = loginScreen;

            if (Program.LoggedInUser.IsAdmin)
            {
                manageUserBtn.Visible = true;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            welcomeLbl.Text = String.Format("Welcome, {0}", Program.LoggedInUser.Username);
        }

        private void createNewExamBtn_Click(object sender, EventArgs e)
        {
            IExamView newExamScreen = new ExamScreen(_appRepository.ExamRepository,
                _appRepository.ExamItemRepository, _appRepository.OptionRepository);
            newExamScreen.Show();
        }

        private void viewOrEditExamBtn_Click(object sender, EventArgs e)
        {
            IExamListView examListScreen = new ExamListScreen(_appRepository.ExamRepository, 
                _appRepository.ExamItemRepository, _appRepository.OptionRepository);
            examListScreen.Show();
        }

        private void MainMenu_Closed(object sender, FormClosedEventArgs e)
        {
            _loginScreen.Show();
        }

        private void manageUserBtn_Click(object sender, EventArgs e)
        {
            IUserListView manageUserListScreen = new ManageUserScreen(_appRepository.UserRepository);
            manageUserListScreen.Show();
        }
    }
}
