using BookSystem.Cores.Enum;
using BookSystem.Cores.Manager;
using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookSystemTest.MangerTest
{
    [TestClass]
    public class BookSystemManagerTest
    {
        [TestMethod]
        public void AddTest()
        {
            var bookSystemMana = new BookSystemManager();

            Assert.AreEqual(0, bookSystemMana.BookOrderList.Count);

            var onepice = new ComicBook("ワンピース", new BookDetail(10, "尾田栄一郎", ""));
            var guriToGura = new PictureBook("ぐりとぐら", new BookDetail(0, "ぐり", ""));

            bookSystemMana.Add(onepice);
            bookSystemMana.Add(guriToGura);

            Assert.AreEqual(2, bookSystemMana.BookOrderList.Count);
            Assert.AreEqual("ワンピース", bookSystemMana.Get(0).Title);
            Assert.AreEqual("ぐりとぐら", bookSystemMana.Get(1).Title);
        }

        [TestMethod]
        public void RemoveTest()
        {
            var bookSystemMana = new BookSystemManager();

            var onepice = new ComicBook("ワンピース", new BookDetail(10, "尾田栄一郎", ""));
            var guriToGura = new PictureBook("ぐりとぐら", new BookDetail(0, "ぐり", ""));

            bookSystemMana.Add(onepice);
            bookSystemMana.Add(guriToGura);

            Assert.AreEqual(2, bookSystemMana.BookOrderList.Count);
            Assert.AreEqual("ワンピース", bookSystemMana.Get(0).Title);
            Assert.AreEqual("ぐりとぐら", bookSystemMana.Get(1).Title);

            bookSystemMana.Remove(0);

            Assert.AreEqual(1, bookSystemMana.BookOrderList.Count);
            Assert.AreEqual("ぐりとぐら", bookSystemMana.Get(0).Title);
        }

        [TestMethod]
        public void EditTest()
        {
            var bookSystemMana = new BookSystemManager();

            var onepice = new ComicBook("ワンピース", new BookDetail(10, "尾田栄一郎", ""));

            bookSystemMana.Add(onepice);

            Assert.AreEqual("ワンピース", bookSystemMana.Get(0).Title);

            bookSystemMana.Edit(0, "ドラゴンボール", 10, "鳥山明", "");

            Assert.AreEqual("ドラゴンボール", bookSystemMana.Get(0).Title);
            Assert.AreEqual("鳥山明", bookSystemMana.Get(0).Detail.Author);
        }

        [TestMethod]
        public void GetBookInstanceTest()
        {
            var bookSystemMana = new BookSystemManager();

            var picture = bookSystemMana.GetBookInstance(BookType.絵本, "ぐりとぐら", new BookDetail(10, "ぐり", ""));
            var comic = bookSystemMana.GetBookInstance(BookType.漫画, "ワンピース", new BookDetail(15, "尾田栄一郎", ""));
            var nobel = bookSystemMana.GetBookInstance(BookType.小説, "ぐり", new BookDetail(0, "ぐら", ""));

            Assert.AreEqual("絵本", picture.Type);
            Assert.AreEqual("漫画", comic.Type);
            Assert.AreEqual("小説", nobel.Type);

            Assert.AreEqual("ぐりとぐら", picture.Title);
            Assert.AreEqual("ワンピース", comic.Title);
            Assert.AreEqual("ぐり", nobel.Title);

            Assert.AreEqual(10, picture.Detail.TargetAge);
            Assert.AreEqual(15, comic.Detail.TargetAge);
            Assert.AreEqual(0, nobel.Detail.TargetAge);

            Assert.AreEqual("ぐり", picture.Detail.Author);
            Assert.AreEqual("尾田栄一郎", comic.Detail.Author);
            Assert.AreEqual("ぐら", nobel.Detail.Author);

            Assert.AreEqual("", picture.Detail.OverView);
            Assert.AreEqual("", comic.Detail.OverView);
            Assert.AreEqual("", nobel.Detail.OverView);
        }

        [TestMethod]
        public void BorrowingProcessTest()
        {
            var bookSystemMana = new BookSystemManager();

            var picture = bookSystemMana.GetBookInstance(BookType.絵本, "ぐりとぐら", new BookDetail(10, "ぐり", ""));

            bookSystemMana.Add(picture);

            var adamu = new User("アダム", 11, false);
            var juliet = new User("ジュリエット", 9, true);

            Assert.IsTrue(bookSystemMana.Get(0).Borrowing.IsLendable);

            //貸出期限を超えているためエラー
            Assert.ThrowsException<Exception>(() => bookSystemMana.BorrowingProcess(0, DateTime.Now.AddDays(14), adamu));
            //ユーザーが本の対象年齢以下のためエラー
            Assert.ThrowsException<Exception>(() => bookSystemMana.BorrowingProcess(0, DateTime.Now.AddDays(13), juliet));

            bookSystemMana.BorrowingProcess(0, DateTime.Now.AddDays(13), adamu);

            var bookBorrowing = bookSystemMana.Get(0).Borrowing;

            Assert.IsFalse(bookBorrowing.IsLendable);
            Assert.AreEqual(DateTime.Now.Date, bookBorrowing.BorrowingDateTime.Value.Date);
            Assert.AreEqual(DateTime.Now.AddDays(13).Date, bookBorrowing.DeadlineDateTime.Value.Date);

            Assert.AreEqual("アダム", bookBorrowing.User.Name);
            Assert.AreEqual(11, bookBorrowing.User.Age);
            Assert.IsFalse(bookBorrowing.User.IsAdmin);

            //貸出中のためエラー
            Assert.ThrowsException<Exception>(() => bookSystemMana.BorrowingProcess(0, DateTime.Now.AddDays(13), adamu));
        }

        [TestMethod]
        public void ReturnProcessTest()
        {
            var bookSystemMana = new BookSystemManager();

            var picture = bookSystemMana.GetBookInstance(BookType.絵本, "ぐりとぐら", new BookDetail(10, "ぐり", ""));

            bookSystemMana.Add(picture);

            var adamu = new User("アダム", 11, false);
            var juliet = new User("ジュリエット", 12, true);

            bookSystemMana.BorrowingProcess(0, DateTime.Now.AddDays(13), adamu);

            var bookBorrowing = bookSystemMana.Get(0).Borrowing;

            Assert.IsFalse(bookBorrowing.IsLendable);
            Assert.AreEqual(DateTime.Now.Date, bookBorrowing.BorrowingDateTime.Value.Date);
            Assert.AreEqual(DateTime.Now.AddDays(13).Date, bookBorrowing.DeadlineDateTime.Value.Date);

            Assert.AreEqual("アダム", bookBorrowing.User.Name);
            Assert.AreEqual(11, bookBorrowing.User.Age);
            Assert.IsFalse(bookBorrowing.User.IsAdmin);

            //他の人が返却しようとしたためエラー
            Assert.ThrowsException<Exception>(() => bookSystemMana.ReturnProcess(0, juliet));

            bookSystemMana.ReturnProcess(0, adamu);

            Assert.IsTrue(bookBorrowing.IsLendable);
            Assert.IsNull(bookBorrowing.BorrowingDateTime);
            Assert.IsNull(bookBorrowing.DeadlineDateTime);
            Assert.IsNull(bookBorrowing.User);

            Assert.ThrowsException<Exception>(() => bookSystemMana.ReturnProcess(0, juliet));
        }
    }
}