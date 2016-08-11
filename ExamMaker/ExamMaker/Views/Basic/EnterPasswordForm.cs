using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;
using ExamMaker.Presenters.Presenters;

namespace ExamMaker.Views.Basic
{
    public partial class EnterPasswordForm : Form
    {
        private readonly string _examPassword;
        private readonly Repository<Exam> _examRepository;
        private readonly Exam _examRecord;
        private readonly ExamListPresenter _examListPresenter;
        private readonly IExamView _examView;

        public EnterPasswordForm(string examPassword, IExamView examView)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _examPassword = examPassword;
            _examView = examView;
            
            enterPwMsg.Text = "Enter password to view exam";
        }

        public EnterPasswordForm(string examPassword, Repository<Exam> examRepository, Exam examRecord, ExamListPresenter examListPresenter)
        {
            InitializeComponent();

            _examPassword = examPassword;
            _examRepository = examRepository;
            _examRecord = examRecord;
            _examListPresenter = examListPresenter;

            enterPwMsg.Text = "Enter password to delete exam";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

            if (examPassword.Text.Equals(_examPassword))
            {
                Dispose();

                if (_examView != null)
                {
                    _examView.Show();
                }
                else if(_examRepository != null && _examRecord != null)
                {
                    List<Exam> examList =
                        _examRepository.GetAll().FindAll(ex => ex.UserId == Program.LoggedInUser.UserId);
                    
                    int examIndex = examList
                        .OrderBy(ex => ex.ScheduledExamDate)
                        .ToList().IndexOf(_examRecord);

                    _examRepository.Delete(_examRecord);
                    _examRepository.Save();

                    _examListPresenter.LoadAllRecords();

                    if (examList.Count > 0)
                    {
                        _examListPresenter.SelectExam(examIndex);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Incorrect password", "Cannot Access Exam", MessageBoxButtons.OK);
            }

            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
