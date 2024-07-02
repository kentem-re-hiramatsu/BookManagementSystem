namespace BookSystem.Cores.Model
{
    public class NovelBook : Book
    {
        public NovelBook(string title, BookDetail detail, Borrowing borrowing) : base(title, detail, borrowing)
        {
            Type = "小説";
            Title = title;
            Detail = detail;
        }
    }
}
