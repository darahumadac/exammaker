using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;
using ExamMaker.Presenters.Presenters;
using ExamMaker.Presenters.Views;

namespace ExamMaker.Views.Basic
{
    public partial class ExamListScreen : Form, IExamListView
    {
        private readonly Repository<Exam> _examRepository;
        private readonly Repository<ExamItem> _examItemsRepository;
        private readonly Repository<Option> _optionRepository;
        private ExamListPresenter _examListPresenter;
        private ResourceManager _resourceManager;
        private int _examListShownColumnCount;
        private Exam _selectedExamRecord;

        public ExamListScreen(Repository<Exam> examRepository, 
            Repository<ExamItem> examItemsRepository, Repository<Option> optionRepository)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _examRepository = examRepository;
            _examItemsRepository = examItemsRepository;
            _optionRepository = optionRepository;
            _examListPresenter = new ExamListPresenter(this);
            _resourceManager = new ResourceManager("ExamMaker.Resources.ExamListResource", Assembly.GetExecutingAssembly());
            _examListShownColumnCount =
                typeof (Exam)
                    .GetProperties()
                    .Count(p => p.GetCustomAttributes<BrowsableAttribute>().Count() == 0);
        }

        private void ExamListScreen_Load(object sender, System.EventArgs e)
        {
            _examListPresenter.LoadAllRecords();   
        }

        public void LoadAllRecords()
        {
            IEnumerable<Exam> examRecords = _examRepository.GetAll()
                .FindAll(e => e.UserId == Program.LoggedInUser.UserId)
                .OrderBy(e => e.ScheduledExamDate);

            examListGrid.DataSource = examRecords.ToList();

            totalExamsLbl.Text = String.Format(_resourceManager.GetString("totalExamLbl"), examRecords.Count());

        }

        private void examListGrid_rowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            examListGrid.Columns["Type"].Width = (examListGrid.Width/_examListShownColumnCount) - 2;
        }

        private void viewOrEditExamBtn_Click(object sender, EventArgs e)
        {
            _selectedExamRecord = (Exam)examListGrid.SelectedRows[0].DataBoundItem;
            IExamView examView = new ExamScreen(_selectedExamRecord,
                _examRepository, _examItemsRepository, _optionRepository);

            EnterPasswordForm passwordForm = new EnterPasswordForm(_selectedExamRecord.ExamPassword, examView);
            passwordForm.Show();
        }

        private void deleteExamBtn_Click(object sender, EventArgs e)
        {
            _selectedExamRecord = (Exam)examListGrid.SelectedRows[0].DataBoundItem;

            EnterPasswordForm passwordForm = new EnterPasswordForm(_selectedExamRecord.ExamPassword,
                _examRepository, 
                _selectedExamRecord,
                _examListPresenter);
            passwordForm.Show();
        }

        private void ExamListScreen_activated(object sender, EventArgs e)
        {
            _examListPresenter.LoadAllRecords(); 
        }
    }
}
