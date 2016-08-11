namespace ExamMaker.Views.Basic
{
    partial class ManageUserScreen
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
            this.userListGridView = new System.Windows.Forms.DataGridView();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.changePwBtn = new System.Windows.Forms.Button();
            this.usernameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userListGridView
            // 
            this.userListGridView.AllowUserToAddRows = false;
            this.userListGridView.AllowUserToDeleteRows = false;
            this.userListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListGridView.Location = new System.Drawing.Point(12, 64);
            this.userListGridView.MultiSelect = false;
            this.userListGridView.Name = "userListGridView";
            this.userListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userListGridView.Size = new System.Drawing.Size(361, 195);
            this.userListGridView.TabIndex = 0;
            this.userListGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.userListGridView_dataBindingComplete);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserBtn.Location = new System.Drawing.Point(297, 35);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(75, 23);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Add User...";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(297, 275);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // changePwBtn
            // 
            this.changePwBtn.Location = new System.Drawing.Point(12, 275);
            this.changePwBtn.Name = "changePwBtn";
            this.changePwBtn.Size = new System.Drawing.Size(107, 23);
            this.changePwBtn.TabIndex = 4;
            this.changePwBtn.Text = "Change Password";
            this.changePwBtn.UseVisualStyleBackColor = true;
            this.changePwBtn.Click += new System.EventHandler(this.changePwBtn_Click);
            // 
            // usernameSearch
            // 
            this.usernameSearch.Location = new System.Drawing.Point(65, 35);
            this.usernameSearch.Name = "usernameSearch";
            this.usernameSearch.Size = new System.Drawing.Size(111, 20);
            this.usernameSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find User";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(182, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(54, 23);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // ManageUserScreen
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 310);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameSearch);
            this.Controls.Add(this.changePwBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.userListGridView);
            this.MaximizeBox = false;
            this.Name = "ManageUserScreen";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userListGridView;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button changePwBtn;
        private System.Windows.Forms.TextBox usernameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
    }
}