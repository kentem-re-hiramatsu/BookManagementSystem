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
                var restriction = UserType.一般ユーザー;

                if (user.IsAdmin)
                    admin = UserType.管理者;
                if (user.IsRestriction)
                    restriction = UserType.制限ユーザー;

                UserInfoListView.Items.Add(new ListViewItem(new string[] { user.Name, user.Age.ToString(), admin.ToString(), restriction.ToString() }));
            }
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void RestrictionButton_Click(object sender, System.EventArgs e)
        {
            _userMana.Get(UserInfoListView.SelectedItems[0].Index).IsRestriction = false;
        }

        private void UserInfoListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RestrictionButton.Enabled = UserInfoListView.SelectedItems.Count > 0;
        }
    }
}