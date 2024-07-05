using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookSystemTest.ModelTest
{
    [TestClass]
    public class NobelBookTest
    {
        [TestMethod]
        public void NobelTest()
        {
            var Nobel = new NovelBook("羅生門", new BookDetail(20, "芥川龍之介", "昔話"));

            Assert.AreEqual("小説", Nobel.Type);
            Assert.AreEqual("羅生門", Nobel.Title);
            Assert.AreEqual(20, Nobel.Detail.TargetAge);
            Assert.AreEqual("芥川龍之介", Nobel.Detail.Author);
            Assert.AreEqual("昔話", Nobel.Detail.OverView);
            Assert.AreEqual(true, Nobel.Borrowing.IsLendable);
            Assert.IsNull(Nobel.Borrowing.BorrowingDateTime);
            Assert.IsNull(Nobel.Borrowing.DeadlineDateTime);
        }
    }
}