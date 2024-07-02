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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BookListView
            // 
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.BookListView.HideSelection = false;
            this.BookListView.Location = new System.Drawing.Point(12, 36);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(449, 304);
            this.BookListView.TabIndex = 18;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
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
            this.ReturnButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ReturnButton.Location = new System.Drawing.Point(467, 36);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(91, 36);
            this.ReturnButton.TabIndex = 19;
            this.ReturnButton.Text = "返却";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // LendButton
            // 
            this.LendButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.LendButton.Location = new System.Drawing.Point(467, 93);
            this.LendButton.Name = "LendButton";
            this.LendButton.Size = new System.Drawing.Size(91, 36);
            this.LendButton.TabIndex = 20;
            this.LendButton.Text = "貸出";
            this.LendButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 19);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // BorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 372);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LendButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BookListView);
            this.Name = "BorrowingForm";
            this.Text = "貸出画面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LendButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

