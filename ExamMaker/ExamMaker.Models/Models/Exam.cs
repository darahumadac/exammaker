using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamMaker.Models.Models
{
    public class Exam
    {
        [DisplayName("Exam Id")]
        [Key]
        public int ExamId { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessageResourceName = "examNameRequired",
            ErrorMessageResourceType = typeof(ExamMakerResource))]
        [StringLength(60, MinimumLength = 6,
            ErrorMessageResourceName = "examNameLengthError",
            ErrorMessageResourceType = typeof(ExamMakerResource))]
        [DisplayName("Exam Name")]
        public string ExamName { get; set; }

        [DisplayName("Exam Type")]
        public ExamType Type { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessageResourceName = "scheduledExamDateRequired",
            ErrorMessageResourceType = typeof(ExamMakerResource))]
        [DateRange]
        [DisplayName("Exam Date")]
        public DateTime ScheduledExamDate { get; set; }

        [StringLength(16, MinimumLength = 6,
            ErrorMessageResourceName = "examPasswordError",
            ErrorMessageResourceType = typeof(ExamMakerResource))]
        [Browsable(false)]
        public string ExamPassword { get; set; }

        public virtual List<ExamItem> ExamItems { get; set; }

        [Browsable(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

   


    }
}
