using System;
using System.Collections.Generic;
using ExamMaker.Models.Models;
using Microsoft.Office.Interop.Word;

namespace ExamMaker.Formatters
{
    public class FillInTheBlanksFormatter : ItemTypeFormatter
    {
        public FillInTheBlanksFormatter(int order, Paragraph examParagraph)
            : base(order, ItemType.FillInTheBlanks, "fillInTheBlanksInstructions", examParagraph)
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
                    examItem.Question.Replace("_", "________________"));

                _examParagraph.Range.Text = question;
                _examParagraph.Range.InsertParagraphAfter();
            }
        }
    }
}
