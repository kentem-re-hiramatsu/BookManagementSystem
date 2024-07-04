using BookSystem.Cores.Manager;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class DetailForm : Form
    {
        private BookSystemManager _bookmana;
        private int _selectedIndex;

        public DetailForm(BookSystemManager bookMana, int selectedIndex)
        {
            InitializeComponent();
            _bookmana = bookMana;
            _selectedIndex = selectedIndex;
        }

        private void DetailForm_Load(object sender, System.EventArgs e)
        {
            var book = _bookmana.Get(_selectedIndex);
            BookListView.Items.Add(new ListViewItem(new string[] {
                book.Type,
                book.Title,
                book.Detail.TargetAge.ToString(),
                book.Detail.Author,
                book.Detail.OverView,
                book.Borrowing.GetLendingStatus()
            }));
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}