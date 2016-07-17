using System;
using System.ComponentModel.DataAnnotations;

namespace ExamMaker.Models.Models
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute() : base(typeof(DateTime), DateTime.Now.ToString(), DateTime.MaxValue.ToString())
        {
        }
    }
}
