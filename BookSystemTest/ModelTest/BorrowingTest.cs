using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookSystemTest.ModelTest
{
    [TestClass]
    public class BorrowingTest
    {
        [TestMethod]
        public void BrrowingConstructorTest()
        {
            var borrowing = new Borrowing();

            Assert.IsTrue(borrowing.IsLendable);
        }
    }
}