using BookSystem.Cores.Enum;

namespace BookSystem.Cores.Model
{
    public class PictureBook : Book
    {
        private const BookType TYPE = BookType.絵本;

        public PictureBook(string title, BookDetail detail) : base(title, detail)
        {
            Type = TYPE;
        }
    }
}