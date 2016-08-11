namespace ExamMaker.Presenters.Views
{
    public interface IExamListView
    {
        void Show();
        void LoadAllRecords();
        void SelectExam(int examIndex);
    }
}