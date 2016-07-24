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
        private bool _hasExamItems;
        private bool _shouldValidateRow;
        
        private bool _hasSelectedRow;
        private bool _isCurrentRecordSaved;

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
            _shouldValidateRow = false;
            _isCurrentRecordSaved = true;

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

            enableResetBtn(false);
        }

        public void InitializeUI()
        {
            if (_examRecord != null)
            {
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
                SortExamItems();
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

                showOrHideChoicesTabForExamItem((int)_selectedExamItem.ItemType);
            }
        }

        private void showOrHideChoicesTabForExamItem(int examItemTypeIndex)
        {
            choicesList.Items.Clear();
            examQuestionDetails.TabPages.Remove(choicesTab);

            if (examItemTypeIndex == (int)ItemType.MultipleChoice)
            {
                examQuestionDetails.TabPages.Add(choicesTab);
                displayOptionsInChoicesTab();
            }
        }

        private void displayOptionsInChoicesTab()
        {
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

                enableResetBtn(true);
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
            _isCurrentRecordSaved = true;
            _examItemsRepository.Revert();
            SortExamItems();

            selectCurrentExamItem();
            enableResetBtn(false);
        }

        private void enableResetBtn(bool willEnableBtn)
        {
            saveOrder.Enabled = willEnableBtn;
            resetBtn.Enabled = willEnableBtn;
        }

        private void examItemsGrid_selectionChanged(object sender, EventArgs e)
        {
            loadSelectedExamItemInfo();
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            _selectedExamItem.ItemType = (ItemType)itemTypeDd.SelectedIndex + 1;
            _selectedExamItem.Question = question.Text;
            _selectedExamItem.Answer = answer.Text;
            _selectedExamItem.Options.Clear();

            if (_selectedExamItem.ItemType == ItemType.MultipleChoice)
            {
                setExamItemAnswerForMultipleChoice();
            }

            _examItemsRepository.Update(_selectedExamItem);
            _examItemsRepository.Save();

            allowEditOfExamItem(false);

            SortExamItems();
            selectCurrentExamItem();
        }

        private void setExamItemAnswerForMultipleChoice()
        {
            _selectedExamItem.Options.Clear();
            List<string> correctAnswers = new List<string>();
            bool isCorrectAnswer;
            int optionIndex;

            foreach (string option in choicesList.Items)
            {
                optionIndex = choicesList.Items.IndexOf(option);

                isCorrectAnswer = choicesList.CheckedIndices.Contains(optionIndex);

                string[] optionAndOptionName = option.Split('.');
                _selectedExamItem.Options.Add(new Option()
                {
                    Description = optionAndOptionName[1].Trim(),
                    IsCorrectAnswer = isCorrectAnswer,
                    OptionName = optionAndOptionName[0]
                });
                if (isCorrectAnswer)
                {
                    correctAnswers.Add(optionAndOptionName[0]);
                }
            }

            _selectedExamItem.Answer =
                string.Join(",", correctAnswers);

            answer.Text = _selectedExamItem.Answer;
        }

        private void enableExamItemDetails(bool isEnabled)
        {
            _isCurrentRecordSaved = !isEnabled;
            _shouldValidateRow = isEnabled;

            editItemBtn.Enabled = !isEnabled;
            saveItem.Enabled = isEnabled;
            discardChanges.Enabled = isEnabled;

            itemTypeLbl.Enabled = isEnabled;
            itemTypeDd.Enabled = isEnabled;
            
            question.Enabled = isEnabled;
            choicesList.Enabled = isEnabled;
            addChoiceBtn.Enabled = isEnabled;
            previewTab.Enabled = isEnabled;
            answerBox.Enabled = isEnabled;
        }

        private void saveExamBtn_Click(object sender, EventArgs e)
        {
            _examRepository.Save();
        }

        private void itemTypeDd_selectedIndexChanged(object sender, EventArgs e)
        {
            int examTypeIndex = ((ComboBox) sender).SelectedIndex + 1;
            showOrHideChoicesTabForExamItem(examTypeIndex);
        }

        private void examItemsGrid_rowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (_selectedExamItem != null && _shouldValidateRow && !_isCurrentRecordSaved)
            {
                DialogResult result = MessageBox.Show(
                String.Format(_resourceManager.GetString("saveExamItemConfirm"),
                    _selectedExamItem.ItemNumber),
                string.Empty, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    allowEditOfExamItem(false);
                }
            }
            
        }

        private void editItemBtn_Click(object sender, EventArgs e)
        {
            resetBtn_Click(sender, e);
            allowEditOfExamItem(true);
        }

        private void saveOrder_Click(object sender, EventArgs e)
        {
            _examItemsRepository.Save();
            enableResetBtn(false);
        }

        private void allowEditOfExamItem(bool allowEdit)
        {
            enableExamItemDetails(allowEdit);

            itemNumLbl.Enabled = !allowEdit;
            itemNum.Enabled = !allowEdit;
        }

        private void discardChanges_Click(object sender, EventArgs e)
        {
            resetBtn_Click(sender, e);
            allowEditOfExamItem(false);
        }

        private void choicesList_selectedIndexChanged(object sender, EventArgs e)
        {
            setExamItemAnswerForMultipleChoice();
        }

    

        

    }
}
