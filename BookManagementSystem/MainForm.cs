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

        private void RegistrationButton_Click(object sender, System.EventArgs e)
        {
            if (new RegistrationForm(_bookmana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            if (new EditForm(_bookmana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
        }

        private void DetailButton_Click(object sender, System.EventArgs e)
        {
            if (new DetailForm(_bookmana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
        }

        private void BorrowingButton_Click(object sender, System.EventArgs e)
        {
            if (new BorrowingForm(_bookmana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
        }
    }
}
