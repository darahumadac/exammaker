namespace ExamMaker.Views
{
    public interface IExamView
    {
        void Show();
        void LoadRecord();
        void LoadAndSortExamItems();
        void SetUIDefaults();
        void InitializeUI();
        void LoadExamItemChoices();
    }
}