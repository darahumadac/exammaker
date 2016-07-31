using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ExamMaker.Models.Models
{
    public class ExamItem
    {
        [Browsable(false)]
        public int ExamItemId { get; set; }

        public int ExamId { get; set; }

        [DisplayName("Item No.")]
        public int ItemNumber { get; set; }

        [DisplayName("Item Type")]
        public ItemType ItemType { get; set; }

        public string Question { get; set; }

        [Browsable(false)]
        public virtual List<Option> Options { get; set; }

        [Browsable(false)]
        public string Answer
        {
            get;
            set;
        }
    }
}