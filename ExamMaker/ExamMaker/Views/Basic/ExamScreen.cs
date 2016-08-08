using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using ExamMaker.BusinessObjects;
using ExamMaker.Formatters;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;
using ExamMaker.Presenters.Presenters;
using ExamMaker.Utils;

namespace ExamMaker.Views.Basic
{
    public partial class ExamScreen : Form, IExamView
    {
        private ExamPresenter _examPresenter;
        private IExamManager _examManager;
        private Exam _examRecord;
        private readonly Repository<Exam> _examRepository;
        private readonly Repository<ExamItem> _examItemsRepository;
        private readonly Repository<Option> _optionRepository;
        private ResourceManager _resourceManager;
        private ResourceManager _examModelResourceManager;

        private List<ExamItem> _examItems;
        private ExamItem _selectedExamItem;
        private bool _hasExamItems;
        private bool _shouldValidateRow;
        
        private bool _hasSelectedRow;
        private bool _isCurrentRecordSaved;

        public ExamScreen(Repository<Exam> examRepository, Repository<ExamItem> examItemsRepository,
            Repository<Option> optionRepository)
        {
            InitializeComponent();

            _examRepository = examRepository;
            _examItemsRepository = examItemsRepository; 
            _optionRepository = optionRepository;

            _examItems = new List<ExamItem>();
            _hasExamItems = false;
            _examRecord = new Exam()
            {
                ExamItems = _examItems,
                ExamName = "New Exam " + (_examRepository.GetAll().Count + 1),
                ExamPassword = Program.LoggedInUser.Password,
                Type = ExamType.Quiz,
                ScheduledExamDate = DateTime.Now,
                UserId = Program.LoggedInUser.UserId
            };

            Assembly modelResourceAssembly = Assembly.Load("ExamMaker.Models");
            _examModelResourceManager = new ResourceManager("ExamMaker.Models.ExamMakerResource", modelResourceAssembly);
            _resourceManager = new ResourceManager("ExamMaker.Resources.ExamScreenResource", Assembly.GetExecutingAssembly());
            _examPresenter = new ExamPresenter(this);
            _examManager = new ExamManager(_examRecord);

            SetUIDefaults();
            InitializeUI();
        }

        public ExamScreen(Exam examRecord, Repository<Exam> examRepository, 
            Repository<ExamItem> examItemsRepository, Repository<Option> optionRepository )
        {
            InitializeComponent();

            _examRecord = examRecord;
            _examRepository = examRepository;
            _examItemsRepository = examItemsRepository;
            _optionRepository = optionRepository;
            _examItems = _examRecord.ExamItems.OrderBy(e => e.ItemNumber).ToList();
            _hasExamItems = _examItems.Count > 0;
            _hasSelectedRow = false;
            _shouldValidateRow = false;
            _isCurrentRecordSaved = true;

            Assembly modelResourceAssembly = Assembly.Load("ExamMaker.Models");
            _examModelResourceManager = new ResourceManager("ExamMaker.Models.ExamMakerResource", modelResourceAssembly);
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
                saveItemTooltip.SetToolTip(faqImg, _resourceManager.GetString("saveExamFirstMsg"));
            }

            if (_hasExamItems)
            {
                itemNum.Minimum = 1;
                itemNum.Maximum = _examItems.Count;
            }
            else
            {
                deleteItem.Enabled = false;
                editItemBtn.Enabled = false;
            }
        }

        public void LoadExamItemChoices()
        {
            displayOptionsInChoicesTab();
        }

        private void ExamScreen_Load(object sender, EventArgs e)
        {
            _examPresenter.LoadRecord();
        }

        public void LoadRecord()
        {
            loadExamInfo();
            loadExamItems();
        }
       
        private void loadExamInfo()
        {
            examName.Text = _examRecord.ExamName;
            examTypeDd.SelectedIndex = (int)_examRecord.Type - 1;
            examDate.Value = _examRecord.ScheduledExamDate;
            examPassword.Text = _examRecord.ExamPassword;

            examPreparedBy.Text = Program.LoggedInUser.Username;
        }

        private void loadExamItems()
        {
            _hasSelectedRow = false;

            LoadAndSortExamItems();

            if (_hasExamItems)
            {
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

                previewQuestion.Text = QuestionFormatter.GetFormattedQuestion(_selectedExamItem);
                
            }
        }

        private void showOrHideChoicesTabForExamItem(int examItemTypeIndex)
        {
            examQuestionDetails.TabPages.Remove(choicesTab);

            if (examItemTypeIndex == (int) ItemType.MultipleChoice)
            {
                examQuestionDetails.TabPages.Add(choicesTab);
                LoadExamItemChoices();
            }
        }


