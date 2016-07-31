using System;
using System.Collections.Generic;
using ExamMaker.Models.Models;
using Microsoft.Office.Interop.Word;

namespace ExamMaker.Formatters
{
    public class IdentificationFormatter : ItemTypeFormatter
    {
        public IdentificationFormatter(int order, Paragraph examParagraph)
            : base(order, ItemType.Identification, "identificationInstructions", examParagraph)
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
                question = String.Format("________________{0}.  {1}",
                    questionIndex,
                    examItem.Question);

                _examParagraph.Range.Text = question;
                _examParagraph.Range.InsertParagraphAfter();
            }
        }
    }
}