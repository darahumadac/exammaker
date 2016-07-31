namespace ExamMaker.Views.Basic
{
    partial class AddChoiceScreen
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
            this.addChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optionDescription = new System.Windows.Forms.TextBox();
            this.optionName = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addChoice
            // 
            this.addChoice.Location = new System.Drawing.Point(175, 77);
            this.addChoice.Name = "addChoice";
            this.addChoice.Size = new System.Drawing.Size(70, 21);
            this.addChoice.TabIndex = 0;
            this.addChoice.Text = "OK";
            this.addChoice.UseVisualStyleBackColor = true;
            this.addChoice.Click += new System.EventHandler(this.addChoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Option Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Option Description";
            // 
            // optionDescription
            // 
            this.optionDescription.Location = new System.Drawing.Point(121, 40);
            this.optionDescription.Name = "optionDescription";
            this.optionDescription.Size = new System.Drawing.Size(124, 20);
            this.optionDescription.TabIndex = 3;
            // 
            // optionName
            // 
            this.optionName.Location = new System.Drawing.Point(121, 17);
            this.optionName.Name = "optionName";
            this.optionName.Size = new System.Drawing.Size(77, 20);
            this.optionName.TabIndex = 4;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 77);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 21);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddChoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 110);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.optionName);
            this.Controls.Add(this.optionDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addChoice);
            this.Name = "AddChoiceScreen";
            this.Text = "AddChoiceScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox optionDescription;
        private System.Windows.Forms.TextBox optionName;
        private System.Windows.Forms.Button cancel;
    }
}