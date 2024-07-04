using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookSystemTest.MangerTest
{
    [TestClass]
    public class UserMangerTest
    {
        [TestMethod]
        public void AddTest()
        {
            var userMana = new UserManager();
            var adamu = new User("アダム", 24, false);
            var juliet = new User("ジュリエット", 20, true);

            Assert.AreEqual(0, userMana.UserDatas.Count);

            userMana.Add(adamu);
            userMana.Add(juliet);

            Assert.AreEqual(2, userMana.UserDatas.Count);

            Assert.AreEqual("アダム", userMana.Get(0).Name);
            Assert.AreEqual(24, userMana.Get(0).Age);
            Assert.IsFalse(userMana.Get(0).IsAdmin);

            Assert.AreEqual("ジュリエット", userMana.Get(1).Name);
            Assert.AreEqual(20, userMana.Get(1).Age);
            Assert.IsTrue(userMana.Get(1).IsAdmin);
        }
    }
}
