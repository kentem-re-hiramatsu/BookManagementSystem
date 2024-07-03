using BookSystem.Cores.Enum;

namespace BookSystem.Cores.Model
{
    public class NovelBook : Book
    {
        private const BookType TYPE = BookType.小説;

        public NovelBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = TYPE;
        }
    }
}