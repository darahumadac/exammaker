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
using ExamMaker.Models.Repositories;
using ExamMaker.Presenters.Presenters;

namespace ExamMaker.Views.Basic
{
    public partial class ExamScreen : Form, IExamView
    {
        private ExamPresenter _examPresenter;
        private IExamManager _examManager;
        private readonly Exam _examRecord;
        private readonly Repository<Exam> _examRepository;
        private readonly Repository<ExamItem> _examItemsRepository;
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

        public ExamScreen(Exam examRecord, Repository<Exam> examRepository, 
            Repository<ExamItem> examItemsRepository)
        {
            InitializeComponent();

            _examRecord = examRecord;
            _examRepository = examRepository;
            _examItemsRepository = examItemsRepository;
            _examItems = _examRecord.ExamItems.OrderBy(e => e.ItemNumber).ToList();
            _hasExamItems = _examItems.Count > 0;
            _hasSelectedRow = false;

            _resourceManager = new ResourceManager("ExamMaker.Resources.ExamScreenResource", Assembly.GetExecutingAssembly());
            _examPresenter = new ExamPresenter(this);
            _examManager = new ExamManager(examRecord);

            SetUIDefaults();
            InitializeUI();
        }

        public void SetUIDefaults()
        {
            itemNum.Minimum = 0;
            itemNum.Maximum = 0;
        }

        public void InitializeUI()
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

            if (_hasExamItems)
            {
                itemNum.Minimum = 1;
                itemNum.Maximum = _examItems.Count;
            }
        }

        private void ExamScreen_Load(object sender, EventArgs e)
        {
            if (_examRecord != null)
            {
                _examPresenter.LoadRecord();
            }
        }

        public void LoadRecord()
        {
            loadExamInfo();
            loadExamItems();
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
            _hasSelectedRow = false;

            if (_hasExamItems)
            {
                examItemsGrid.DataSource = _examItems;
                selectExamItem(0);
            }
        }

        private void selectExamItem(int row)
        {
            examItemsGrid.Rows[row].Selected = true;
            _hasSelectedRow = true;

            loadSelectedExamItemInfo();
        }

        private void loadSelectedExamItemInfo()
        {
            if (_hasSelectedRow)
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
            
        }

        private void examItemsGrid_rowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            examItemsGrid.Columns["ItemNumber"].Width = 50;
            examItemsGrid.Columns["ItemType"].Width = 100;
        }

        private void exportAnsKeyBtn_Click(object sender, EventArgs e)
        {
            _examManager.ExportAnswerKey();
            showSuccessMessageBox("AnswerKey");
        }

        private void exportExamBtn_Click(object sender, EventArgs e)
        {
            _examManager.ExportExam();
            showSuccessMessageBox("Exam");
        }

        private void showSuccessMessageBox(string documentType)
        {
            string saveFolderSettingKey = String.Format("{0}SaveFolder", documentType.ToLower());
            string saveFolder = ConfigurationManager.AppSettings[saveFolderSettingKey];
            if (string.IsNullOrEmpty(saveFolder))
            {
                saveFolder = "My Documents";
            }
            string successMsgKey = String.Format("export{0}SuccessMsg", documentType);
            string successCaptionKey = String.Format("export{0}SuccessCaption", documentType);
            string saveFilenameKey = String.Format("{0}DefaultFilename", documentType.ToLower());
            string saveFilename = String.Format(ConfigurationManager.AppSettings[saveFilenameKey], _examRecord.ExamId);
            
            string message = String.Format(_resourceManager.GetString(successMsgKey),
                saveFolder, saveFilename);
            MessageBox.Show(message, _resourceManager.GetString(successCaptionKey), MessageBoxButtons.OK);
        }

        private void itemNum_valueChanged(object sender, EventArgs e)
        {
            int newItemNumber = (int)((NumericUpDown)sender).Value;
            
            if (_hasSelectedRow && _selectedExamItem.ItemNumber != newItemNumber)
            {
                ExamItem oldExamItemInItemNumber = _examItems.First(i => i.ItemNumber == newItemNumber);
                oldExamItemInItemNumber.ItemNumber = _selectedExamItem.ItemNumber;
                
                _selectedExamItem.ItemNumber = newItemNumber;

                _examItemsRepository.Update(_selectedExamItem);
                _examItemsRepository.Update(oldExamItemInItemNumber);

                SortExamItems();
                selectCurrentExamItem();
            }
        }

        public void SortExamItems()
        {
            _hasSelectedRow = false;
            examItemsGrid.DataSource = _examItems.OrderBy(i => i.ItemNumber).ToList();
        }

        private void selectCurrentExamItem()
        {
            selectExamItem(_selectedExamItem.ItemNumber - 1);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            _examItemsRepository.Revert();
            SortExamItems();

            selectCurrentExamItem();
        }

        private void examItemsGrid_selectionChanged(object sender, EventArgs e)
        {
            loadSelectedExamItemInfo();
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            _examItemsRepository.Save();

            resetBtn.Enabled = false;
        }

        private void saveExamBtn_Click(object sender, EventArgs e)
        {
            _examRepository.Save();
        }

    }
}
