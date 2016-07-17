namespace ExamMaker.Views
{
    partial class MainMenuScreen
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
            this.createNewExamBtn = new System.Windows.Forms.Button();
            this.viewOrEditExamBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewExamBtn
            // 
            this.createNewExamBtn.Location = new System.Drawing.Point(13, 29);
            this.createNewExamBtn.Name = "createNewExamBtn";
            this.createNewExamBtn.Size = new System.Drawing.Size(151, 34);
            this.createNewExamBtn.TabIndex = 0;
            this.createNewExamBtn.Text = "Create New Exam";
            this.createNewExamBtn.UseVisualStyleBackColor = true;
            this.createNewExamBtn.Click += new System.EventHandler(this.createNewExamBtn_Click);
            // 
            // viewOrEditExamBtn
            // 
            this.viewOrEditExamBtn.Location = new System.Drawing.Point(13, 69);
            this.viewOrEditExamBtn.Name = "viewOrEditExamBtn";
            this.viewOrEditExamBtn.Size = new System.Drawing.Size(151, 34);
            this.viewOrEditExamBtn.TabIndex = 1;
            this.viewOrEditExamBtn.Text = "View / Edit / Delete Exam";
            this.viewOrEditExamBtn.UseVisualStyleBackColor = true;
            this.viewOrEditExamBtn.Click += new System.EventHandler(this.viewOrEditExamBtn_Click);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 364);
            this.Controls.Add(this.viewOrEditExamBtn);
            this.Controls.Add(this.createNewExamBtn);
            this.Name = "MainMenuScreen";
            this.Text = "Exam Maker Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewExamBtn;
        private System.Windows.Forms.Button viewOrEditExamBtn;
    }
}

