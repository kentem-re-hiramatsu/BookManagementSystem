namespace BookManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BookListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BorrowingButton = new System.Windows.Forms.Button();
            this.DetailButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.UserRegisterButton = new System.Windows.Forms.Button();
            this.UserAgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.AdminComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserAgeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BookListView
            // 
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.BookListView.FullRowSelect = true;
            this.BookListView.HideSelection = false;
            this.BookListView.Location = new System.Drawing.Point(16, 101);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(449, 304);
            this.BookListView.TabIndex = 17;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
            this.BookListView.SelectedIndexChanged += new System.EventHandler(this.BookListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "書籍名";
            this.columnHeader1.Width = 177;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "書籍の種類";
            this.columnHeader2.Width = 138;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "貸出状況";
            this.columnHeader3.Width = 92;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.RemoveButton.Location = new System.Drawing.Point(107, 46);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(85, 30);
            this.RemoveButton.TabIndex = 13;
            this.RemoveButton.Text = "削除";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // BorrowingButton
            // 
            this.BorrowingButton.Enabled = false;
            this.BorrowingButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.BorrowingButton.Location = new System.Drawing.Point(380, 46);
            this.BorrowingButton.Name = "BorrowingButton";
            this.BorrowingButton.Size = new System.Drawing.Size(85, 30);
            this.BorrowingButton.TabIndex = 16;
            this.BorrowingButton.Text = "貸出";
            this.BorrowingButton.UseVisualStyleBackColor = true;
            this.BorrowingButton.Click += new System.EventHandler(this.BorrowingButton_Click);
            // 
            // DetailButton
            // 
            this.DetailButton.Enabled = false;
            this.DetailButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.DetailButton.Location = new System.Drawing.Point(289, 46);
            this.DetailButton.Name = "DetailButton";
            this.DetailButton.Size = new System.Drawing.Size(85, 30);
            this.DetailButton.TabIndex = 15;
            this.DetailButton.Text = "詳細";
            this.DetailButton.UseVisualStyleBackColor = true;
            this.DetailButton.Click += new System.EventHandler(this.DetailButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.EditButton.Location = new System.Drawing.Point(198, 46);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(85, 30);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "編集";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.RegistrationButton.Location = new System.Drawing.Point(16, 46);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(85, 30);
            this.RegistrationButton.TabIndex = 12;
            this.RegistrationButton.Text = "登録";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // UserComboBox
            // 
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(471, 53);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(100, 20);
            this.UserComboBox.TabIndex = 18;
            this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComboBox_SelectedIndexChanged);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(471, 255);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 19);
            this.UserNameTextBox.TabIndex = 19;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "名前";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(469, 286);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 12);
            this.label.TabIndex = 22;
            this.label.Text = "年齢";
            // 
            // UserRegisterButton
            // 
            this.UserRegisterButton.Enabled = false;
            this.UserRegisterButton.Location = new System.Drawing.Point(471, 382);
            this.UserRegisterButton.Name = "UserRegisterButton";
            this.UserRegisterButton.Size = new System.Drawing.Size(100, 23);
            this.UserRegisterButton.TabIndex = 23;
            this.UserRegisterButton.Text = "登録";
            this.UserRegisterButton.UseVisualStyleBackColor = true;
            this.UserRegisterButton.Click += new System.EventHandler(this.UserRegisterButton_Click);
            // 
            // UserAgeUpDown
            // 
            this.UserAgeUpDown.Location = new System.Drawing.Point(471, 301);
            this.UserAgeUpDown.Name = "UserAgeUpDown";
            this.UserAgeUpDown.Size = new System.Drawing.Size(100, 19);
            this.UserAgeUpDown.TabIndex = 24;
            this.UserAgeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AdminComboBox
            // 
            this.AdminComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminComboBox.FormattingEnabled = true;
            this.AdminComboBox.Location = new System.Drawing.Point(471, 341);
            this.AdminComboBox.Name = "AdminComboBox";
            this.AdminComboBox.Size = new System.Drawing.Size(100, 20);
            this.AdminComboBox.TabIndex = 25;
            this.AdminComboBox.SelectedIndexChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "権限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "パスワード";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(471, 116);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 19);
            this.IDTextBox.TabIndex = 29;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(471, 162);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 19);
            this.PasswordTextBox.TabIndex = 30;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(496, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 31;
            this.LogOutButton.Text = "ログアウト";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Enabled = false;
            this.LogInButton.Location = new System.Drawing.Point(496, 196);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(75, 23);
            this.LogInButton.TabIndex = 32;
            this.LogInButton.Text = "ログイン";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminComboBox);
            this.Controls.Add(this.UserAgeUpDown);
            this.Controls.Add(this.UserRegisterButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.BookListView);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BorrowingButton);
            this.Controls.Add(this.DetailButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RegistrationButton);
            this.Name = "MainForm";
            this.Text = "メイン画面";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserAgeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button BorrowingButton;
        private System.Windows.Forms.Button DetailButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button UserRegisterButton;
        private System.Windows.Forms.NumericUpDown UserAgeUpDown;
        private System.Windows.Forms.ComboBox AdminComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button LogInButton;
    }
}

