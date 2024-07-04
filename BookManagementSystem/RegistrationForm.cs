using BookSystem.Cores;
using BookSystem.Cores.Enum;
using BookSystem.Cores.Manager;
using BookSystem.Cores.Model;
using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class RegistrationForm : Form
    {
        private BookSystemManager _bookMana;

        public RegistrationForm(BookSystemManager bookMana)
        {
            InitializeComponent();
            _bookMana = bookMana;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //ComBoxの初期設定
            BookComboBox.Items.Add(BookType.絵本);
            BookComboBox.Items.Add(BookType.漫画);
            BookComboBox.Items.Add(BookType.小説);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                var type = BookComboBox.Text;
                var title = TitleTextBox.Text;
                var age = (int)AgeNumericUpDown.Value;
                var author = AuthorTextBox.Text;
                var overview = OverviewTextBox.Text;

                //ComboBoxで選択されているTagから取得したEnumで本のインスタンス取得
                var book = _bookMana.GetBookInstance((BookType)BookComboBox.SelectedItem, title, new BookDetail(age, author, overview));

                _bookMana.Add(book);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Consts.ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OkButtonEnableChange()
        {
            RegistrationButton.Enabled = BookComboBox.Text.Length > 0 && TitleTextBox.Text.Length > 0 && AuthorTextBox.Text.Length > 0;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            OkButtonEnableChange();
        }

        private void BookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgeNumericUpDown.Enabled = (BookType)BookComboBox.SelectedItem != BookType.絵本;

            if ((BookType)BookComboBox.SelectedItem == BookType.絵本)
                AgeNumericUpDown.Value = 0;
        }
    }
}