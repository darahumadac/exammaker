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

namespace ExamMaker.Views
{
    public partial class ExamListScreen : Form, IExamListView
    {
        private readonly Repository<Exam> _examRepository;
        private ExamListPresenter _examListPresenter;
        private ResourceManager _resourceManager;
        private int _examListShownColumnCount;

        public ExamListScreen(Repository<Exam> examRepository)
        {
            InitializeComponent();

            _examRepository = examRepository;
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
            IEnumerable<Exam> examRecords = _examRepository.GetAll().OrderBy(e => e.ScheduledExamDate);

            examListGrid.DataSource = examRecords.ToList();

            totalExamsLbl.Text = String.Format(_resourceManager.GetString("totalExamLbl"), examRecords.Count());

        }

        private void examListGrid_rowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            examListGrid.Columns["Type"].Width = (examListGrid.Width/_examListShownColumnCount) - 2;
        }

        private void viewOrEditExamBtn_Click(object sender, EventArgs e)
        {
            Exam selectedExamRecord = (Exam)examListGrid.SelectedRows[0].DataBoundItem;
            IExamView examView = new ExamScreen(selectedExamRecord);
            examView.Show();
        }
    }
}
