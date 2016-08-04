using System.Collections.Generic;
using System.Configuration;
using Microsoft.Office.Interop.Word;

namespace ExamMaker.Models.Models
{
    public abstract class ItemTypeFormatter
    {
        private readonly ItemType _itemType;
        private readonly string _appSettingKeyInstruction;
        protected Paragraph _examParagraph;
        protected List<ExamItem> _itemTypeExamItemsFiltered;

        protected ItemTypeFormatter(ItemType itemType, 
            string appSettingKeyInstruction, Paragraph examParagraph)
        {
            _itemType = itemType;
            _appSettingKeyInstruction = appSettingKeyInstruction;
            _examParagraph = examParagraph;
        }

        protected ItemTypeFormatter()
        {
        }

        public virtual void FormatAndWriteQuestions( List<ExamItem> examItems)
        {
            _itemTypeExamItemsFiltered = examItems.FindAll(i => i.ItemType == _itemType);
            string instructions = ConfigurationManager.AppSettings[_appSettingKeyInstruction];

            _examParagraph.Range.Text = instructions;
            _examParagraph.Range.InsertParagraphAfter();
            _examParagraph.Range.InsertParagraphAfter();
            
        }

    }
}