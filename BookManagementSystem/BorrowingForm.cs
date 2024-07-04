using BookSystem.Cores;
using BookSystem.Cores.Manager;
using BookSystem.Cores.Model;
using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class BorrowingForm : Form
    {
        private BookSystemManager _bookmana;
        private User _user;

        public BorrowingForm(BookSystemManager bookMana, User user)
        {
            InitializeComponent();
            _bookmana = bookMana;
            _user = user;
        }

        private void BorrowingForm_Load(object sender, EventArgs e)
        {
            ReturnDateTimePicker.Value = DateTime.Now;
            UserLabel.Text = $"{_user.Name}さん、こんにちは";
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            BookListView.Items.Clear();
            foreach (var book in _bookmana.BookOrderList)
            {
                BookListView.Items.Add(new ListViewItem(new string[] { book.Title, book.Type, book.Borrowing.GetLendingStatusByshape() }));
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public int GetSelectedIndex()
        {
            if (BookListView.SelectedItems.Count > 0)
                return BookListView.SelectedItems[0].Index;
            return -1;
        }

        private void LendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookListView.SelectedItems.Count > 0)
                {
                    //貸出処理
                    _bookmana.BorrowingProcess(GetSelectedIndex(), ReturnDateTimePicker.Value, _user);
                    UpdateScreen();
                }
                ButtonEnableChenged();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, Consts.ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookListView.SelectedItems.Count > 0)
                {
                    //返却処理
                    _bookmana.ReturnProcess(GetSelectedIndex());
                    UpdateScreen();
                }
                ButtonEnableChenged();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, Consts.ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEnableChenged()
        {
            LendButton.Enabled = BookListView.SelectedItems.Count > 0;
            ReturnButton.Enabled = BookListView.SelectedItems.Count > 0;
        }

        private void BookListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonEnableChenged();
        }
    }
}