using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using ExamMaker.BusinessObjects;
using ExamMaker.Models.Models;
using ExamMaker.Presenters.Presenters;

namespace ExamMaker.Views
{
    public partial class ExamScreen : Form, IExamView
    {
        private ExamPresenter _examPresenter;
        private IExamManager _examManager;
        private readonly Exam _examRecord;
        private ResourceManager _resourceManager;


        private List<ExamItem> _examItems;
        private ExamItem _selectedExamItem;
        private List<string> _correctAnswerIdentifiers;
        private List<string> _answers; 
        private bool _hasExamItems;
        
        private bool _hasSelectedRow;

        public ExamScreen()
        {
            InitializeComponent();
        }

        public ExamScreen(Exam examRecord)
        {
            InitializeComponent();

            _examRecord = examRecord;
            _examItems = _examRecord.ExamItems.OrderBy(e => e.ItemNumber).ToList();
            _hasExamItems = _examItems.Count > 0;
            _hasSelectedRow = false;

            _resourceManager = new ResourceManager("ExamMaker.Resources.ExamScreenResource", Assembly.GetExecutingAssembly());
            _examPresenter = new ExamPresenter(this);
            _examManager = new ExamManager(examRecord);
        }

        private void ExamScreen_Load(object sender, EventArgs e)
        {
            if (_examRecord != null)
            {
                _examPresenter.LoadRecord();
            }

            initializeUI();
        }

        private void initializeUI()
        {
            if (_examRecord != null)
            {
                saveItem.Enabled = true;
                totalQuestionsLbl.Text = String.Format("{0} items", _examItems.Count);
            }
            else
            {
                faqImg.Image = Bitmap.FromHicon(System.Drawing.SystemIcons.Question.Handle);
                saveItemTooltip.SetToolTip(faqImg, "Click 'Save Exam' first to save exam item");
            } 
        }

        public void LoadRecord()
        {
            loadExamInfo();

            if (_hasExamItems)
            {
                loadExamItems();
            }

        }

        private void loadExamInfo()
        {
            examName.Text = _examRecord.ExamName;
            examTypeDd.SelectedItem = _examRecord.Type.ToString();
            examDate.Value = _examRecord.ScheduledExamDate;
            examPassword.Text = _examRecord.ExamPassword;

            examPreparedBy.Text = Program.LoggedInUser.Username;
        }

        private void loadExamItems()
        {
            examItemsGrid.DataSource = _examItems;

            examItemsGrid.Rows[0].Selected = true;
            _hasSelectedRow = true;
        }

        private void loadSelectedExamItemInfo()
        {

            _selectedExamItem = (ExamItem)examItemsGrid.SelectedRows[0].DataBoundItem;

            itemNum.Value = _selectedExamItem.ItemNumber;
            itemTypeDd.SelectedIndex = (int)_selectedExamItem.ItemType - 1;
            question.Text = _selectedExamItem.Question;
            answer.Text = _selectedExamItem.Answer;

            choicesList.Items.Clear();

            bool isCorrectAnswer;
            string[] correctAnswers = _selectedExamItem.Answer.Split(',');
            foreach (var option in _selectedExamItem.Options)
            {
                isCorrectAnswer = correctAnswers.FirstOrDefault(a => a.Equals(option.OptionName)) != null;
                choicesList.Items.Add(String.Format("{0}. {1}", 
                    option.OptionName, option.Description), 
                    isCorrectAnswer);
            }
        }

        private void examItemsGrid_rowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            examItemsGrid.Columns["ItemNumber"].Width = 50;
            examItemsGrid.Columns["ItemType"].Width = 100;
        }

        private void examItemsGrid_rowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_hasSelectedRow)
            {
                loadSelectedExamItemInfo();
            }

        }

        private void exportAnsKeyBtn_Click(object sender, EventArgs e)
        {
            _examManager.ExportAnswerKey();

            string saveFolder = ConfigurationManager.AppSettings["answerKeySaveFolder"];
            if (string.IsNullOrEmpty(saveFolder))
            {
                saveFolder = "My Documents";
            }

            MessageBox.Show(String.Format(_resourceManager.GetString("exportAnsKeySuccessMsg"), saveFolder,
                String.Format(ConfigurationManager.AppSettings["answerKeyDefaultFilename"], _examRecord.ExamId)),
                _resourceManager.GetString("exportAnsKeySuccessCaption"), MessageBoxButtons.OK);
        }

    }
}
