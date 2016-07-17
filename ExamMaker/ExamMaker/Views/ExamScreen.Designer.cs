namespace ExamMaker.Views
{
    partial class ExamScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.examItemsGrid = new System.Windows.Forms.DataGridView();
            this.examQuestionsListLbl = new System.Windows.Forms.Label();
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.examName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.examPassword = new System.Windows.Forms.MaskedTextBox();
            this.totalQuestionsLbl = new System.Windows.Forms.Label();
            this.viewTypeDd = new System.Windows.Forms.ComboBox();
            this.viewByLbl = new System.Windows.Forms.Label();
            this.addExamSectionBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.examDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.examTypeDd = new System.Windows.Forms.ComboBox();
            this.exportExamBtn = new System.Windows.Forms.Button();
            this.exportAnsKeyBtn = new System.Windows.Forms.Button();
            this.previewExamBtn = new System.Windows.Forms.Button();
            this.printExamBtn = new System.Windows.Forms.Button();
            this.saveExamBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.examPreparedBy = new System.Windows.Forms.Label();
            this.examNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.examPasswordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemTypeDd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveItem = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.GroupBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.examQuestionDetails = new System.Windows.Forms.TabControl();
            this.questionTab = new System.Windows.Forms.TabPage();
            this.choicesTab = new System.Windows.Forms.TabPage();
            this.itemNum = new System.Windows.Forms.NumericUpDown();
            this.question = new System.Windows.Forms.TextBox();
            this.choicesList = new System.Windows.Forms.CheckedListBox();
            this.saveItemTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.faqImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.examItemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examPasswordError)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.answerBox.SuspendLayout();
            this.examQuestionDetails.SuspendLayout();
            this.questionTab.SuspendLayout();
            this.choicesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faqImg)).BeginInit();
            this.SuspendLayout();
            // 
            // examItemsGrid
            // 
            this.examItemsGrid.AllowUserToAddRows = false;
            this.examItemsGrid.AllowUserToDeleteRows = false;
            this.examItemsGrid.AllowUserToOrderColumns = true;
            this.examItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examItemsGrid.Location = new System.Drawing.Point(12, 141);
            this.examItemsGrid.MultiSelect = false;
            this.examItemsGrid.Name = "examItemsGrid";
            this.examItemsGrid.ReadOnly = true;
            this.examItemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examItemsGrid.Size = new System.Drawing.Size(400, 308);
            this.examItemsGrid.TabIndex = 0;
            this.examItemsGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.examItemsGrid_rowEnter);
            this.examItemsGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.examItemsGrid_rowAdded);
            // 
            // examQuestionsListLbl
            // 
            this.examQuestionsListLbl.AutoSize = true;
            this.examQuestionsListLbl.Location = new System.Drawing.Point(15, 83);
            this.examQuestionsListLbl.Name = "examQuestionsListLbl";
            this.examQuestionsListLbl.Size = new System.Drawing.Size(59, 13);
            this.examQuestionsListLbl.TabIndex = 1;
            this.examQuestionsListLbl.Text = "Total Items";
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.Location = new System.Drawing.Point(249, 106);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(75, 23);
            this.addQuestionBtn.TabIndex = 2;
            this.addQuestionBtn.Text = "Add Item...";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exam Name";
            // 
            // examName
            // 
            this.examName.Location = new System.Drawing.Point(85, 15);
            this.examName.Name = "examName";
            this.examName.Size = new System.Drawing.Size(121, 20);
            this.examName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exam Password";
            // 
            // examPassword
            // 
            this.examPassword.Location = new System.Drawing.Point(348, 40);
            this.examPassword.Name = "examPassword";
            this.examPassword.Size = new System.Drawing.Size(89, 20);
            this.examPassword.TabIndex = 7;
            this.examPassword.UseSystemPasswordChar = true;
            // 
            // totalQuestionsLbl
            // 
            this.totalQuestionsLbl.AutoSize = true;
            this.totalQuestionsLbl.Location = new System.Drawing.Point(113, 83);
            this.totalQuestionsLbl.Name = "totalQuestionsLbl";
            this.totalQuestionsLbl.Size = new System.Drawing.Size(40, 13);
            this.totalQuestionsLbl.TabIndex = 8;
            this.totalQuestionsLbl.Text = "0 items";
            // 
            // viewTypeDd
            // 
            this.viewTypeDd.FormattingEnabled = true;
            this.viewTypeDd.Items.AddRange(new object[] {
            "Section",
            "Question Type"});
            this.viewTypeDd.Location = new System.Drawing.Point(116, 105);
            this.viewTypeDd.Name = "viewTypeDd";
            this.viewTypeDd.Size = new System.Drawing.Size(93, 21);
            this.viewTypeDd.TabIndex = 9;
            // 
            // viewByLbl
            // 
            this.viewByLbl.AutoSize = true;
            this.viewByLbl.Location = new System.Drawing.Point(15, 109);
            this.viewByLbl.Name = "viewByLbl";
            this.viewByLbl.Size = new System.Drawing.Size(95, 13);
            this.viewByLbl.TabIndex = 10;
            this.viewByLbl.Text = "View Questions By";
            // 
            // addExamSectionBtn
            // 
            this.addExamSectionBtn.Location = new System.Drawing.Point(330, 106);
            this.addExamSectionBtn.Name = "addExamSectionBtn";
            this.addExamSectionBtn.Size = new System.Drawing.Size(82, 23);
            this.addExamSectionBtn.TabIndex = 11;
            this.addExamSectionBtn.Text = "Add Section...";
            this.addExamSectionBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Scheduled Exam Date";
            // 
            // examDate
            // 
            this.examDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.examDate.Location = new System.Drawing.Point(348, 14);
            this.examDate.Name = "examDate";
            this.examDate.Size = new System.Drawing.Size(89, 20);
            this.examDate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Exam Type";
            // 
            // examTypeDd
            // 
            this.examTypeDd.FormattingEnabled = true;
            this.examTypeDd.Items.AddRange(new object[] {
            "Quiz",
            "Long Quiz",
            "Long Exam",
            "Periodical Exam"});
            this.examTypeDd.Location = new System.Drawing.Point(85, 40);
            this.examTypeDd.Name = "examTypeDd";
            this.examTypeDd.Size = new System.Drawing.Size(121, 21);
            this.examTypeDd.TabIndex = 15;
            // 
            // exportExamBtn
            // 
            this.exportExamBtn.Location = new System.Drawing.Point(305, 78);
            this.exportExamBtn.Name = "exportExamBtn";
            this.exportExamBtn.Size = new System.Drawing.Size(107, 22);
            this.exportExamBtn.TabIndex = 17;
            this.exportExamBtn.Text = "Export to Word";
            this.exportExamBtn.UseVisualStyleBackColor = true;
            // 
            // exportAnsKeyBtn
            // 
            this.exportAnsKeyBtn.Location = new System.Drawing.Point(649, 74);
            this.exportAnsKeyBtn.Name = "exportAnsKeyBtn";
            this.exportAnsKeyBtn.Size = new System.Drawing.Size(104, 26);
            this.exportAnsKeyBtn.TabIndex = 18;
            this.exportAnsKeyBtn.Text = "Export Answer Key";
            this.exportAnsKeyBtn.UseVisualStyleBackColor = true;
            this.exportAnsKeyBtn.Click += new System.EventHandler(this.exportAnsKeyBtn_Click);
            // 
            // previewExamBtn
            // 
            this.previewExamBtn.Location = new System.Drawing.Point(649, 44);
            this.previewExamBtn.Name = "previewExamBtn";
            this.previewExamBtn.Size = new System.Drawing.Size(104, 24);
            this.previewExamBtn.TabIndex = 21;
            this.previewExamBtn.Text = "Print Preview";
            this.previewExamBtn.UseVisualStyleBackColor = true;
            // 
            // printExamBtn
            // 
            this.printExamBtn.Location = new System.Drawing.Point(649, 11);
            this.printExamBtn.Name = "printExamBtn";
            this.printExamBtn.Size = new System.Drawing.Size(104, 24);
            this.printExamBtn.TabIndex = 22;
            this.printExamBtn.Text = "Print Exam";
            this.printExamBtn.UseVisualStyleBackColor = true;
            // 
            // saveExamBtn
            // 
            this.saveExamBtn.Location = new System.Drawing.Point(678, 473);
            this.saveExamBtn.Name = "saveExamBtn";
            this.saveExamBtn.Size = new System.Drawing.Size(75, 24);
            this.saveExamBtn.TabIndex = 23;
            this.saveExamBtn.Text = "Save Exam";
            this.saveExamBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Prepared By:";
            // 
            // examPreparedBy
            // 
            this.examPreparedBy.AutoSize = true;
            this.examPreparedBy.Location = new System.Drawing.Point(539, 17);
            this.examPreparedBy.Name = "examPreparedBy";
            this.examPreparedBy.Size = new System.Drawing.Size(62, 13);
            this.examPreparedBy.TabIndex = 25;
            this.examPreparedBy.Text = "Anonymous";
            // 
            // examNameError
            // 
            this.examNameError.ContainerControl = this;
            // 
            // examPasswordError
            // 
            this.examPasswordError.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.faqImg);
            this.groupBox1.Controls.Add(this.itemNum);
            this.groupBox1.Controls.Add(this.itemTypeDd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.saveItem);
            this.groupBox1.Controls.Add(this.answerBox);
            this.groupBox1.Controls.Add(this.examQuestionDetails);
            this.groupBox1.Location = new System.Drawing.Point(441, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 343);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam Item";
            // 
            // itemTypeDd
            // 
            this.itemTypeDd.FormattingEnabled = true;
            this.itemTypeDd.Items.AddRange(new object[] {
            "Fill In the Blanks",
            "Multiple Choice",
            "Essay",
            "Identification"});
            this.itemTypeDd.Location = new System.Drawing.Point(62, 54);
            this.itemTypeDd.Name = "itemTypeDd";
            this.itemTypeDd.Size = new System.Drawing.Size(120, 21);
            this.itemTypeDd.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Item No.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 24);
            this.button2.TabIndex = 36;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // saveItem
            // 
            this.saveItem.Enabled = false;
            this.saveItem.Location = new System.Drawing.Point(232, 310);
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(75, 24);
            this.saveItem.TabIndex = 35;
            this.saveItem.Text = "Save Item";
            this.saveItem.UseVisualStyleBackColor = true;
            // 
            // answerBox
            // 
            this.answerBox.Controls.Add(this.answer);
            this.answerBox.Location = new System.Drawing.Point(6, 236);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(301, 68);
            this.answerBox.TabIndex = 34;
            this.answerBox.TabStop = false;
            this.answerBox.Text = "Answer";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(7, 19);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(288, 43);
            this.answer.TabIndex = 0;
            // 
            // examQuestionDetails
            // 
            this.examQuestionDetails.Controls.Add(this.questionTab);
            this.examQuestionDetails.Controls.Add(this.choicesTab);
            this.examQuestionDetails.Location = new System.Drawing.Point(6, 84);
            this.examQuestionDetails.Name = "examQuestionDetails";
            this.examQuestionDetails.SelectedIndex = 0;
            this.examQuestionDetails.Size = new System.Drawing.Size(301, 146);
            this.examQuestionDetails.TabIndex = 33;
            // 
            // questionTab
            // 
            this.questionTab.Controls.Add(this.question);
            this.questionTab.Location = new System.Drawing.Point(4, 22);
            this.questionTab.Name = "questionTab";
            this.questionTab.Padding = new System.Windows.Forms.Padding(3);
            this.questionTab.Size = new System.Drawing.Size(293, 120);
            this.questionTab.TabIndex = 0;
            this.questionTab.Text = "Question";
            this.questionTab.UseVisualStyleBackColor = true;
            // 
            // choicesTab
            // 
            this.choicesTab.Controls.Add(this.choicesList);
            this.choicesTab.Location = new System.Drawing.Point(4, 22);
            this.choicesTab.Name = "choicesTab";
            this.choicesTab.Padding = new System.Windows.Forms.Padding(3);
            this.choicesTab.Size = new System.Drawing.Size(293, 120);
            this.choicesTab.TabIndex = 1;
            this.choicesTab.Text = "Choices";
            this.choicesTab.UseVisualStyleBackColor = true;
            // 
            // itemNum
            // 
            this.itemNum.Location = new System.Drawing.Point(62, 28);
            this.itemNum.Name = "itemNum";
            this.itemNum.Size = new System.Drawing.Size(63, 20);
            this.itemNum.TabIndex = 41;
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(8, 6);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(279, 108);
            this.question.TabIndex = 1;
            // 
            // choicesList
            // 
            this.choicesList.FormattingEnabled = true;
            this.choicesList.Location = new System.Drawing.Point(7, 12);
            this.choicesList.Name = "choicesList";
            this.choicesList.Size = new System.Drawing.Size(280, 94);
            this.choicesList.TabIndex = 0;
            // 
            // saveItemTooltip
            // 
            this.saveItemTooltip.IsBalloon = true;
            // 
            // faqImg
            // 
            this.faqImg.Location = new System.Drawing.Point(193, 305);
            this.faqImg.Name = "faqImg";
            this.faqImg.Size = new System.Drawing.Size(33, 33);
            this.faqImg.TabIndex = 43;
            this.faqImg.TabStop = false;
            // 
            // ExamScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.examPreparedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveExamBtn);
            this.Controls.Add(this.printExamBtn);
            this.Controls.Add(this.previewExamBtn);
            this.Controls.Add(this.exportAnsKeyBtn);
            this.Controls.Add(this.exportExamBtn);
            this.Controls.Add(this.examTypeDd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.examDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addExamSectionBtn);
            this.Controls.Add(this.viewByLbl);
            this.Controls.Add(this.viewTypeDd);
            this.Controls.Add(this.totalQuestionsLbl);
            this.Controls.Add(this.examPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.examName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addQuestionBtn);
            this.Controls.Add(this.examQuestionsListLbl);
            this.Controls.Add(this.examItemsGrid);
            this.Name = "ExamScreen";
            this.Text = "Create New Exam";
            this.Load += new System.EventHandler(this.ExamScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examItemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examPasswordError)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.answerBox.ResumeLayout(false);
            this.answerBox.PerformLayout();
            this.examQuestionDetails.ResumeLayout(false);
            this.questionTab.ResumeLayout(false);
            this.questionTab.PerformLayout();
            this.choicesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faqImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView examItemsGrid;
        private System.Windows.Forms.Label examQuestionsListLbl;
        private System.Windows.Forms.Button addQuestionBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox examName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox examPassword;
        private System.Windows.Forms.Label totalQuestionsLbl;
        private System.Windows.Forms.ComboBox viewTypeDd;
        private System.Windows.Forms.Label viewByLbl;
        private System.Windows.Forms.Button addExamSectionBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker examDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox examTypeDd;
        private System.Windows.Forms.Button exportExamBtn;
        private System.Windows.Forms.Button exportAnsKeyBtn;
        private System.Windows.Forms.Button previewExamBtn;
        private System.Windows.Forms.Button printExamBtn;
        private System.Windows.Forms.Button saveExamBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label examPreparedBy;
        private System.Windows.Forms.ErrorProvider examNameError;
        private System.Windows.Forms.ErrorProvider examPasswordError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox itemTypeDd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveItem;
        private System.Windows.Forms.GroupBox answerBox;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.TabControl examQuestionDetails;
        private System.Windows.Forms.TabPage questionTab;
        private System.Windows.Forms.TabPage choicesTab;
        private System.Windows.Forms.NumericUpDown itemNum;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.CheckedListBox choicesList;
        private System.Windows.Forms.ToolTip saveItemTooltip;
        private System.Windows.Forms.PictureBox faqImg;
    }
}