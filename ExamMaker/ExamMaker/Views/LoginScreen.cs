using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamMaker.BusinessObjects;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;

namespace ExamMaker.Views
{
    public partial class LoginScreen : Form
    {
        private AppRepository _appRepository;
        private LoginManager _loginManager;
        private User _authenticatedUser;

        public LoginScreen(AppRepository appRepository)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _appRepository = appRepository;
            _loginManager = new LoginManager(appRepository.UserRepository);
            _authenticatedUser = new User();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            _authenticatedUser = _loginManager.Authenticate(usernameTxt.Text, passwordTxt.Text);

            if (_authenticatedUser.UserId > 0)
            {
                Program.LoggedInUser = _authenticatedUser;
                
                errorMsg.Visible = false;

                MainMenuScreen mainMenuScreen = new MainMenuScreen(_appRepository, this);
                mainMenuScreen.Show();
                Hide();
            }
            else
            {
                errorMsg.Visible = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            usernameTxt.Clear();
            passwordTxt.Clear();
            
            usernameTxt.Focus();

            base.OnVisibleChanged(e);
        }
    }
}
