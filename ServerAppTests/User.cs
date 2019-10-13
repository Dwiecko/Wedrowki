namespace Tests
{
    #region

    using NUnit.Framework;
    using ServerApp.Models;

    #endregion

    public class Tests
    {
        #region Constants

        private const string UserName = "TestName";

        private const string UserEmail = "TestEmail@email.com";

        private const string UserPassword = "Test";

        #endregion

        private User User { get; private set; }

        [SetUp]
        public void Setup()
        {
            User = new User(UserName, UserEmail, UserPassword);
        }

        [Test]
        public void UserHasDefautName()
        {
            Assert.AreEqual(User.Name, UserName, "Testing that user name has name from initialization");
        }
    }
}