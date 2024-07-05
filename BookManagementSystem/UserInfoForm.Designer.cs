namespace BookManagementSystem
{
    partial class UserInfoForm
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
            this.UserInfoListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseButton = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RestrictionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserInfoListView
            // 
            this.UserInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.UserInfoListView.HideSelection = false;
            this.UserInfoListView.Location = new System.Drawing.Point(12, 12);
            this.UserInfoListView.Name = "UserInfoListView";
            this.UserInfoListView.Size = new System.Drawing.Size(327, 264);
            this.UserInfoListView.TabIndex = 0;
            this.UserInfoListView.UseCompatibleStateImageBehavior = false;
            this.UserInfoListView.View = System.Windows.Forms.View.Details;
            this.UserInfoListView.SelectedIndexChanged += new System.EventHandler(this.UserInfoListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "年齢";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "権限";
            this.columnHeader3.Width = 63;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(264, 282);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 28);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "制限";
            this.columnHeader4.Width = 80;
            // 
            // RestrictionButton
            // 
            this.RestrictionButton.Enabled = false;
            this.RestrictionButton.Location = new System.Drawing.Point(174, 282);
            this.RestrictionButton.Name = "RestrictionButton";
            this.RestrictionButton.Size = new System.Drawing.Size(75, 28);
            this.RestrictionButton.TabIndex = 2;
            this.RestrictionButton.Text = "制限解除";
            this.RestrictionButton.UseVisualStyleBackColor = true;
            this.RestrictionButton.Click += new System.EventHandler(this.RestrictionButton_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 322);
            this.Controls.Add(this.RestrictionButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UserInfoListView);
            this.Name = "UserInfoForm";
            this.Text = "ユーザー管理画面";
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView UserInfoListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button RestrictionButton;
    }
}

