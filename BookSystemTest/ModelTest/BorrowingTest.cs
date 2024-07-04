using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookSystemTest.ModelTest
{
    [TestClass]
    public class BorrowingTest
    {
        /// <summary>
        /// 貸出処理のテスト
        /// </summary>
        [TestMethod]
        public void SetBorrowingTest()
        {
            var book = new ComicBook("ワンピース", new BookDetail(10, "尾田", ""));
            var bookBorrowing = book.Borrowing;
            Assert.IsTrue(bookBorrowing.IsLendable);

            //貸出していない時に返却しようとしているためエラー
            Assert.ThrowsException<Exception>(() => bookBorrowing.SetReturn());

            bookBorrowing.SetBorrowing(DateTime.Now.AddDays(13));
            var lendingDate = DateTime.Now;
            var deadlineDateTime = DateTime.Now.AddDays(13);

            Assert.IsFalse(bookBorrowing.IsLendable);
            Assert.AreEqual(lendingDate, bookBorrowing.BorrowingTime);
            Assert.AreEqual(deadlineDateTime, bookBorrowing.DeadlineDateTime);

            //貸出期限を15日以上入力するとエラー
            Assert.ThrowsException<Exception>(() => bookBorrowing.SetBorrowing(DateTime.Now.AddDays(14)));
            //貸出中のためエラー
            Assert.ThrowsException<Exception>(() => bookBorrowing.SetBorrowing(DateTime.Now.AddDays(13)));
        }

        /// <summary>
        /// 返却処理のテスト
        /// </summary>
        [TestMethod]
        public void SetReturnTest()
        {
            var book = new ComicBook("ワンピース", new BookDetail(10, "尾田", ""));
            var bookBorrowing = book.Borrowing;
            Assert.IsTrue(bookBorrowing.IsLendable);

            bookBorrowing.SetBorrowing(DateTime.Now.AddDays(13));
            var lendingDate = DateTime.Now;
            var deadlineDateTime = DateTime.Now.AddDays(13);

            Assert.IsFalse(bookBorrowing.IsLendable);
            Assert.AreEqual(lendingDate, bookBorrowing.BorrowingTime);
            Assert.AreEqual(deadlineDateTime, bookBorrowing.DeadlineDateTime);

            bookBorrowing.SetReturn();

            Assert.IsTrue(bookBorrowing.IsLendable);
            Assert.IsNull(bookBorrowing.BorrowingTime);
            Assert.IsNull(bookBorrowing.DeadlineDateTime);

            //貸出していない時に返却しようとしているためエラー
            Assert.ThrowsException<Exception>(() => bookBorrowing.SetReturn());
        }

        /// <summary>
        /// 貸出状態〇×！で表すテスト
        /// </summary>
        [TestMethod]
        public void GetLendingStatusByshapeTest()
        {
            var book = new ComicBook("ワンピース", new BookDetail(10, "尾田", ""));
            var bookBorrowing = book.Borrowing;

            Assert.AreEqual("〇", bookBorrowing.GetLendingStatusByshape());

            bookBorrowing.SetBorrowing(DateTime.Now.AddDays(0));
            Assert.AreEqual("×", bookBorrowing.GetLendingStatusByshape());
            book.Borrowing.SetReturn();

            //返却期限が超過しているため×！
            bookBorrowing.SetBorrowing(DateTime.Now.AddDays(-1));
            Assert.AreEqual("×!", bookBorrowing.GetLendingStatusByshape());
        }

        /// <summary>
        /// 貸出状態を表すテスト
        /// </summary>
        [TestMethod]
        public void GetLendingStatusTest()
        {
            var book = new ComicBook("ワンピース", new BookDetail(10, "尾田", ""));
            var bookBorrowing = book.Borrowing;

            Assert.AreEqual("貸出可", bookBorrowing.GetLendingStatus());

            bookBorrowing.SetBorrowing(DateTime.Now.AddDays(0));
            Assert.AreEqual("貸出中", bookBorrowing.GetLendingStatus());

            book.Borrowing.SetReturn();

            bookBorrowing.SetBorrowing(DateTime.Now.AddDays(-1));
            Assert.AreEqual("貸出中(1日の期限超過)", bookBorrowing.GetLendingStatus());
        }
    }
}