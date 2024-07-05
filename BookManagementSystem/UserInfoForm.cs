using BookSystem.Cores.Enum;
using BookSystem.Cores.Manager;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class UserInfoForm : Form
    {
        private UserManager _userMana;

        public UserInfoForm(UserManager userMana)
        {
            InitializeComponent();
            _userMana = userMana;
        }

        private void UserInfoForm_Load(object sender, System.EventArgs e)
        {
            foreach (var user in _userMana.UserDatas)
            {
                var admin = UserType.一般;

                if (user.IsAdmin)
                    admin = UserType.管理者;

                UserInfoListView.Items.Add(new ListViewItem(new string[] { user.Name, user.Age.ToString(), admin.ToString() }));
            }
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}