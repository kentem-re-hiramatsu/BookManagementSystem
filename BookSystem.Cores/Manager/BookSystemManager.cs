using BookSystem.Cores.Enum;
using BookSystem.Cores.Model;
using System;
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

        public void BorrowingProcess(int index, DateTime deadlineDateTime, User user)
        {
            var book = _bookOrderList[index];
            var bookBorrowing = book.Borrowing;

            if (bookBorrowing.IsLendable && DateTime.Now.AddDays(14) > deadlineDateTime && user.Age >= book.Detail.TargetAge)
            {
                bookBorrowing.IsLendable = false;
                bookBorrowing.BorrowingTime = DateTime.Now;
                bookBorrowing.DeadlineDateTime = deadlineDateTime;
                bookBorrowing.User = user;
            }
            else if (deadlineDateTime >= DateTime.Now.AddDays(14))
            {
                throw new Exception(Consts.OVER_LOAN_PEROD_ERROR_MESSAGE);
            }
            else if (user.Age < book.Detail.TargetAge)
            {
                throw new Exception(Consts.AGE_ERROR_MESSAGE);
            }
            else
            {
                throw new Exception(Consts.ON_LOAN_ERROR_MESSAGE);
            }
        }

        /// <summary>
        /// 返却処理
        /// </summary>
        public void ReturnProcess(int index)
        {
            var book = _bookOrderList[index].Borrowing;

            if (!book.IsLendable)
            {
                book.User = null;
                book.IsLendable = true;
                book.BorrowingTime = null;
                book.DeadlineDateTime = null;
            }
            else
            {
                throw new Exception(Consts.NOT_LOAN_ERROR_MESSAGE);
            }
        }
    }
}