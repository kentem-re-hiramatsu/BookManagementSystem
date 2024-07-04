using BookSystem.Cores.Enum;
using BookSystem.Cores.Manager;
using BookSystem.Cores.Model;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class MainForm : Form
    {
        private BookSystemManager _bookmana = new BookSystemManager();
        private UserManager _userMana = new UserManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateScreen()
        {
            BookListView.Items.Clear();
            foreach (var book in _bookmana.BookOrderList)
            {
                BookListView.Items.Add(new ListViewItem(new string[] { book.Title, book.Type, book.Borrowing.GetLendingStatusByshape() }));
            }
        }

        /// <summary>
        /// リストビューで選択されている本のインデックスを取得
        /// </summary>
        private int GetSelectedIndex()
        {
            if (BookListView.SelectedItems.Count > 0)
                return BookListView.SelectedItems[0].Index;
            return -1;
        }

        private void RegistrationButton_Click(object sender, System.EventArgs e)
        {
            if (new RegistrationForm(_bookmana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            if (new EditForm(_bookmana, GetSelectedIndex()).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void DetailButton_Click(object sender, System.EventArgs e)
        {
            if (new DetailForm(_bookmana, GetSelectedIndex()).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void BorrowingButton_Click(object sender, System.EventArgs e)
        {
            var user = _userMana.Get(UserComboBox.SelectedIndex);

            if (new BorrowingForm(_bookmana, user).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void RemoveButton_Click(object sender, System.EventArgs e)
        {
            _bookmana.Remove(GetSelectedIndex());
            UpdateScreen();
            ButtonEnableChanged();
        }

        /// <summary>
        /// 削除ボタン、編集ボタン、詳細ボタンの活性状態の管理
        /// </summary>
        private void ButtonEnableChanged()
        {
            RemoveButton.Enabled = BookListView.SelectedItems.Count > 0;
            EditButton.Enabled = BookListView.SelectedItems.Count > 0;
            DetailButton.Enabled = BookListView.SelectedItems.Count > 0;
        }

        private void BookListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ButtonEnableChanged();
        }

        private void UserRegisterButton_Click(object sender, System.EventArgs e)
        {
            var name = UserNameTextBox.Text;
            var age = (int)UserAgeUpDown.Value;
            var admin = (UserType)AdminComboBox.SelectedItem == UserType.管理者;

            _userMana.Add(new User(name, age, admin));

            UserNameTextBox.Text = null;
            UserAgeUpDown.Value = 0;

            foreach (var user in _userMana.UserDatas)
            {
                UserComboBox.Items.Add(user.Name);
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            AdminComboBox.Items.Add(UserType.一般);
            AdminComboBox.Items.Add(UserType.管理者);
        }
    }
}