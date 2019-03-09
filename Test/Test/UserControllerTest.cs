using Game_Memory.DataBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UserControllerTest
    {
        public UserController userController = new UserController();
        public User user = new User("User");

        [TestCleanup]
        public void Before()
        {
            userController.deleteAll();
        }

        [TestMethod]
        public void saveUserTest()
        {
            userController.save(user);
            Assert.AreEqual(user.name, userController.deserializa()[0].name);
        }

        [TestMethod]
        public void saveOldUserTest()
        {
            User oldUser = new User("User");
            userController.save(user);
            userController.save(oldUser);
            Assert.AreEqual(1, userController.deserializa().Count);
            Assert.AreEqual(oldUser.name, userController.deserializa()[0].name);
        }

        [TestMethod]
        public void newUserTest()
        {
            this.user.score = 1;
            User OtherUser = new User("OtherUser");
            userController.save(OtherUser);
            User user = userController.newUser(this.user);
            Assert.AreEqual(1, user.score);
        }

        [TestMethod]
        public void oldUserTest()
        {
            this.user.score = 1;
            User OtherUser = new User("User");
            OtherUser.score = 2;
            userController.save(OtherUser);
            User user = userController.newUser(this.user);
            Assert.AreEqual(2, user.score);
        }
    }
}
