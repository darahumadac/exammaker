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
            string answerKeyFilename = ConfigurationManager.AppSettings["answerKeyDefaultFilename"];
            string answerKeyFolder = ConfigurationManager.AppSettings["answerKeySaveFolder"];

            if (string.IsNullOrEmpty(answerKeyFolder))
            {
                answerKeyFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            string answerKeyFilePath = Path.Combine(answerKeyFolder, String.Format(answerKeyFilename, _exam.ExamId)); 

            _exporter.ExportAnswerKey(answerKeyFilePath);
        }
    }
}
