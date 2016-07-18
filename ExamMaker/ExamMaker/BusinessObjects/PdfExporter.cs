using System;
using System.Diagnostics;
using ExamMaker.Models.Models;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ExamMaker.BusinessObjects
{
    public class PdfExporter : Exporter
    {
        public PdfExporter(Exam exam) : base(exam)
        {
        }

        public override void ExportAnswerKey(string filePath)
        {
            string answerKeyTitle = String.Format("Answer Key for Exam {0}", _exam.ExamId);

            PdfDocument answerKeyPdf = new PdfDocument();
            answerKeyPdf.Info.Title =
            answerKeyPdf.Info.Author = Program.LoggedInUser.Username;

            PdfPage answerKeyPage = answerKeyPdf.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(answerKeyPage);

            XFont font = new XFont("Verdana", 12);

            string answerLine = string.Empty;
            int xPostion = 50;
            int yPosition = 50;
            XStringFormat format = new XStringFormat();
            format.Alignment = XStringAlignment.Near;
            format.LineAlignment = XLineAlignment.Near;

            graphics.DrawString(answerKeyTitle, font, XBrushes.Black,
                   new XRect(xPostion, yPosition, answerKeyPage.Width, answerKeyPage.Height), format);
            yPosition += 40;

            foreach (var examItem in _exam.ExamItems)
            {
                answerLine = String.Format("{0}. {1}", examItem.ItemNumber, examItem.Answer);
                graphics.DrawString(answerLine, font, XBrushes.Black,
                   new XRect(xPostion, yPosition, answerKeyPage.Width, answerKeyPage.Height), format);

                yPosition += 20;
            }

            answerKeyPdf.Save(filePath);
            Process.Start(filePath);
        }

        public override void ExportExam(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
