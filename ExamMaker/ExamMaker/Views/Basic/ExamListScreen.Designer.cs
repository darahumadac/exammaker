namespace ExamMaker.Views.Basic
{
    partial class ExamListScreen
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
            this.examListGrid = new System.Windows.Forms.DataGridView();
            this.examListLbl = new System.Windows.Forms.Label();
            this.totalExamsLbl = new System.Windows.Forms.Label();
            this.deleteExamBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchExamNameTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.viewOrEditExamBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // examListGrid
            // 
            this.examListGrid.AllowUserToAddRows = false;
            this.examListGrid.AllowUserToDeleteRows = false;
            this.examListGrid.AllowUserToResizeRows = false;
            this.examListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examListGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.examListGrid.Location = new System.Drawing.Point(12, 70);
            this.examListGrid.MultiSelect = false;
            this.examListGrid.Name = "examListGrid";
            this.examListGrid.ReadOnly = true;
            this.examListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examListGrid.Size = new System.Drawing.Size(685, 332);
            this.examListGrid.TabIndex = 0;
            this.examListGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.examListGrid_dataBindingComplete);
            this.examListGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.examListGrid_rowsAdded);
            // 
            // examListLbl
            // 
            this.examListLbl.AutoSize = true;
            this.examListLbl.Location = new System.Drawing.Point(14, 9);
            this.examListLbl.Name = "examListLbl";
            this.examListLbl.Size = new System.Drawing.Size(79, 13);
            this.examListLbl.TabIndex = 1;
            this.examListLbl.Text = "Search Results";
            // 
            // totalExamsLbl
            // 
            this.totalExamsLbl.AutoSize = true;
            this.totalExamsLbl.Location = new System.Drawing.Point(102, 9);
            this.totalExamsLbl.Name = "totalExamsLbl";
            this.totalExamsLbl.Size = new System.Drawing.Size(47, 13);
            this.totalExamsLbl.TabIndex = 2;
            this.totalExamsLbl.Text = "0 Exams";
            // 
            // deleteExamBtn
            // 
            this.deleteExamBtn.Location = new System.Drawing.Point(603, 408);
            this.deleteExamBtn.Name = "deleteExamBtn";
            this.deleteExamBtn.Size = new System.Drawing.Size(94, 24);
            this.deleteExamBtn.TabIndex = 21;
            this.deleteExamBtn.Text = "Delete Exam";
            this.deleteExamBtn.UseVisualStyleBackColor = true;
            this.deleteExamBtn.Click += new System.EventHandler(this.deleteExamBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.copyBtn.Location = new System.Drawing.Point(606, 41);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(91, 23);
            this.copyBtn.TabIndex = 22;
            this.copyBtn.Text = "Copy Exam";
            this.copyBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search Exam";
            // 
            // searchExamNameTxt
            // 
            this.searchExamNameTxt.Location = new System.Drawing.Point(105, 43);
            this.searchExamNameTxt.Name = "searchExamNameTxt";
            this.searchExamNameTxt.Size = new System.Drawing.Size(134, 20);
            this.searchExamNameTxt.TabIndex = 24;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(245, 41);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(53, 23);
            this.searchBtn.TabIndex = 25;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // viewOrEditExamBtn
            // 
            this.viewOrEditExamBtn.Location = new System.Drawing.Point(493, 40);
            this.viewOrEditExamBtn.Name = "viewOrEditExamBtn";
            this.viewOrEditExamBtn.Size = new System.Drawing.Size(107, 23);
            this.viewOrEditExamBtn.TabIndex = 26;
            this.viewOrEditExamBtn.Text = "View / Edit Exam";
            this.viewOrEditExamBtn.UseVisualStyleBackColor = true;
            this.viewOrEditExamBtn.Click += new System.EventHandler(this.viewOrEditExamBtn_Click);
            // 
            // ExamListScreen
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 442);
            this.Controls.Add(this.viewOrEditExamBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchExamNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.deleteExamBtn);
            this.Controls.Add(this.totalExamsLbl);
            this.Controls.Add(this.examListLbl);
            this.Controls.Add(this.examListGrid);
            this.MaximizeBox = false;
            this.Name = "ExamListScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam List";
            this.Load += new System.EventHandler(this.ExamListScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView examListGrid;
        private System.Windows.Forms.Label examListLbl;
        private System.Windows.Forms.Label totalExamsLbl;
        private System.Windows.Forms.Button deleteExamBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchExamNameTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button viewOrEditExamBtn;
    }
}