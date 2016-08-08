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
       

        public MainMenuScreen(AppRepository appRepository)
        {
            InitializeComponent();
            _appRepository = appRepository;
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
    }
}
