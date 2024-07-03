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
            //貸出中のためエラー
            Assert.ThrowsException<Exception>(() => bookBorrowing.SetBorrowingProcess(DateTime.Now.AddDays(14)));
        }

        [TestMethod]
        public void SetReturnProcess()
        {
            var book = new ComicBook("ワンピース", new BookDetail(10, "尾田", ""));
            var bookBorrowing = book.Borrowing;
            Assert.IsTrue(bookBorrowing.IsLendable);

            bookBorrowing.SetBorrowingProcess(DateTime.Now.AddDays(14));
            var lendingDate = DateTime.Now;
            var deadlineDateTime = DateTime.Now.AddDays(14);

            Assert.IsFalse(bookBorrowing.IsLendable);
            Assert.AreEqual(lendingDate, bookBorrowing.BorrowingTime);
            Assert.AreEqual(deadlineDateTime, bookBorrowing.BorrowingPeriod);

            bookBorrowing.SetReturnProcess();

            Assert.IsTrue(bookBorrowing.IsLendable);
            Assert.IsNull(bookBorrowing.BorrowingTime);
            Assert.IsNull(bookBorrowing.BorrowingPeriod);

            //貸出していない時に返却しようとしているためエラー
            Assert.ThrowsException<Exception>(() => bookBorrowing.SetReturnProcess());
        }

        [TestMethod]
        public void GetLendingStatusByshapeTest()
        {
            var book = new ComicBook("ワンピース", new BookDetail(10, "尾田", ""));
            var bookBorrowing = book.Borrowing;

            Assert.AreEqual("〇", bookBorrowing.GetLendingStatusByshape());

            bookBorrowing.SetBorrowingProcess(DateTime.Now.AddDays(14));
            Assert.AreEqual("×", bookBorrowing.GetLendingStatusByshape());
        }

        [TestMethod]
        public void GetLendingStatus()
        {
            var book = new ComicBook("ワンピース", new BookDetail(10, "尾田", ""));
            var bookBorrowing = book.Borrowing;

            Assert.AreEqual("貸出可", bookBorrowing.GetLendingStatus());

            bookBorrowing.SetBorrowingProcess(DateTime.Now.AddDays(14));
            Assert.AreEqual("貸出中", bookBorrowing.GetLendingStatus());
        }
    }
}