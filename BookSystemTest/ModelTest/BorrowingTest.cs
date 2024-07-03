using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookSystemTest.ModelTest
{
    [TestClass]
    public class BorrowingTest
    {
        [TestMethod]
        public void SetBorrowingProcess()
        {
            var book = new ComicBook("ワンピース", new BookDetail(10, "尾田", ""));
            var bookBorrowing = book.Borrowing;
            Assert.IsTrue(bookBorrowing.IsLendable);

            //貸出していない時に返却しようとしているためエラー
            Assert.ThrowsException<Exception>(() => bookBorrowing.SetReturnProcess());

            bookBorrowing.SetBorrowingProcess(DateTime.Now.AddDays(14));
            var lendingDate = DateTime.Now;
            var deadlineDateTime = DateTime.Now.AddDays(14);

            Assert.IsFalse(bookBorrowing.IsLendable);
            Assert.AreEqual(lendingDate, bookBorrowing.BorrowingTime);
            Assert.AreEqual(deadlineDateTime, bookBorrowing.BorrowingPeriod);

            //貸出期限を15日以上入力するとエラー
            Assert.ThrowsException<Exception>(() => bookBorrowing.SetBorrowingProcess(DateTime.Now.AddDays(15)));
            Assert.ThrowsException<Exception>(() => bookBorrowing);
        }
    }
}