namespace BookManagementSystem
{
    partial class EditForm
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
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.OverviewLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.OverviewTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(167, 290);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrationButton.TabIndex = 25;
            this.RegistrationButton.Text = "登録";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(86, 290);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AgeNumericUpDown
            // 
            this.AgeNumericUpDown.Location = new System.Drawing.Point(102, 135);
            this.AgeNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AgeNumericUpDown.Name = "AgeNumericUpDown";
            this.AgeNumericUpDown.Size = new System.Drawing.Size(140, 19);
            this.AgeNumericUpDown.TabIndex = 23;
            this.AgeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(102, 31);
            this.BookComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(140, 20);
            this.BookComboBox.TabIndex = 22;
            // 
            // OverviewLabel
            // 
            this.OverviewLabel.AutoSize = true;
            this.OverviewLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.OverviewLabel.Location = new System.Drawing.Point(17, 249);
            this.OverviewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OverviewLabel.Name = "OverviewLabel";
            this.OverviewLabel.Size = new System.Drawing.Size(35, 14);
            this.OverviewLabel.TabIndex = 21;
            this.OverviewLabel.Text = "概要";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.AuthorLabel.Location = new System.Drawing.Point(17, 197);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(35, 14);
            this.AuthorLabel.TabIndex = 20;
            this.AuthorLabel.Text = "作者";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.AgeLabel.Location = new System.Drawing.Point(17, 142);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(63, 14);
            this.AgeLabel.TabIndex = 19;
            this.AgeLabel.Text = "対象年齢";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.TitleLabel.Location = new System.Drawing.Point(17, 86);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(48, 14);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "タイトル";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.NameLabel.Location = new System.Drawing.Point(17, 34);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 14);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "本の種類";
            // 
            // OverviewTextBox
            // 
            this.OverviewTextBox.Location = new System.Drawing.Point(102, 246);
            this.OverviewTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OverviewTextBox.Name = "OverviewTextBox";
            this.OverviewTextBox.Size = new System.Drawing.Size(140, 19);
            this.OverviewTextBox.TabIndex = 16;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(102, 194);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(140, 19);
            this.AuthorTextBox.TabIndex = 15;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(102, 83);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(140, 19);
            this.TitleTextBox.TabIndex = 14;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 336);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AgeNumericUpDown);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.OverviewLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.OverviewTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "EditForm";
            this.Text = "編集画面";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown AgeNumericUpDown;
        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.Label OverviewLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox OverviewTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
    }
}

