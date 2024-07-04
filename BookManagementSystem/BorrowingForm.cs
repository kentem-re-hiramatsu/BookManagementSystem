using BookSystem.Cores.Manager;
using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class BorrowingForm : Form
    {
        private BookSystemManager _bookmana;

        public BorrowingForm(BookSystemManager bookMana)
        {
            InitializeComponent();
            _bookmana = bookMana;
        }

        private void BorrowingForm_Load(object sender, EventArgs e)
        {
            ReturnDateTimePicker.Value = DateTime.Now;
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
                    _bookmana.Get(GetSelectedIndex()).Borrowing.SetBorrowing(ReturnDateTimePicker.Value);
                    UpdateScreen();
                }
                ButtonEnableChenged();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookListView.SelectedItems.Count > 0)
                {
                    //返却処理
                    _bookmana.Get(GetSelectedIndex()).Borrowing.SetReturn();
                    UpdateScreen();
                }
                ButtonEnableChenged();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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