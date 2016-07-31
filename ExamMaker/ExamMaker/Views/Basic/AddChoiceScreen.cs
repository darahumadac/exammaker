using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;

namespace ExamMaker.Views.Basic
{
    public partial class AddChoiceScreen : Form
    {
        private readonly Option _selectedChoice;
        private readonly ExamItem _examItem;
        private readonly Repository<ExamItem> _examItemsRepository;
        private readonly IExamView _examView;
        private readonly Repository<Option> _optionRepository;

        public AddChoiceScreen(ExamItem examItem, Repository<ExamItem> examItemsRepository, 
            IExamView examView)
        {
            InitializeComponent();

            _examItem = examItem;
            _examItemsRepository = examItemsRepository;
            _examView = examView;
        }

        public AddChoiceScreen(Option selectedChoice, ExamItem examItem, 
            Repository<ExamItem> examItemsRepository, IExamView examView,
            Repository<Option> optionRepository )
        {
            InitializeComponent();

            _selectedChoice = selectedChoice;

            _examItem = examItem;
            _examItemsRepository = examItemsRepository;
            _examView = examView;
            _optionRepository = optionRepository;

            optionName.Text = _selectedChoice.OptionName;
            optionDescription.Text = _selectedChoice.Description;

            addChoice.Text = "Save Changes";
        }

        private void addChoice_Click(object sender, EventArgs e)
        {
            if (_selectedChoice != null)
            {
                _selectedChoice.OptionName = optionName.Text;
                _selectedChoice.Description = optionDescription.Text;

                _optionRepository.Update(_selectedChoice);
                _optionRepository.Save();
            }
            else
            {
                _examItem.Options.Add(new Option()
                {
                    OptionName = optionName.Text,
                    Description = optionDescription.Text
                });
            }

            _examItemsRepository.Save();
            _examView.LoadExamItemChoices();
            Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        


    }
}
