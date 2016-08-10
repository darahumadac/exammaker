using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamMaker.Presenters.Views;

namespace ExamMaker.Presenters.Presenters
{
    public class UserListPresenter
    {
        private readonly IUserListView _userListView;

        public UserListPresenter(IUserListView userListView)
        {
            _userListView = userListView;
        }

        public void LoadAllRecords()
        {
            _userListView.LoadAllRecords();
        }

    }
}