        private void displayOptionsInChoicesTab()
        {
            bool isCorrectAnswer;
            string[] correctAnswers = _selectedExamItem.Answer.Split(',');

            choicesList.Items.Clear();
            if (_selectedExamItem.Options != null && _selectedExamItem.Options.Count > 0)
            {
                foreach (var option in _selectedExamItem.Options)
                {
                    isCorrectAnswer = correctAnswers.FirstOrDefault(a => a.Equals(option.OptionName)) != null;
                    choicesList.Items.Add(String.Format("{0}. {1}",
                        option.OptionName, option.Description),
                        isCorrectAnswer);
                }

                answer.Text = _selectedExamItem.Answer;
            }
            else
            {
                answer.Text = string.Empty;
            }
        }

        private void examItemsGrid_rowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            examItemsGrid.Columns["ItemNumber"].Width = 50;
            examItemsGrid.Columns["ItemType"].Width = 100;

            itemNum.Maximum = _examItems.Count;
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
                LoadAndSortExamItems();
                selectCurrentExamItem();
            }
        }

        public void LoadAndSortExamItems()
        {
            _hasSelectedRow = false;
            examItemsGrid.DataSource = _examItems.OrderBy(i => i.ItemNumber).ToList();
            totalQuestionsLbl.Text = String.Format("{0} items", _examItems.Count);
        }

        private void selectCurrentExamItem()
        {
            selectExamItem(_selectedExamItem.ItemNumber - 1);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            revertChanges();
        }

        private void revertChanges()
        {
            _isCurrentRecordSaved = true;
            _examItemsRepository.Revert();
            LoadAndSortExamItems();

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

            if (_selectedExamItem.ItemType == ItemType.MultipleChoice)
            {
                setExamItemAnswerForMultipleChoice();
            }
            else
            {
                deleteChoicesForExamItem();
            }

            _optionRepository.Save();

            if (_selectedExamItem.ExamItemId == 0)
            {
                _examItemsRepository.Add(_selectedExamItem);
            }
            else
            {
                _examItemsRepository.Update(_selectedExamItem);
            }

            _examItemsRepository.Save();

            allowEditOfExamItem(false);

            LoadAndSortExamItems();
            selectCurrentExamItem();
        }

        private void deleteChoicesForExamItem()
        {
            List<Option> optionsToDelete =
                _optionRepository.GetAll().FindAll(o => o.ExamItemId == _selectedExamItem.ExamItemId);

            foreach (var option in optionsToDelete)
            {
                _optionRepository.Delete(option);
            }

            _optionRepository.Save();
        }

        private void setExamItemAnswerForMultipleChoice()
        {
            List<Option> options = _selectedExamItem.Options;

            List<string> correctAnswers = new List<string>();
            bool isCorrectAnswer;
            int optionIndex;
            bool isNewOption;
            Option currentOption;

            foreach (string option in choicesList.Items)
            {
                optionIndex = choicesList.Items.IndexOf(option);
                isCorrectAnswer = choicesList.CheckedIndices.Contains(optionIndex);
                
                string[] optionAndOptionName = option.Split('.');
                string description = optionAndOptionName[1].Trim();
                string optionName = optionAndOptionName[0];
                currentOption = options.Find(o => o.OptionName.Equals(optionAndOptionName[0]));
                isNewOption = currentOption == null;

                if (isNewOption)
                {
                    Option newOption = new Option()
                    {
                        ExamItemId = _selectedExamItem.ExamItemId,
                        Description = description,
                        IsCorrectAnswer = isCorrectAnswer,
                        OptionName = optionName
                    };

                    options.Add(newOption);
                }
                else
                {
                    currentOption.Description = description;
                    currentOption.IsCorrectAnswer = isCorrectAnswer;
                    currentOption.OptionName = optionName;

                    _optionRepository.Update(currentOption);
                }

                if (isCorrectAnswer)
                {
                    correctAnswers.Add(optionName);
                }

                _selectedExamItem.Answer = string.Join(",", correctAnswers);
                answer.Text = _selectedExamItem.Answer;
                
            }

            _selectedExamItem.Options = options;

        }

        private void enableExamItemDetails(bool isEnabled)
        {
            _isCurrentRecordSaved = !isEnabled;
            _shouldValidateRow = isEnabled;

            addItemBtn.Enabled = !isEnabled;
            deleteItem.Enabled = !isEnabled;
            editItemBtn.Enabled = !isEnabled;
            saveItem.Enabled = isEnabled;
            discardChanges.Enabled = isEnabled;

            itemTypeLbl.Enabled = isEnabled;
            itemTypeDd.Enabled = isEnabled;
            
            question.Enabled = isEnabled;
            choicesList.Enabled = isEnabled;
            addChoiceBtn.Enabled = isEnabled;
            deleteChoice.Enabled = isEnabled;
            editChoice.Enabled = isEnabled;
            previewTab.Enabled = isEnabled;
            answerBox.Enabled = isEnabled;

            examItemsGrid.Enabled = !isEnabled;
            examItemsEditLockMsg.Visible = isEnabled;
        }

        private void saveExamBtn_Click(object sender, EventArgs e)
        {

            try
            {
                saveExam();
                MessageBox.Show(_resourceManager.GetString("saveExamSuccessMsg"),
                    _resourceManager.GetString("saveExamSuccessCaption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder errorSb = new StringBuilder();
                errorSb.AppendLine(_resourceManager.GetString("saveExamErrorInstruction"));

                foreach (var error in ex.EntityValidationErrors.First().ValidationErrors)
                {
                    errorSb.AppendLine("- " + error.ErrorMessage);
                }

                MessageBox.Show(errorSb.ToString(),
                    _resourceManager.GetString("saveExamErrorCaption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //TODO: Implement error logging
            }
            catch (Exception ex)
            {
                MessageBox.Show(_resourceManager.GetString("saveExamErrorMsg"),
                    _resourceManager.GetString("saveExamErrorCaption"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LoadAndSortExamItems();

        }

        private void saveExam()
        {
            ValidateChildren();

            _examRecord.ExamName = examName.Text;
            _examRecord.ExamPassword = examPassword.Text;
            _examRecord.Type = (ExamType)examTypeDd.SelectedIndex + 1;
            _examRecord.ScheduledExamDate = examDate.Value;
            _examRecord.UserId = Program.LoggedInUser.UserId;

            _examRecord.ExamItems = _examItems;

            if (_examRecord.ExamId == 0)
            {
                _examRepository.Add(_examRecord);
            }
            else
            {
                _examRepository.Update(_examRecord);
            }

            _examRepository.Save();
        }

        private void itemTypeDd_selectedIndexChanged(object sender, EventArgs e)
        {
            int examTypeIndex = ((ComboBox) sender).SelectedIndex + 1;
            if (_selectedExamItem.ItemType != ItemType.MultipleChoice
                && (ItemType) examTypeIndex == ItemType.MultipleChoice)
            {
                answer.Text = string.Empty;
            }
     
            _selectedExamItem.ItemType = (ItemType)examTypeIndex;
            previewQuestion.Text = QuestionFormatter.GetFormattedQuestion(_selectedExamItem);

            showOrHideChoicesTabForExamItem(examTypeIndex);
        }


        private void editItemBtn_Click(object sender, EventArgs e)
        {
            revertChanges();
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
            revertChanges();
            allowEditOfExamItem(false);
        }

        private void choicesList_selectedIndexChanged(object sender, EventArgs e)
        {
            setExamItemAnswerForMultipleChoice();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            ExamItem newExamItem;

            if (_examRecord.ExamId == 0)
            {
                try
                {
                    saveExam();
                }
                catch (DbEntityValidationException ex)
                {
                    StringBuilder errorSb = new StringBuilder();
                    errorSb.AppendLine(_resourceManager.GetString("saveExamErrorInstruction"));

                    foreach (var error in ex.EntityValidationErrors.First().ValidationErrors)
                    {
                        errorSb.AppendLine("- " + error.ErrorMessage);
                    }

                    MessageBox.Show(errorSb.ToString(),
                        _resourceManager.GetString("saveExamErrorCaption"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //TODO: Implement error logging
                }
                catch (Exception ex)
                {
                    MessageBox.Show(_resourceManager.GetString("saveExamErrorMsg"),
                        _resourceManager.GetString("saveExamErrorCaption"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            if (_hasExamItems)
            {
                newExamItem = new ExamItem()
                {
                    ItemNumber = _examItems.Count + 1,
                    ItemType = _examItems.Last().ItemType,
                    Question = string.Empty,
                    Answer = string.Empty,
                    Options = new List<Option>()
                };
            }
            else
            {
                newExamItem = new ExamItem()
                {
                    ExamId = _examRecord.ExamId,
                    ItemNumber = 1,
                    ItemType = ItemType.Identification,
                    Question = string.Empty,
                    Answer = string.Empty,
                    Options = new List<Option>()
                };

                editItemBtn.Enabled = true;
                deleteItem.Enabled = true;
            }
            

            _examItems.Add(newExamItem);
            _examItemsRepository.Save();

            _examRecord.ExamItems = _examItems;
            _hasExamItems = _examItems.Count > 0;

            _examRepository.Save();

            LoadAndSortExamItems();
            selectExamItem(_examItems.Count-1);

            
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            ExamItem itemToRemove = (ExamItem) examItemsGrid.SelectedRows[0].DataBoundItem;
            int itemNumberToRemove = itemToRemove.ItemNumber;
            adjustOrderOfItemsAfterRemovedIndex(itemNumberToRemove);

            _examItems.Remove(itemToRemove);

            _examItemsRepository.Delete(itemToRemove);
            _examItemsRepository.Save();

            LoadAndSortExamItems();

            if (_examItems.Count > 0)
            {
                if (itemNumberToRemove > _examItems.Count)
                {
                    selectExamItem(_examItems.Count - 1);
                }
                else
                {
                    selectExamItem(itemToRemove.ItemNumber - 1);
                }
            }
            else
            {
                editItemBtn.Enabled = false;
                deleteItem.Enabled = false;
                _hasExamItems = false;
            }
            
        }

        private void examItemsGrid_rowRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            itemNum.Maximum = _examItems.Count;
        }

        private void adjustOrderOfItemsAfterRemovedIndex(int removedIndex)
        {
            ExamItem examItemToReorder;
            for (int i = removedIndex + 1; i <= _examItems.Count; i++)
            {
                examItemToReorder = _examItems.First(e => e.ItemNumber == i);
                examItemToReorder.ItemNumber = i - 1;
                _examItemsRepository.Update(examItemToReorder);
            }

            _examItemsRepository.Save();
            
        }

        private void addChoiceBtn_Click(object sender, EventArgs e)
        {
            AddChoiceScreen addChoiceScreen = 
                new AddChoiceScreen(_selectedExamItem, _examItemsRepository, this);
            addChoiceScreen.Show();
        }

        private void deleteChoice_Click(object sender, EventArgs e)
        {
            int choiceIndex = choicesList.SelectedIndex;
            Option choiceToDelete = _selectedExamItem.Options[choiceIndex];

            choicesList.Items.RemoveAt(choiceIndex);

            _optionRepository.Delete(choiceToDelete);
            _optionRepository.Save();

            if (choicesList.Items.Count == 0)
            {
                deleteChoice.Enabled = false;
                editChoice.Enabled = false;
            }
        }

        private void editChoice_Click(object sender, EventArgs e)
        {
            int selectedOptionIndex = choicesList.SelectedIndex;
            Option currentOption = _selectedExamItem.Options[selectedOptionIndex];
            
            AddChoiceScreen addChoiceScreen =
                new AddChoiceScreen(currentOption, 
                    _selectedExamItem, _examItemsRepository, this, _optionRepository);
            addChoiceScreen.Show();
        }
       
        private void examName_validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int examNameLength;
            Int32.TryParse(ConfigurationManager.AppSettings["passwordAndNameFieldsMinLength"],
                out examNameLength);

            if (InputValidator.IsEmpty(examName.Text) ||
                InputValidator.IsLengthTooShort(examName.Text, examNameLength))
            {
                examNameError.SetError(examName, _examModelResourceManager.GetString("examNameLengthError"));
                e.Cancel = true;
            }
            else
            {
                examNameError.Clear();
            }
            
        }

        private void examPassword_validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int passwordLength;
            Int32.TryParse(ConfigurationManager.AppSettings["passwordAndNameFieldsMinLength"],
                out passwordLength);

            if (InputValidator.IsEmpty(examPassword.Text) ||
                InputValidator.IsLengthTooShort(examPassword.Text, passwordLength))
            {
                examPasswordError.SetError(examPassword, 
                    _examModelResourceManager.GetString("examPasswordError"));
                e.Cancel = true;
            }
            else
            {
                examPasswordError.Clear();
            }


        }

        private void setExamItemPreview()
        {
            _selectedExamItem.Question = question.Text;
            previewQuestion.Text = QuestionFormatter.GetFormattedQuestion(_selectedExamItem);
        }

        private void question_textChanged(object sender, EventArgs e)
        {
            _selectedExamItem.Question = question.Text;
        }

        private void examQuestionDetails_selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                setExamItemPreview();
            }
        }
    }
}
