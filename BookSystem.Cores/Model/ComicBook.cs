namespace BookSystem.Cores.Model
{
    public class ComicBook : Book
    {
        public ComicBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = "漫画";
            Title = title;
            Detail = detail;
        }
    }
}
