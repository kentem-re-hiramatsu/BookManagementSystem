namespace BookSystem.Cores.Model
{
    public class NovelBook : Book
    {
        private const string TYPE = "小説";

        public NovelBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = TYPE;
        }
    }
}