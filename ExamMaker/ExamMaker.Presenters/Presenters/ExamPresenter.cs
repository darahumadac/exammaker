using ExamMaker.Views;

namespace ExamMaker.Presenters.Presenters
{
    public class ExamPresenter
    {
        private readonly IExamView _examView;

        public ExamPresenter(IExamView examView)
        {
            _examView = examView;
        }

        public void LoadRecord()
        {
            _examView.LoadRecord();
        }
    }
}