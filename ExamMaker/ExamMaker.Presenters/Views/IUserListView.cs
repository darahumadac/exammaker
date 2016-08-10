using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMaker.Presenters.Views
{
    public interface IUserListView
    {
        void LoadAllRecords();
        void Show();
        void Save();
    }
}
