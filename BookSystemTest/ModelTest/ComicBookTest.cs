using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookSystemTest.ModelTest
{
    [TestClass]
    public class ComicBookTest
    {
        [TestMethod]
        public void ComicTest()
        {
            var Comic = new ComicBook("ワンピース", new BookDetail(12, "尾田栄一郎", "ルフィーを主人公とする物語。"), new Borrowing());

            Assert.AreEqual("漫画", Comic.Type);
            Assert.AreEqual("ワンピース", Comic.Title);
            Assert.AreEqual(12, Comic.Detail.TargetAge);
            Assert.AreEqual("尾田栄一郎", Comic.Detail.Author);
            Assert.AreEqual("ルフィーを主人公とする物語。", Comic.Detail.OverView);
            Assert.AreEqual(true, Comic.Borrowing.IsLendable);
            Assert.IsNull(Comic.Borrowing.BorrowingTime);
            Assert.IsNull(Comic.Borrowing.BorrowingPeriod);
        }
    }
}
