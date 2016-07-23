namespace ExamMaker.Views
{
    public interface IExamView
    {
        void Show();
        void LoadRecord();
        void SortExamItems();
        void SetUIDefaults();
        void InitializeUI();
    }
}