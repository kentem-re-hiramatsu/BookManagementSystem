namespace BookSystem.Cores.Model
{
    public class NovelBook : Book
    {
        public NovelBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = "小説";
            Title = title;
            Detail = detail;
        }
    }
}
