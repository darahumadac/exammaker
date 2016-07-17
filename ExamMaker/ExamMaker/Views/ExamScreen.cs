using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ExamMaker.Models.Models;
using ExamMaker.Presenters.Presenters;

namespace ExamMaker.Views
{
    public partial class ExamScreen : Form, IExamView
    {
        private readonly Exam _examRecord;
        private List<ExamItem> _examItems;
        private ExamItem _selectedExamItem;
        private List<string> _correctAnswerIdentifiers;
        private bool _hasExamItems;
        private ExamPresenter _examPresenter;
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
            _examPresenter = new ExamPresenter(this);
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

            List<Option> correctAnswers = new List<Option>();
            if (_selectedExamItem.Options.Count > 0)
            {
                _correctAnswerIdentifiers = new List<string>();
                correctAnswers = _selectedExamItem.Options
                    .Where(o => o.IsCorrectAnswer).ToList();

                correctAnswers.ForEach(addOptionToCorrectAnswerIdentifiers);

                answer.Text = String.Join(",", _correctAnswerIdentifiers);
            }
            else
            {
                answer.Text = _selectedExamItem.Answer;
            }

            choicesList.Items.Clear();

            bool isCorrectAnswer;
            foreach (var option in _selectedExamItem.Options)
            {
                isCorrectAnswer = correctAnswers.Contains(option);
                choicesList.Items.Add(String.Format("{0}. {1}", 
                    option.OptionName, option.Description), 
                    isCorrectAnswer);
            }
        }

        private void addOptionToCorrectAnswerIdentifiers(Option option)
        {
            _correctAnswerIdentifiers.Add(option.OptionName);
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

    }
}
