using BookSystem.Cores.Enum;
using BookSystem.Cores.Model;
using System.Collections.Generic;

namespace BookSystem.Cores.Manager
{
    public class BookSystemManager
    {
        private List<Book> _bookOrderList = new List<Book>();
        public IReadOnlyCollection<Book> BookOrderList { get { return _bookOrderList; } }

        public void Add(Book book)
        {
            _bookOrderList.Add(book);
        }

        public Book Get(int index)
        {
            return _bookOrderList[index];
        }

        public Book GetBookInstance(BookType type, string title, BookDetail detail)
        {
            switch (type)
            {
                case BookType.絵本:
                    return new PictureBook(title, detail);
                case BookType.漫画:
                    return new ComicBook(title, detail);
                case BookType.小説:
                    return new NovelBook(title, detail);
                default:
                    return null;
            }
        }

        public void Remove(int index)
        {
            _bookOrderList.RemoveAt(index);
        }

        public void Edit(int index, string title, int targetAge, string author, string overView)
        {
            _bookOrderList[index].Title = title;
            var bookDetail = _bookOrderList[index].Detail;
            bookDetail.TargetAge = targetAge;
            bookDetail.Author = author;
            bookDetail.OverView = overView;
        }
    }
}