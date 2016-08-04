using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamMaker.Models.Models;
using Microsoft.Office.Interop.Word;

namespace ExamMaker.Formatters
{
    public class MultipleChoiceFormatter : ItemTypeFormatter, IQuestionFormatter
    {
        public MultipleChoiceFormatter(Paragraph examParagraph) 
            : base(ItemType.MultipleChoice, "multipleChoiceInstructions", examParagraph)
        {
        }

        public MultipleChoiceFormatter() { }

        public override void FormatAndWriteQuestions(List<ExamItem> examItems)
        {
            base.FormatAndWriteQuestions(examItems);

            int questionIndex;
            string question;

            foreach (var examItem in _itemTypeExamItemsFiltered)
            {
                questionIndex = _itemTypeExamItemsFiltered.IndexOf(examItem) + 1;
                question = String.Format("{0}.  {1}", questionIndex,
                    examItem.Question);

                _examParagraph.Range.Text = question;
                _examParagraph.Range.InsertParagraphAfter();
                
                foreach (var option in examItem.Options)
                {
                    _examParagraph.Range.Text = String.Format("\t{0}. {1}",
                        option.OptionName, option.Description);

                    _examParagraph.Range.InsertParagraphAfter();
                }

                
            }
        }

        public string GetFormattedQuestion(ExamItem examItem)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(examItem.Question);

            foreach (var option in examItem.Options)
            {
                sb.AppendLine(String.Format("\t{0}. {1}", option.OptionName, option.Description));
            }

            return sb.ToString();
        }
    }
}
