using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamMaker.Models.Models;
using ExamMaker.Presenters.Views;

namespace ExamMaker.Views.Basic
{
    public partial class ConfirmPasswordScreen : Form
    {
        private readonly User _selectedUser;
        private readonly IUserListView _userListView;

        public ConfirmPasswordScreen(User selectedUser, IUserListView userListView)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _selectedUser = selectedUser;
            _userListView = userListView;

            updateMsg.Text = string.Empty;
            updateMsg.Visible = true;
            
        }

        private void ConfirmPasswordScreen_Load(object sender, EventArgs e)
        {
            currentPwText.Focus();
        }

        private void updatePwBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPwText.Text.Equals(_selectedUser.Password)
                    && !string.IsNullOrEmpty(newPasswordTxt.Text)
                    && !string.IsNullOrEmpty(confirmNewPwTxt.Text)
                    && newPasswordTxt.Text.Equals(confirmNewPwTxt.Text))
                {
                    _selectedUser.Password = newPasswordTxt.Text;
                    _userListView.Save();

                    updateMsg.Text = "Password changed";
                    updateMsg.ForeColor = Color.Green;

                    updatePwBtn.Enabled = false;
                }
                else
                {
                    updateMsg.Text = "Passwords do not match";
                    updateMsg.ForeColor = Color.Red;
                }
            }
            catch (DbEntityValidationException ex)
            {
                _userListView.Revert();
                updateMsg.Text = "Password: At least 6 characters";
                updateMsg.ForeColor = Color.Red;
            }
           
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
