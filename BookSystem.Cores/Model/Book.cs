namespace BookSystem.Cores.Model
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Type { get; protected set; }
        public BookDetail Detail { get; set; }

        public Book(string title, BookDetail detail)
        {
            Title = title;
            Detail = detail;
        }
    }
}
