using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamMaker.Models.Models;
using Microsoft.Office.Interop.Word;

namespace ExamMaker.Formatters
{
    public class EssayFormatter : ItemTypeFormatter
    {
        public EssayFormatter(int order, Paragraph examParagraph) :
            base(order, ItemType.Essay, "essayInstructions", examParagraph)
        {
        }

        public override void FormatAndWriteQuestions(List<ExamItem> examItems)
        {
            base.FormatAndWriteQuestions(examItems);
            bool isNumbered = _itemTypeExamItemsFiltered.Count > 1;

            if (isNumbered)
            {   
                int questionIndex;

                foreach (var examItem in _itemTypeExamItemsFiltered)
                {
                    questionIndex = _itemTypeExamItemsFiltered.IndexOf(examItem) + 1;
                    _examParagraph.Range.Text = String.Format("{0}.  {1}",
                        questionIndex,
                        examItem.Question);

                    for (int i = 0; i < 10; i++)
                    {
                        _examParagraph.Range.InsertParagraphAfter();
                    }

                }
            }
            else
            {
                foreach (var examItem in _itemTypeExamItemsFiltered)
                {
                    _examParagraph.Range.Text = examItem.Question;

                    for (int i = 0; i < 10; i++)
                    {
                        _examParagraph.Range.InsertParagraphAfter();
                    }

                }
            }

            

        }
    }
}
