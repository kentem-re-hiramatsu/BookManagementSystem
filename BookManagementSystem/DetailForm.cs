using BookSystem.Cores.Enum;
using BookSystem.Cores.Manager;
using BookSystem.Cores.Model;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class DetailForm : Form
    {
        private BookSystemManager _bookMana;
        private int _selectedIndex;
        private User _user;

        public DetailForm(BookSystemManager bookMana, int selectedIndex, User user)
        {
            InitializeComponent();
            _bookMana = bookMana;
            _selectedIndex = selectedIndex;
            _user = user;
        }

        private void DetailForm_Load(object sender, System.EventArgs e)
        {
            var book = _bookMana.Get(_selectedIndex);

            BookListView.Items.Add(new ListViewItem(new string[] {
                book.Type,
                book.Title,
                book.Detail.TargetAge.ToString(),
                book.Detail.Author,
                book.Detail.OverView,
                book.Borrowing.GetLendingStatus()
            }));

            var user = book.Borrowing.User;

            if (book.Borrowing.User == null)
                return;

            if (_user.IsAdmin)
            {
                UserType admin;
                if (book.Borrowing.User.IsAdmin)
                    admin = UserType.管理者;
                else
                    admin = UserType.一般;

                UserInfoListView.Items.Add(new ListViewItem(new string[] { user.Name, user.Age.ToString(), admin.ToString() }));
            }
            else
            {
                UserInfoListView.Items.Add(new ListViewItem(new string[] { user.Name, user.Age.ToString() }));
            }
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}