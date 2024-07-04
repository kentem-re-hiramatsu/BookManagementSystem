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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.BookListView);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BorrowingButton);
            this.Controls.Add(this.DetailButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RegistrationButton);
            this.Name = "MainForm";
            this.Text = "メイン画面";
            this.ResumeLayout(false);

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
    }
}

