namespace BookSystem.Cores.Model
{
    public class ComicBook : Book
    {
        private const string TYPE = "漫画";

        public ComicBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = TYPE;
        }
    }
}
