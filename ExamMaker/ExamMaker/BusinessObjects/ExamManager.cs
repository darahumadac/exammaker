using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using ExamMaker.Models.Models;

namespace ExamMaker.BusinessObjects
{
    public class ExamManager : IExamManager
    {
        private readonly Exam _exam;
        private Exporter _exporter;

        public ExamManager(Exam exam)
        {
            _exam = exam;
            
            Type[] parameterType = { typeof(Exam) };
            Type exporterType = Type.GetType(ConfigurationManager.AppSettings["documentExporterInstance"]) ??
                                typeof (MsWordExporter);

            ConstructorInfo constructor = exporterType.GetConstructor(parameterType);
            object[] contructorArgs = { exam };
            _exporter = (Exporter)constructor.Invoke(contructorArgs);
        }

        public void ExportAnswerKey()
        {
            string answerKeyFilePath = getExportFilePath("answerkey");
            _exporter.ExportAnswerKey(answerKeyFilePath);
        }

        private string getExportFilePath(string documentType)
        {
            string docTypeFilename = ConfigurationManager.AppSettings[String.Format("{0}DefaultFilename", documentType)];
            string docTypeFolder = ConfigurationManager.AppSettings[String.Format("{0}SaveFolder", documentType)];

            if (string.IsNullOrEmpty(docTypeFolder))
            {
                docTypeFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            return Path.Combine(docTypeFolder, String.Format(docTypeFilename, _exam.ExamId));
        }

        public void ExportExam()
        {
            string examFilePath = getExportFilePath("exam");
            _exporter.ExportExam(examFilePath);
        }
    }
}
