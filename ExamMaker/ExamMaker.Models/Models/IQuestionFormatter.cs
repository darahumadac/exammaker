namespace ExamMaker.Models.Models
{
    public interface IQuestionFormatter
    {
        string GetFormattedQuestion(ExamItem examItem);
    }
}