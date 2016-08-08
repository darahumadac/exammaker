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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.createNewExamBtn = new System.Windows.Forms.Button();
            this.viewOrEditExamBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createNewExamBtn
            // 
            this.createNewExamBtn.Image = ((System.Drawing.Image)(resources.GetObject("createNewExamBtn.Image")));
            this.createNewExamBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewExamBtn.Location = new System.Drawing.Point(13, 53);
            this.createNewExamBtn.Name = "createNewExamBtn";
            this.createNewExamBtn.Size = new System.Drawing.Size(133, 43);
            this.createNewExamBtn.TabIndex = 0;
            this.createNewExamBtn.Text = "Create New Exam";
            this.createNewExamBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createNewExamBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createNewExamBtn.UseVisualStyleBackColor = true;
            this.createNewExamBtn.Click += new System.EventHandler(this.createNewExamBtn_Click);
            // 
            // viewOrEditExamBtn
            // 
            this.viewOrEditExamBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewOrEditExamBtn.Image")));
            this.viewOrEditExamBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewOrEditExamBtn.Location = new System.Drawing.Point(181, 53);
            this.viewOrEditExamBtn.Name = "viewOrEditExamBtn";
            this.viewOrEditExamBtn.Size = new System.Drawing.Size(133, 43);
            this.viewOrEditExamBtn.TabIndex = 1;
            this.viewOrEditExamBtn.Text = "View/Edit Exam";
            this.viewOrEditExamBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewOrEditExamBtn.UseVisualStyleBackColor = true;
            this.viewOrEditExamBtn.Click += new System.EventHandler(this.viewOrEditExamBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(12, 19);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(72, 13);
            this.welcomeLbl.TabIndex = 2;
            this.welcomeLbl.Text = "Welcome, {0}";
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 163);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.viewOrEditExamBtn);
            this.Controls.Add(this.createNewExamBtn);
            this.Name = "MainMenuScreen";
            this.Text = "Exam Maker Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewExamBtn;
        private System.Windows.Forms.Button viewOrEditExamBtn;
        private System.Windows.Forms.Label welcomeLbl;
    }
}

