namespace ExamMaker.Views.Basic
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
            this.examName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.examPassword = new System.Windows.Forms.MaskedTextBox();
            this.totalQuestionsLbl = new System.Windows.Forms.Label();
            this.viewTypeDd = new System.Windows.Forms.ComboBox();
            this.viewByLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
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
            this.discardChanges = new System.Windows.Forms.Button();
            this.saveOrder = new System.Windows.Forms.Button();
            this.itemTypeLbl = new System.Windows.Forms.Label();
            this.faqImg = new System.Windows.Forms.PictureBox();
            this.itemNum = new System.Windows.Forms.NumericUpDown();
            this.itemTypeDd = new System.Windows.Forms.ComboBox();
            this.itemNumLbl = new System.Windows.Forms.Label();
            this.saveItem = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.GroupBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.examQuestionDetails = new System.Windows.Forms.TabControl();
            this.questionTab = new System.Windows.Forms.TabPage();
            this.question = new System.Windows.Forms.TextBox();
            this.choicesTab = new System.Windows.Forms.TabPage();
            this.editChoice = new System.Windows.Forms.Button();
            this.deleteChoice = new System.Windows.Forms.Button();
            this.addChoiceBtn = new System.Windows.Forms.Button();
            this.choicesList = new System.Windows.Forms.CheckedListBox();
            this.previewTab = new System.Windows.Forms.TabPage();
            this.editItemBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveItemTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.deleteItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examItemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examPasswordError)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faqImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNum)).BeginInit();
            this.answerBox.SuspendLayout();
            this.examQuestionDetails.SuspendLayout();
            this.questionTab.SuspendLayout();
            this.choicesTab.SuspendLayout();
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
            this.examItemsGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.examItemsGrid_rowAdded);
            this.examItemsGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.examItemsGrid_rowRemoved);
            this.examItemsGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.examItemsGrid_rowValidating);
            this.examItemsGrid.SelectionChanged += new System.EventHandler(this.examItemsGrid_selectionChanged);
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
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(242, 107);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(82, 23);
            this.addItemBtn.TabIndex = 11;
            this.addItemBtn.Text = "Add Item...";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
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
            this.exportExamBtn.Location = new System.Drawing.Point(330, 78);
            this.exportExamBtn.Name = "exportExamBtn";
            this.exportExamBtn.Size = new System.Drawing.Size(82, 22);
            this.exportExamBtn.TabIndex = 17;
            this.exportExamBtn.Text = "Export Exam";
            this.exportExamBtn.UseVisualStyleBackColor = true;
            this.exportExamBtn.Click += new System.EventHandler(this.exportExamBtn_Click);
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
            this.saveExamBtn.Click += new System.EventHandler(this.saveExamBtn_Click);
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
            this.groupBox1.Controls.Add(this.discardChanges);
            this.groupBox1.Controls.Add(this.saveOrder);
            this.groupBox1.Controls.Add(this.itemTypeLbl);
            this.groupBox1.Controls.Add(this.faqImg);
            this.groupBox1.Controls.Add(this.itemNum);
            this.groupBox1.Controls.Add(this.itemTypeDd);
            this.groupBox1.Controls.Add(this.itemNumLbl);
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
            // discardChanges
            // 
            this.discardChanges.CausesValidation = false;
            this.discardChanges.Enabled = false;
            this.discardChanges.Location = new System.Drawing.Point(13, 310);
            this.discardChanges.Name = "discardChanges";
            this.discardChanges.Size = new System.Drawing.Size(75, 24);
            this.discardChanges.TabIndex = 47;
            this.discardChanges.Text = "Cancel";
            this.discardChanges.UseVisualStyleBackColor = true;
            this.discardChanges.Click += new System.EventHandler(this.discardChanges_Click);
            // 
            // saveOrder
            // 
            this.saveOrder.Location = new System.Drawing.Point(228, 24);
            this.saveOrder.Name = "saveOrder";
            this.saveOrder.Size = new System.Drawing.Size(75, 24);
            this.saveOrder.TabIndex = 46;
            this.saveOrder.Text = "Save Order";
            this.saveOrder.UseVisualStyleBackColor = true;
            this.saveOrder.Click += new System.EventHandler(this.saveOrder_Click);
            // 
            // itemTypeLbl
            // 
            this.itemTypeLbl.AutoSize = true;
            this.itemTypeLbl.Enabled = false;
            this.itemTypeLbl.Location = new System.Drawing.Point(3, 57);
            this.itemTypeLbl.Name = "itemTypeLbl";
            this.itemTypeLbl.Size = new System.Drawing.Size(54, 13);
            this.itemTypeLbl.TabIndex = 44;
            this.itemTypeLbl.Text = "Item Type";
            // 
            // faqImg
            // 
            this.faqImg.Location = new System.Drawing.Point(193, 305);
            this.faqImg.Name = "faqImg";
            this.faqImg.Size = new System.Drawing.Size(33, 33);
            this.faqImg.TabIndex = 43;
            this.faqImg.TabStop = false;
            // 
            // itemNum
            // 
            this.itemNum.Location = new System.Drawing.Point(62, 28);
            this.itemNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemNum.Name = "itemNum";
            this.itemNum.Size = new System.Drawing.Size(63, 20);
            this.itemNum.TabIndex = 41;
            this.itemNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemNum.ValueChanged += new System.EventHandler(this.itemNum_valueChanged);
            // 
            // itemTypeDd
            // 
            this.itemTypeDd.Enabled = false;
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
            this.itemTypeDd.SelectedIndexChanged += new System.EventHandler(this.itemTypeDd_selectedIndexChanged);
            // 
            // itemNumLbl
            // 
            this.itemNumLbl.AutoSize = true;
            this.itemNumLbl.Location = new System.Drawing.Point(10, 32);
            this.itemNumLbl.Name = "itemNumLbl";
            this.itemNumLbl.Size = new System.Drawing.Size(47, 13);
            this.itemNumLbl.TabIndex = 37;
            this.itemNumLbl.Text = "Item No.";
            // 
            // saveItem
            // 
            this.saveItem.CausesValidation = false;
            this.saveItem.Enabled = false;
            this.saveItem.Location = new System.Drawing.Point(232, 310);
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(75, 24);
            this.saveItem.TabIndex = 35;
            this.saveItem.Text = "Save Item";
            this.saveItem.UseVisualStyleBackColor = true;
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // answerBox
            // 
            this.answerBox.Controls.Add(this.answer);
            this.answerBox.Enabled = false;
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
            this.examQuestionDetails.Controls.Add(this.previewTab);
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
            // question
            // 
            this.question.Enabled = false;
            this.question.Location = new System.Drawing.Point(8, 6);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(279, 108);
            this.question.TabIndex = 1;
            // 
            // choicesTab
            // 
            this.choicesTab.Controls.Add(this.editChoice);
            this.choicesTab.Controls.Add(this.deleteChoice);
            this.choicesTab.Controls.Add(this.addChoiceBtn);
            this.choicesTab.Controls.Add(this.choicesList);
            this.choicesTab.Location = new System.Drawing.Point(4, 22);
            this.choicesTab.Name = "choicesTab";
            this.choicesTab.Padding = new System.Windows.Forms.Padding(3);
            this.choicesTab.Size = new System.Drawing.Size(293, 120);
            this.choicesTab.TabIndex = 1;
            this.choicesTab.Text = "Choices";
            this.choicesTab.UseVisualStyleBackColor = true;
            // 
            // editChoice
            // 
            this.editChoice.Enabled = false;
            this.editChoice.Location = new System.Drawing.Point(131, 94);
            this.editChoice.Name = "editChoice";
            this.editChoice.Size = new System.Drawing.Size(75, 23);
            this.editChoice.TabIndex = 3;
            this.editChoice.Text = "Edit Choice";
            this.editChoice.UseVisualStyleBackColor = true;
            this.editChoice.Click += new System.EventHandler(this.editChoice_Click);
            // 
            // deleteChoice
            // 
            this.deleteChoice.Enabled = false;
            this.deleteChoice.Location = new System.Drawing.Point(7, 94);
            this.deleteChoice.Name = "deleteChoice";
            this.deleteChoice.Size = new System.Drawing.Size(92, 23);
            this.deleteChoice.TabIndex = 2;
            this.deleteChoice.Text = "Delete Choice";
            this.deleteChoice.UseVisualStyleBackColor = true;
            this.deleteChoice.Click += new System.EventHandler(this.deleteChoice_Click);
            // 
            // addChoiceBtn
            // 
            this.addChoiceBtn.Enabled = false;
            this.addChoiceBtn.Location = new System.Drawing.Point(212, 94);
            this.addChoiceBtn.Name = "addChoiceBtn";
            this.addChoiceBtn.Size = new System.Drawing.Size(75, 23);
            this.addChoiceBtn.TabIndex = 1;
            this.addChoiceBtn.Text = "Add Choice";
            this.addChoiceBtn.UseVisualStyleBackColor = true;
            this.addChoiceBtn.Click += new System.EventHandler(this.addChoiceBtn_Click);
            // 
            // choicesList
            // 
            this.choicesList.Enabled = false;
            this.choicesList.FormattingEnabled = true;
            this.choicesList.Location = new System.Drawing.Point(7, 12);
            this.choicesList.Name = "choicesList";
            this.choicesList.Size = new System.Drawing.Size(280, 79);
            this.choicesList.TabIndex = 0;
            this.choicesList.SelectedIndexChanged += new System.EventHandler(this.choicesList_selectedIndexChanged);
            // 
            // previewTab
            // 
            this.previewTab.Location = new System.Drawing.Point(4, 22);
            this.previewTab.Name = "previewTab";
            this.previewTab.Size = new System.Drawing.Size(293, 120);
            this.previewTab.TabIndex = 2;
            this.previewTab.Text = "Question Preview";
            this.previewTab.UseVisualStyleBackColor = true;
            // 
            // editItemBtn
            // 
            this.editItemBtn.Location = new System.Drawing.Point(330, 106);
            this.editItemBtn.Name = "editItemBtn";
            this.editItemBtn.Size = new System.Drawing.Size(82, 24);
            this.editItemBtn.TabIndex = 45;
            this.editItemBtn.Text = "Edit Item";
            this.editItemBtn.UseVisualStyleBackColor = true;
            this.editItemBtn.Click += new System.EventHandler(this.editItemBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 455);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(98, 24);
            this.resetBtn.TabIndex = 36;
            this.resetBtn.Text = "Reset Order";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // saveItemTooltip
            // 
            this.saveItemTooltip.IsBalloon = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Exam Name";
            // 
            // deleteItem
            // 
            this.deleteItem.Location = new System.Drawing.Point(330, 455);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(82, 23);
            this.deleteItem.TabIndex = 46;
            this.deleteItem.Text = "Delete Item";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // ExamScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(765, 509);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editItemBtn);
            this.Controls.Add(this.examPreparedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveExamBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.printExamBtn);
            this.Controls.Add(this.previewExamBtn);
            this.Controls.Add(this.exportAnsKeyBtn);
            this.Controls.Add(this.exportExamBtn);
            this.Controls.Add(this.examTypeDd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.examDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.viewByLbl);
            this.Controls.Add(this.viewTypeDd);
            this.Controls.Add(this.totalQuestionsLbl);
            this.Controls.Add(this.examPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.examName);
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
            ((System.ComponentModel.ISupportInitialize)(this.faqImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNum)).EndInit();
            this.answerBox.ResumeLayout(false);
            this.answerBox.PerformLayout();
            this.examQuestionDetails.ResumeLayout(false);
            this.questionTab.ResumeLayout(false);
            this.questionTab.PerformLayout();
            this.choicesTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView examItemsGrid;
        private System.Windows.Forms.Label examQuestionsListLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox examName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox examPassword;
        private System.Windows.Forms.Label totalQuestionsLbl;
        private System.Windows.Forms.ComboBox viewTypeDd;
        private System.Windows.Forms.Label viewByLbl;
        private System.Windows.Forms.Button addItemBtn;
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
        private System.Windows.Forms.Label itemNumLbl;
        private System.Windows.Forms.Button resetBtn;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage previewTab;
        private System.Windows.Forms.Label itemTypeLbl;
        private System.Windows.Forms.Button addChoiceBtn;
        private System.Windows.Forms.Button editItemBtn;
        private System.Windows.Forms.Button saveOrder;
        private System.Windows.Forms.Button discardChanges;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Button deleteChoice;
        private System.Windows.Forms.Button editChoice;
    }
}