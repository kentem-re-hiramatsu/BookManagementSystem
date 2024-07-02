namespace BookSystem.Cores.Model
{
    public class PictureBook : Book
    {
        public PictureBook(string title, BookDetail detail, Borrowing borrowing) : base(title, detail, borrowing)
        {
            Type = "絵本";
            Title = title;
            Detail = detail;
        }
    }
}
