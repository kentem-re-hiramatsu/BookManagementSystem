using BookSystem.Cores.Enum;

namespace BookSystem.Cores.Model
{
    public class ComicBook : Book
    {
        private const BookType TYPE = BookType.漫画;

        public ComicBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = TYPE;
        }
    }
}
