using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamMaker.Models.Models;
using Microsoft.Office.Interop.Word;

namespace ExamMaker.Formatters
{
    public class MultipleChoiceFormatter : ItemTypeFormatter
    {
        public MultipleChoiceFormatter(int order, Paragraph examParagraph) 
            : base(order, ItemType.MultipleChoice, "multipleChoiceInstructions", examParagraph)
        {
        }

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
    }
}
