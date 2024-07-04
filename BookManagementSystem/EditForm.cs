using BookSystem.Cores;
using BookSystem.Cores.Manager;
using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class EditForm : Form
    {
        private BookSystemManager _bookmana;
        private int _selectedIndex;

        public EditForm(BookSystemManager bookMana, int selectedIndex)
        {
            InitializeComponent();
            _bookmana = bookMana;
            _selectedIndex = selectedIndex;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            var book = _bookmana.Get(_selectedIndex);

            //初期設定
            BookComboBox.Items.Add(book.Type);
            BookComboBox.SelectedItem = book.Type;
            TitleTextBox.Text = book.Title;
            AgeNumericUpDown.Value = book.Detail.TargetAge;
            AuthorTextBox.Text = book.Detail.Author;
            OverviewTextBox.Text = book.Detail.OverView;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                var title = TitleTextBox.Text;
                var age = (int)AgeNumericUpDown.Value;
                var author = AuthorTextBox.Text;
                var overview = OverviewTextBox.Text;

                _bookmana.Edit(_selectedIndex, title, age, author, overview);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Consts.ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void OkButtonEnableChange()
        {
            RegistrationButton.Enabled = TitleTextBox.Text.Length > 0 && AuthorTextBox.Text.Length > 0;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            OkButtonEnableChange();
        }
    }
}
