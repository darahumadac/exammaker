using ExamMaker.Models.Models;

namespace ExamMaker.Formatters
{
    public static class QuestionFormatter
    {
        public static string GetFormattedQuestion(ExamItem item)
        {
            IQuestionFormatter formatter = new EssayFormatter();
            switch (item.ItemType)
            {
                    case ItemType.FillInTheBlanks:
                        formatter = new FillInTheBlanksFormatter();
                    break;
                    case ItemType.Identification:
                        formatter = new IdentificationFormatter();
                    break;
                    case ItemType.MultipleChoice:
                        formatter = new MultipleChoiceFormatter();
                    break;

            }
           
            return formatter.GetFormattedQuestion(item);
        }
    }
}