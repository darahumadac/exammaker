namespace ExamMaker.Views
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
            this.viewOrEditExamBtn = new System.Windows.Forms.Button();
            this.discardExamBtn = new System.Windows.Forms.Button();
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
            this.examListGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.examListGrid_rowsAdded);
            // 
            // examListLbl
            // 
            this.examListLbl.AutoSize = true;
            this.examListLbl.Location = new System.Drawing.Point(9, 46);
            this.examListLbl.Name = "examListLbl";
            this.examListLbl.Size = new System.Drawing.Size(77, 13);
            this.examListLbl.TabIndex = 1;
            this.examListLbl.Text = "Your Exam List";
            // 
            // totalExamsLbl
            // 
            this.totalExamsLbl.AutoSize = true;
            this.totalExamsLbl.Location = new System.Drawing.Point(511, 46);
            this.totalExamsLbl.Name = "totalExamsLbl";
            this.totalExamsLbl.Size = new System.Drawing.Size(47, 13);
            this.totalExamsLbl.TabIndex = 2;
            this.totalExamsLbl.Text = "0 Exams";
            // 
            // viewOrEditExamBtn
            // 
            this.viewOrEditExamBtn.Location = new System.Drawing.Point(590, 41);
            this.viewOrEditExamBtn.Name = "viewOrEditExamBtn";
            this.viewOrEditExamBtn.Size = new System.Drawing.Size(107, 23);
            this.viewOrEditExamBtn.TabIndex = 4;
            this.viewOrEditExamBtn.Text = "View / Edit Exam";
            this.viewOrEditExamBtn.UseVisualStyleBackColor = true;
            this.viewOrEditExamBtn.Click += new System.EventHandler(this.viewOrEditExamBtn_Click);
            // 
            // discardExamBtn
            // 
            this.discardExamBtn.Location = new System.Drawing.Point(603, 408);
            this.discardExamBtn.Name = "discardExamBtn";
            this.discardExamBtn.Size = new System.Drawing.Size(94, 24);
            this.discardExamBtn.TabIndex = 21;
            this.discardExamBtn.Text = "Delete Exam";
            this.discardExamBtn.UseVisualStyleBackColor = true;
            // 
            // ExamListScreen
            // 
            this.AcceptButton = this.viewOrEditExamBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 442);
            this.Controls.Add(this.discardExamBtn);
            this.Controls.Add(this.viewOrEditExamBtn);
            this.Controls.Add(this.totalExamsLbl);
            this.Controls.Add(this.examListLbl);
            this.Controls.Add(this.examListGrid);
            this.Name = "ExamListScreen";
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
        private System.Windows.Forms.Button viewOrEditExamBtn;
        private System.Windows.Forms.Button discardExamBtn;
    }
}