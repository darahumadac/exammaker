using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;
using ExamMaker.Presenters.Presenters;
using ExamMaker.Presenters.Views;

namespace ExamMaker.Views.Basic
{
    public partial class ManageUserScreen : Form, IUserListView
    {
        private readonly Repository<User> _userRepository;
        private UserListPresenter _userListPresenter;

        public ManageUserScreen(Repository<User> userRepository)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _userListPresenter = new UserListPresenter(this);
            _userRepository = userRepository;

        }

        private void ManageUserScreen_Load(object sender, EventArgs e)
        {
            _userListPresenter.LoadAllRecords();
        }

        public void LoadAllRecords()
        {
            _userRepository.Revert();

            userListGridView.DataSource = _userRepository.GetAll()
                .OrderBy(u => u.UserId).ToList();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            User newUser = new User("User " + _userRepository.GetAll().Count, 
                ConfigurationManager.AppSettings["defaultPw"], false) 
            {IsActive = true};

            _userRepository.Add(newUser);
            _userRepository.Save();

            LoadAllRecords();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            _userRepository.Save();
        }

        private void changePwBtn_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)userListGridView.SelectedRows[0].DataBoundItem;

            ConfirmPasswordScreen confirmPassword = new ConfirmPasswordScreen(selectedUser, this);
            confirmPassword.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string username = usernameSearch.Text;
            if (string.IsNullOrEmpty(username))
            {
                LoadAllRecords();
            }
            else
            {
                userListGridView.DataSource =
                _userRepository.GetAll()
                .FindAll(u => u.Username.Equals(username))
                .ToList();
            }
            
        }

        private void enableUserManagementButtons(bool enabled)
        {
            changePwBtn.Enabled = enabled;

        }

        private void userListGridView_dataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            bool hasUsers = userListGridView.RowCount > 0;

            enableUserManagementButtons(hasUsers);
        }

    }
}
