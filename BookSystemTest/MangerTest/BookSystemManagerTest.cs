using BookSystem.Cores.Manager;
using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookSystemTest.MangerTest
{
    [TestClass]
    public class BookSystemManagerTest
    {
        [TestMethod]
        public void AddAndRemoveTest()
        {
            var bookSystemMana = new BookSystemManager();

            Assert.AreEqual(0, bookSystemMana.BookOrderList.Count);

            var onepice = new ComicBook("ワンピース", new BookDetail(10, "尾田栄一郎", ""), new Borrowing());
            var guriToGura = new PictureBook("ぐりとぐら", new BookDetail(0, "ぐり", ""), new Borrowing());

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

            var onepice = new ComicBook("ワンピース", new BookDetail(10, "尾田栄一郎", ""), new Borrowing());

            bookSystemMana.Add(onepice);

            Assert.AreEqual("ワンピース", bookSystemMana.Get(0).Title);

            bookSystemMana.Edit(0, "ドラゴンボール", 10, "鳥山明", "");

            Assert.AreEqual("ドラゴンボール", bookSystemMana.Get(0).Title);
            Assert.AreEqual("鳥山明", bookSystemMana.Get(0).Detail.Author);
        }
    }
}