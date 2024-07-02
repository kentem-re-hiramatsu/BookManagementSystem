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

        public void BorrowingProcess(int index)
        {
            var bookBorrowing = _bookOrderList[index].Borrowing;

            if (bookBorrowing.IsLendable)
            {
                bookBorrowing.IsLendable = false;
                bookBorrowing.BorrowingTime = DateTime.Now;
                bookBorrowing.BorrowingPeriod = DateTime.Now.AddDays(14);
            }
            else
            {
                throw new Exception("貸出されているため貸し出すことができません。");
            }
        }

        public void ReturnProcess(int index)
        {
            var bookBorrowing = _bookOrderList[index].Borrowing;

            if (!bookBorrowing.IsLendable)
            {
                bookBorrowing.IsLendable = true;
                bookBorrowing.BorrowingTime = null;
                bookBorrowing.BorrowingPeriod = null;
            }
            else
            {
                throw new Exception("貸出がされていません。");
            }
        }
    }
}