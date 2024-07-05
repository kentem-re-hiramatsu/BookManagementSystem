using BookSystem.Cores.Enum;
using BookSystem.Cores.Manager;
using BookSystem.Cores.Model;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class MainForm : Form
    {
        private BookSystemManager _bookMana = new BookSystemManager();
        private UserManager _userMana = new UserManager();
        private string _adminId = "admin";
        private string _adminPassword = "admin";
        private bool _isAdmin = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateScreen()
        {
            BookListView.Items.Clear();
            int index = -1;

            foreach (var book in _bookMana.BookOrderList)
            {
                index++;
                BookListView.Items.Add(new ListViewItem(new string[] { book.Title, book.Type, _bookMana.GetLendingStatusByshape(index) }));
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
            if (new RegistrationForm(_bookMana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            if (new EditForm(_bookMana, GetSelectedIndex()).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void DetailButton_Click(object sender, System.EventArgs e)
        {
            if (new DetailForm(_bookMana, GetSelectedIndex(), GetSelectedUser()).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void BorrowingButton_Click(object sender, System.EventArgs e)
        {
            if (new BorrowingForm(_bookMana, GetSelectedUser()).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void RemoveButton_Click(object sender, System.EventArgs e)
        {
            _bookMana.Remove(GetSelectedIndex());
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
            DetailButton.Enabled = BookListView.SelectedItems.Count > 0 && UserComboBox.SelectedIndex > -1;
        }

        private void BookListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ButtonEnableChanged();
        }

        private void UserRegisterButton_Click(object sender, System.EventArgs e)
        {
            bool isAdmin;

            if ((UserType)AdminComboBox.SelectedItem == UserType.管理者 && _isAdmin)
            {
                isAdmin = true;
            }
            else if ((UserType)AdminComboBox.SelectedItem == UserType.一般)
            {
                isAdmin = false;
            }
            else
            {
                MessageBox.Show("ログインしてください");
                return;
            }

            var name = UserNameTextBox.Text;
            var age = (int)UserAgeUpDown.Value;

            _userMana.Add(new User(name, age, isAdmin));

            UserNameTextBox.Text = null;
            UserAgeUpDown.Value = 0;
            AdminComboBox.SelectedItem = null;

            UserComboBox.Items.Clear();
            //登録してあるユーザー名をComboBoxに追加
            foreach (var user in _userMana.UserDatas)
            {
                UserComboBox.Items.Add(user.Name);
            }

            BorrowingAndDetailButtonEnableChanged();
        }

        private User GetSelectedUser()
        {
            return _userMana.Get(UserComboBox.SelectedIndex);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            AdminComboBox.Items.Add(UserType.一般);
            AdminComboBox.Items.Add(UserType.管理者);
        }

        /// <summary>
        /// ユーザー登録ボタンの活性状態の管理
        /// </summary>
        private void UserRegisterButtonEnableChanged()
        {
            UserRegisterButton.Enabled = UserNameTextBox.Text.Length > 0 && AdminComboBox.Text.Length > 0;
        }

        /// <summary>
        /// 貸出ボタンと詳細ボタンの活性状態の管理
        /// </summary>
        private void BorrowingAndDetailButtonEnableChanged()
        {
            BorrowingButton.Enabled = UserComboBox.SelectedIndex > -1;
            DetailButton.Enabled = BookListView.SelectedItems.Count > 0 && UserComboBox.SelectedIndex > -1;
        }

        private void UserNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            UserRegisterButtonEnableChanged();
        }

        private void UserComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (0 > UserComboBox.SelectedIndex)
            {
                UserInfoButton.Enabled = false;
                return;
            }

            if (_userMana.Get(UserComboBox.SelectedIndex).IsAdmin && !_isAdmin)
            {
                UserComboBox.SelectedItem = null;
                MessageBox.Show("ログインしてください");
                return;
            }
            else if (_userMana.Get(UserComboBox.SelectedIndex).IsAdmin && _isAdmin)
            {
                UserInfoButton.Enabled = true;
            }
            else
            {
                UserInfoButton.Enabled = false;
                BorrowingAndDetailButtonEnableChanged();
            }
        }

        private void LogInButton_Click(object sender, System.EventArgs e)
        {
            if (IDTextBox.Text == _adminId && PasswordTextBox.Text == _adminPassword)
            {
                _isAdmin = true;
                IDTextBox.Text = null;
                PasswordTextBox.Text = null;
            }
            else
            {
                MessageBox.Show("IDまたはパスワードが違います。");
            }
        }

        private void IDTextBox_TextChanged(object sender, System.EventArgs e)
        {
            LogInButton.Enabled = IDTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0;
        }

        private void LogOutButton_Click(object sender, System.EventArgs e)
        {
            _isAdmin = false;
            UserComboBox.SelectedItem = null;
        }

        private void UserInfoButton_Click(object sender, System.EventArgs e)
        {
            new UserInfoForm(_userMana).ShowDialog();
        }
    }
}