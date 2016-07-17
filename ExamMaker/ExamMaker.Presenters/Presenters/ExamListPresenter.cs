using ExamMaker.Presenters.Views;

namespace ExamMaker.Presenters.Presenters
{
    public class ExamListPresenter
    {
        private readonly IExamListView _view;

        public ExamListPresenter(IExamListView view)
        {
            _view = view;
        }

        public void LoadAllRecords()
        {
            _view.LoadAllRecords();
        }


    }
}