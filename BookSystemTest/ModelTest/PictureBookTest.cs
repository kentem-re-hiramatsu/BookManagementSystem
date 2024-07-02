using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookSystemTest.ModelTest
{
    [TestClass]
    public class PictureBookTest
    {
        [TestMethod]
        public void PictureTest()
        {
            var picture = new PictureBook("ぐりとぐら", new BookDetail(0, "中川", "ぐりとぐらを主人公とする物語。"));

            Assert.AreEqual("絵本", picture.Type);
            Assert.AreEqual("ぐりとぐら", picture.Title);
            Assert.AreEqual(0, picture.Detail.TargetAge);
            Assert.AreEqual("中川", picture.Detail.Author);
            Assert.AreEqual("ぐりとぐらを主人公とする物語。", picture.Detail.OverView);
            Assert.AreEqual(true, picture.Detail.IsLendable);
        }
    }
}
