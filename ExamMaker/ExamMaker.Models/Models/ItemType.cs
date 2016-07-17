using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExamMaker.Models.Models
{
    public enum ItemType
    {
        FillInTheBlanks = 1,
        MultipleChoice = 2,
        Essay = 3,
        Identification = 4

    }
}