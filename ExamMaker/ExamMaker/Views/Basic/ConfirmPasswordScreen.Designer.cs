namespace ExamMaker.Views.Basic
{
    partial class ConfirmPasswordScreen
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
            this.updateMsg = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.updatePwBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentPw = new System.Windows.Forms.Label();
            this.newPasswordTxt = new System.Windows.Forms.MaskedTextBox();
            this.currentPwText = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmNewPwTxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // updateMsg
            // 
            this.updateMsg.AutoSize = true;
            this.updateMsg.ForeColor = System.Drawing.Color.Red;
            this.updateMsg.Location = new System.Drawing.Point(67, 99);
            this.updateMsg.Name = "updateMsg";
            this.updateMsg.Size = new System.Drawing.Size(98, 13);
            this.updateMsg.TabIndex = 21;
            this.updateMsg.Text = "Incorrect Password";
            this.updateMsg.Visible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(124, 115);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 20;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // updatePwBtn
            // 
            this.updatePwBtn.Location = new System.Drawing.Point(43, 115);
            this.updatePwBtn.Name = "updatePwBtn";
            this.updatePwBtn.Size = new System.Drawing.Size(75, 23);
            this.updatePwBtn.TabIndex = 19;
            this.updatePwBtn.Text = "Update";
            this.updatePwBtn.UseVisualStyleBackColor = true;
            this.updatePwBtn.Click += new System.EventHandler(this.updatePwBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "New Password";
            // 
            // currentPw
            // 
            this.currentPw.AutoSize = true;
            this.currentPw.Location = new System.Drawing.Point(12, 15);
            this.currentPw.Name = "currentPw";
            this.currentPw.Size = new System.Drawing.Size(90, 13);
            this.currentPw.TabIndex = 17;
            this.currentPw.Text = "Current Password";
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Location = new System.Drawing.Point(114, 38);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.Size = new System.Drawing.Size(104, 20);
            this.newPasswordTxt.TabIndex = 22;
            this.newPasswordTxt.UseSystemPasswordChar = true;
            // 
            // currentPwText
            // 
            this.currentPwText.Location = new System.Drawing.Point(114, 12);
            this.currentPwText.Name = "currentPwText";
            this.currentPwText.Size = new System.Drawing.Size(104, 20);
            this.currentPwText.TabIndex = 16;
            this.currentPwText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Confirm Password";
            // 
            // confirmNewPwTxt
            // 
            this.confirmNewPwTxt.Location = new System.Drawing.Point(114, 65);
            this.confirmNewPwTxt.Name = "confirmNewPwTxt";
            this.confirmNewPwTxt.Size = new System.Drawing.Size(104, 20);
            this.confirmNewPwTxt.TabIndex = 23;
            this.confirmNewPwTxt.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmNewPwTxt);
            this.Controls.Add(this.currentPwText);
            this.Controls.Add(this.updateMsg);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.updatePwBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPw);
            this.Controls.Add(this.newPasswordTxt);
            this.Name = "ConfirmPasswordScreen";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.ConfirmPasswordScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateMsg;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button updatePwBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentPw;
        private System.Windows.Forms.MaskedTextBox newPasswordTxt;
        private System.Windows.Forms.MaskedTextBox currentPwText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox confirmNewPwTxt;

    }
}