using System;
using System.Configuration;
using System.IO;
using ExamMaker.Models.Models;
using Microsoft.Office.Interop.Word;
using Ref = System.Reflection;
using WF =  System.Windows.Forms;

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
            setFontAndAfterSpacingToDefault(answerKeyDoc);
            
            insertTitleParagraph(answerKeyDoc, String.Format("Answer Key for Exam {0}", _exam.ExamId));

            Paragraph bodyParagraph = answerKeyDoc.Paragraphs.Add();
            foreach (var examItem in _exam.ExamItems)
            {
                bodyParagraph.Range.Text = String.Format("{0}.  {1}", examItem.ItemNumber, examItem.Answer);
                insertParagraph(1, bodyParagraph);
            }

            saveAndCloseDocument(answerKeyDoc, filePath, msWordApp);
        }

        private void setFontAndAfterSpacingToDefault(Document document)
        {
            document.Content.Font.Name = "Times New Roman";
            document.Content.Paragraphs.Format.LineUnitAfter = 0.5f;
        }

        private void insertParagraph(int paragraphCount, Paragraph paragraph)
        {
            for (int i = 0; i < paragraphCount; i++)
            {
                paragraph.Range.InsertParagraphAfter();
            }
        }

        private void insertTitleParagraph(Document document, string title)
        {
            Paragraph titleParagraph = document.Paragraphs.Add();
            titleParagraph.Range.Text = title;

            insertParagraph(2, titleParagraph);
        }

        private void saveAndCloseDocument(Document document, string filepath, Application msWordApp)
        {
            if (string.IsNullOrEmpty(_exam.ExamPassword))
            {
                document.SaveAs(filepath);
            }
            else
            {
                document.SaveAs(filepath, null, null, _exam.ExamPassword);
            }

            document.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(document);
            msWordApp.Quit(true);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(msWordApp);
        }

        public override void ExportExam(string filePath)
        {
            Application msWordApp = new Application()
            {
                Visible = false
            };

            string templatePath = Path.Combine(Path.GetDirectoryName(WF.Application.ExecutablePath),
                ConfigurationManager.AppSettings["examTemplatePath"]);

            Document examDocument = msWordApp.Documents.Add(templatePath);
            setFontAndAfterSpacingToDefault(examDocument);

            string[] examDocumentTemplateFields = {"SubjectTemplate", "ExamTypeTemplate"};
            string[] examDocumentTemplateValue = {_exam.ExamName, _exam.Type.ToString()};

            insertTitleParagraph(examDocument, examDocumentTemplateFields, examDocumentTemplateValue);

            string[] examTypeTemplates = getExamItemTemplateFilenames();

            saveAndCloseDocument(examDocument, filePath, msWordApp);

        }

        private void insertTitleParagraph(Document document, string[] templateFieldNames, string[] templateFieldValues)
        {
            string oldValue = string.Empty;
            string newValue = string.Empty;

            Find headerRange =
                    document.Sections[1].Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Find;

            for (int i = 0; i < templateFieldNames.Length; i++)
            {
                oldValue = String.Format("[{0}]", templateFieldNames[i]);
                newValue = templateFieldValues[i];

                headerRange.Text = oldValue;
                headerRange.Replacement.Text = newValue;

                headerRange.Execute(Replace: WdReplace.wdReplaceAll);
            }
        }

        private string[] getExamItemTemplateFilenames()
        {
            string[] examItemTypes = Enum.GetNames(typeof (ItemType));
            int examItemTypeCount = examItemTypes.Length;

            string[] examItemTypeTemplateFilenames = new string[examItemTypeCount];

            for (int i = 0; i < examItemTypeCount; i++)
            {
                examItemTypeTemplateFilenames[i] = String.Format("Templates\\{0}Template.docx", examItemTypes[i]);
            }

            return examItemTypeTemplateFilenames;
        }


    }
}
