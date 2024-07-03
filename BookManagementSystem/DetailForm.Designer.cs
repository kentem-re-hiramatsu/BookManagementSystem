namespace BookManagementSystem
{
    partial class DetailForm
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookListView
            // 
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.BookListView.HideSelection = false;
            this.BookListView.Location = new System.Drawing.Point(14, 32);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(572, 144);
            this.BookListView.TabIndex = 0;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "対象年齢";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "作者";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "概要";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "貸出状況";
            this.columnHeader4.Width = 86;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "本の種類";
            this.ColumnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "タイトル";
            this.columnHeader6.Width = 107;
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.OkButton.Location = new System.Drawing.Point(492, 182);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(92, 35);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 229);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.BookListView);
            this.Name = "DetailForm";
            this.Text = "詳細画面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader ColumnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button OkButton;
    }
}

