﻿namespace ExamMaker.Models.Models
{
    public class Option
    {
        public int OptionId { get; set; }
        public string OptionName { get; set; }
        public string Description { get; set; }
        public bool IsCorrectAnswer { get; set; }
    }
}