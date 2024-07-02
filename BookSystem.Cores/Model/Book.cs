namespace BookSystem.Cores.Model
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Type { get; protected set; }
        public BookDetail Detail { get; set; }
        public Borrowing Borrowing { get; set; }

        public Book(string title, BookDetail detail, Borrowing borrowing)
        {
            Title = title;
            Detail = detail;
            Borrowing = borrowing;
        }
    }
}
