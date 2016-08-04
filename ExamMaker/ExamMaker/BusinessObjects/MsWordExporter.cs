using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using ExamMaker.Formatters;
using ExamMaker.Models.Models;
using Microsoft.Office.Interop.Word;
using System.Reflection;
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
            string answer;
            foreach (var examItem in _exam.ExamItems.OrderBy(i => i.ItemNumber))
            {
                answer = !string.IsNullOrEmpty(examItem.Answer) ? examItem.Answer : "None";

                bodyParagraph.Range.Text = String.Format("{0}.[{1}] - {2}", 
                    examItem.ItemNumber, 
                    examItem.ItemType,
                    answer);

                insertParagraph(1, bodyParagraph);
            }

            saveAndCloseDocument(answerKeyDoc, filePath, msWordApp);
        }

        private void setFontAndAfterSpacingToDefault(Document document)
        {
            document.Content.Font.Name = "Times New Roman";
            document.Content.Font.Size = 12.0f;
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

            Paragraph examItemParagraph = examDocument.Paragraphs.Add();

            getExamItemFormatters(examItemParagraph);

            List<ItemTypeFormatter> formatters = getExamItemFormatters(examItemParagraph);

            foreach (ItemTypeFormatter itemTypeFormatter in formatters)
            {
                itemTypeFormatter.FormatAndWriteQuestions(_exam.ExamItems);
                insertParagraph(2, examItemParagraph);
            }

            saveAndCloseDocument(examDocument, filePath, msWordApp);

        }

        private List<ItemTypeFormatter> getExamItemFormatters(Paragraph examItemParagraph)
        {

            string[] formatters = ConfigurationManager.AppSettings["examFormatOrder"].Split(',');
            List<ItemTypeFormatter> itemTypeFormatters = new List<ItemTypeFormatter>();
            
            if (formatters.Length == 0)
            {
                itemTypeFormatters = new List<ItemTypeFormatter>
                {
                    new FillInTheBlanksFormatter(examItemParagraph),
                    new IdentificationFormatter(examItemParagraph),
                    new EssayFormatter(examItemParagraph),
                    new MultipleChoiceFormatter(examItemParagraph)
                };
            }
            else
            {
                Type[] parameterType = { typeof(Paragraph) };
                object[] contructorArgs = { examItemParagraph };
                string formatterNamespace = ConfigurationManager.AppSettings["examFormatNamespace"];
                string formatterFullName = string.Empty;

                foreach (var formatter in formatters)
                {
                    formatterFullName = String.Format("{0}.{1}", formatterNamespace, formatter + "Formatter");
                    Type formatterType = Type.GetType(formatterFullName) ?? typeof (EssayFormatter);

                    ConstructorInfo constructor = formatterType.GetConstructor(parameterType);
                    ItemTypeFormatter itemTypeFormatter = (ItemTypeFormatter)constructor.Invoke(contructorArgs);

                    itemTypeFormatters.Add(itemTypeFormatter);
                }
            }

            return itemTypeFormatters;
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
       

    }

    
}
