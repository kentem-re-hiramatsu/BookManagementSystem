namespace BookSystem.Cores.Model
{
    public class ComicBook : Book
    {
        public ComicBook(string title, BookDetail detail, Borrowing borrowing) : base(title, detail, borrowing)
        {
            Type = "漫画";
            Title = title;
            Detail = detail;
        }
    }
}
