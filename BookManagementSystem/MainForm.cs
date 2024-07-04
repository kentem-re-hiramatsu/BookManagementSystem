using BookSystem.Cores.Manager;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class MainForm : Form
    {
        private BookSystemManager _bookmana = new BookSystemManager();
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
            if (new DetailForm(_bookmana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            ButtonEnableChanged();
        }

        private void BorrowingButton_Click(object sender, System.EventArgs e)
        {
            if (new BorrowingForm(_bookmana).ShowDialog() == DialogResult.OK)
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
    }
}
