namespace BookManagementSystem
{
    partial class BorrowingForm
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.LendButton = new System.Windows.Forms.Button();
            this.ReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
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
            this.BookListView.Location = new System.Drawing.Point(12, 36);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(449, 304);
            this.BookListView.TabIndex = 18;
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
            // ReturnButton
            // 
            this.ReturnButton.Enabled = false;
            this.ReturnButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ReturnButton.Location = new System.Drawing.Point(467, 238);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(113, 36);
            this.ReturnButton.TabIndex = 19;
            this.ReturnButton.Text = "返却";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // LendButton
            // 
            this.LendButton.Enabled = false;
            this.LendButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.LendButton.Location = new System.Drawing.Point(467, 196);
            this.LendButton.Name = "LendButton";
            this.LendButton.Size = new System.Drawing.Size(113, 36);
            this.LendButton.TabIndex = 20;
            this.LendButton.Text = "貸出";
            this.LendButton.UseVisualStyleBackColor = true;
            this.LendButton.Click += new System.EventHandler(this.LendButton_Click);
            // 
            // ReturnDateTimePicker
            // 
            this.ReturnDateTimePicker.Location = new System.Drawing.Point(467, 171);
            this.ReturnDateTimePicker.Name = "ReturnDateTimePicker";
            this.ReturnDateTimePicker.Size = new System.Drawing.Size(113, 19);
            this.ReturnDateTimePicker.TabIndex = 21;
            // 
            // ReturnDate
            // 
            this.ReturnDate.AutoSize = true;
            this.ReturnDate.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ReturnDate.Location = new System.Drawing.Point(464, 154);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(63, 14);
            this.ReturnDate.TabIndex = 22;
            this.ReturnDate.Text = "返却日時";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CloseButton.Location = new System.Drawing.Point(467, 304);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(113, 36);
            this.CloseButton.TabIndex = 23;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 372);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.ReturnDateTimePicker);
            this.Controls.Add(this.LendButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BookListView);
            this.Name = "BorrowingForm";
            this.Text = "貸出画面";
            this.Load += new System.EventHandler(this.BorrowingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LendButton;
        private System.Windows.Forms.DateTimePicker ReturnDateTimePicker;
        private System.Windows.Forms.Label ReturnDate;
        private System.Windows.Forms.Button CloseButton;
    }
}

