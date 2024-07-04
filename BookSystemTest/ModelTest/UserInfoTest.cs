using BookSystem.Cores.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookSystemTest.ModelTest
{
    [TestClass]
    public class UserInfoTest
    {
        [TestMethod]
        public void GetUserInfoTest()
        {
            var user = new User("けん", 20, true);

            Assert.AreEqual("けん", user.Name);
            Assert.AreEqual(20, user.Age);
            Assert.IsTrue(user.IsAdmin);
        }
    }
}
