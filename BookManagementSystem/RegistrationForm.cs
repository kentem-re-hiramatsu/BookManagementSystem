using BookSystem.Cores.Enum;
using BookSystem.Cores.Manager;
using BookSystem.Cores.Model;
using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class RegistrationForm : Form
    {
        private BookSystemManager _bookmana;

        public RegistrationForm(BookSystemManager bookMana)
        {
            InitializeComponent();
            _bookmana = bookMana;
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
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

                var book = _bookmana.GetBookInstance((BookType)BookComboBox.SelectedItem, title, new BookDetail(age, author, overview));

                _bookmana.Add(book);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}