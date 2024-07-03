using BookSystem.Cores.Enum;
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

            Assert.AreEqual(BookType.絵本, picture.Type);
            Assert.AreEqual(BookType.漫画, comic.Type);
            Assert.AreEqual(BookType.小説, nobel.Type);

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
    }
}