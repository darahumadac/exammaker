namespace ExamMaker.Views.Premium
{
    partial class ExamScreenWithQuestionBank
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
            this.label8 = new System.Windows.Forms.Label();
            this.exportExamBtn = new System.Windows.Forms.Button();
            this.examTypeDd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.examDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.viewByLbl = new System.Windows.Forms.Label();
            this.viewTypeDd = new System.Windows.Forms.ComboBox();
            this.totalQuestionsLbl = new System.Windows.Forms.Label();
            this.examPassword = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.examName = new System.Windows.Forms.TextBox();
            this.examQuestionsListLbl = new System.Windows.Forms.Label();
            this.examItemsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Exam Name";
            // 
            // exportExamBtn
            // 
            this.exportExamBtn.Location = new System.Drawing.Point(617, 9);
            this.exportExamBtn.Name = "exportExamBtn";
            this.exportExamBtn.Size = new System.Drawing.Size(82, 22);
            this.exportExamBtn.TabIndex = 41;
            this.exportExamBtn.Text = "Export Exam";
            this.exportExamBtn.UseVisualStyleBackColor = true;
            // 
            // examTypeDd
            // 
            this.examTypeDd.FormattingEnabled = true;
            this.examTypeDd.Items.AddRange(new object[] {
            "Quiz",
            "Long Quiz",
            "Long Exam",
            "Periodical Exam"});
            this.examTypeDd.Location = new System.Drawing.Point(85, 35);
            this.examTypeDd.Name = "examTypeDd";
            this.examTypeDd.Size = new System.Drawing.Size(121, 21);
            this.examTypeDd.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Exam Type";
            // 
            // examDate
            // 
            this.examDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.examDate.Location = new System.Drawing.Point(337, 10);
            this.examDate.Name = "examDate";
            this.examDate.Size = new System.Drawing.Size(89, 20);
            this.examDate.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Scheduled Exam Date";
            // 
            // viewByLbl
            // 
            this.viewByLbl.AutoSize = true;
            this.viewByLbl.Location = new System.Drawing.Point(15, 63);
            this.viewByLbl.Name = "viewByLbl";
            this.viewByLbl.Size = new System.Drawing.Size(43, 13);
            this.viewByLbl.TabIndex = 35;
            this.viewByLbl.Text = "Subject";
            // 
            // viewTypeDd
            // 
            this.viewTypeDd.FormattingEnabled = true;
            this.viewTypeDd.Items.AddRange(new object[] {
            "Section",
            "Question Type"});
            this.viewTypeDd.Location = new System.Drawing.Point(85, 62);
            this.viewTypeDd.Name = "viewTypeDd";
            this.viewTypeDd.Size = new System.Drawing.Size(93, 21);
            this.viewTypeDd.TabIndex = 34;
            // 
            // totalQuestionsLbl
            // 
            this.totalQuestionsLbl.AutoSize = true;
            this.totalQuestionsLbl.Location = new System.Drawing.Point(561, 43);
            this.totalQuestionsLbl.Name = "totalQuestionsLbl";
            this.totalQuestionsLbl.Size = new System.Drawing.Size(40, 13);
            this.totalQuestionsLbl.TabIndex = 33;
            this.totalQuestionsLbl.Text = "0 items";
            // 
            // examPassword
            // 
            this.examPassword.Location = new System.Drawing.Point(337, 36);
            this.examPassword.Name = "examPassword";
            this.examPassword.Size = new System.Drawing.Size(89, 20);
            this.examPassword.TabIndex = 32;
            this.examPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Exam Password";
            // 
            // examName
            // 
            this.examName.Location = new System.Drawing.Point(85, 10);
            this.examName.Name = "examName";
            this.examName.Size = new System.Drawing.Size(121, 20);
            this.examName.TabIndex = 30;
            // 
            // examQuestionsListLbl
            // 
            this.examQuestionsListLbl.AutoSize = true;
            this.examQuestionsListLbl.Location = new System.Drawing.Point(463, 43);
            this.examQuestionsListLbl.Name = "examQuestionsListLbl";
            this.examQuestionsListLbl.Size = new System.Drawing.Size(59, 13);
            this.examQuestionsListLbl.TabIndex = 29;
            this.examQuestionsListLbl.Text = "Total Items";
            // 
            // examItemsGrid
            // 
            this.examItemsGrid.AllowUserToAddRows = false;
            this.examItemsGrid.AllowUserToDeleteRows = false;
            this.examItemsGrid.AllowUserToOrderColumns = true;
            this.examItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examItemsGrid.Location = new System.Drawing.Point(12, 149);
            this.examItemsGrid.MultiSelect = false;
            this.examItemsGrid.Name = "examItemsGrid";
            this.examItemsGrid.ReadOnly = true;
            this.examItemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examItemsGrid.Size = new System.Drawing.Size(414, 324);
            this.examItemsGrid.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Topic";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Section",
            "Question Type"});
            this.comboBox1.Location = new System.Drawing.Point(85, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Subtopic";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Section",
            "Question Type"});
            this.comboBox2.Location = new System.Drawing.Point(333, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 21);
            this.comboBox2.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Difficulty";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Section",
            "Question Type"});
            this.comboBox3.Location = new System.Drawing.Point(333, 64);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(93, 21);
            this.comboBox3.TabIndex = 47;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(460, 65);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(239, 408);
            this.treeView1.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Exam Area";
            // 
            // ExamScreenWithQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exportExamBtn);
            this.Controls.Add(this.examTypeDd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.examDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.viewByLbl);
            this.Controls.Add(this.viewTypeDd);
            this.Controls.Add(this.totalQuestionsLbl);
            this.Controls.Add(this.examPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.examName);
            this.Controls.Add(this.examQuestionsListLbl);
            this.Controls.Add(this.examItemsGrid);
            this.Name = "ExamScreenWithQuestionBank";
            this.Text = "ExamScreenWithQuestionBank";
            ((System.ComponentModel.ISupportInitialize)(this.examItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exportExamBtn;
        private System.Windows.Forms.ComboBox examTypeDd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker examDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label viewByLbl;
        private System.Windows.Forms.ComboBox viewTypeDd;
        private System.Windows.Forms.Label totalQuestionsLbl;
        private System.Windows.Forms.MaskedTextBox examPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox examName;
        private System.Windows.Forms.Label examQuestionsListLbl;
        private System.Windows.Forms.DataGridView examItemsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label5;
    }
}