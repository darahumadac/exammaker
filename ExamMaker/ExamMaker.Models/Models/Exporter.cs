using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMaker.Models.Models
{
    public abstract class Exporter
    {
        protected readonly Exam _exam;

        protected Exporter(Exam exam)
        {
            _exam = exam;
        }

        public abstract void ExportAnswerKey(string filePath);
        public abstract void ExportExam(string filename);
    }
}
