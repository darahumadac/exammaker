using System;
using ExamMaker.Models.Models;
using Microsoft.Office.Interop.Word;

namespace ExamMaker.BusinessObjects
{
    public class MsWordExporter : Exporter
    {
        public MsWordExporter(Exam exam) : base(exam)
        {
        }

        public override void ExportAnswerKey(string filePath)
        {
            Application msWordApp = new Application()
            {
                Visible = false
            };

            Document answerKeyDoc = msWordApp.Documents.Add();
            answerKeyDoc.Content.Font.Name = "Times New Roman";
            answerKeyDoc.Content.Paragraphs.Format.LineUnitAfter = 0.5f;

            Paragraph titleParagraph = answerKeyDoc.Paragraphs.Add();
            titleParagraph.Range.Text = String.Format("Answer Key for Exam {0}", _exam.ExamId);
            
            titleParagraph.Range.InsertParagraphAfter();
            titleParagraph.Range.InsertParagraphAfter();

            Paragraph bodyParagraph = answerKeyDoc.Paragraphs.Add();
            foreach (var examItem in _exam.ExamItems)
            {
                bodyParagraph.Range.Text = String.Format("{0}.  {1}", examItem.ItemNumber, examItem.Answer);
                bodyParagraph.Range.InsertParagraphAfter();
            }

            answerKeyDoc.SaveAs(filePath,null,null,_exam.ExamPassword);
            answerKeyDoc.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(answerKeyDoc);
            msWordApp.Quit(true);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(msWordApp);
        }

        public override void ExportExam(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
