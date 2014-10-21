using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WBY.Domain.Models;
using WBY.Services.Account;

namespace WBY.Services.Test.Account
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AccountServiceTest
    {
        public AccountServiceTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetUserById()
        {
            IAccountService service = new AccountService();
            UserProfile profile = service.GetUser(1);

            Assert.IsNotNull(profile);
            Assert.AreEqual("Admin", profile.UserName);
        }

        [TestMethod]
        public void GetUserByname()
        {
            IAccountService service = new AccountService();
            UserProfile profile = service.GetUser("Admin");

            Assert.IsNotNull(profile);
            Assert.AreEqual("Admin", profile.UserName);
            Assert.AreEqual(1, profile.Id);
        }

        [TestMethod]
        public void UpdateUserName()
        {
            IAccountService service = new AccountService();
            UserProfile user = service.GetUser(1);

            user.UserName = "AdminTest";

            service.SaveUser(user);


            UserProfile updatedUser = service.GetUser(1);
            Assert.AreEqual("AdminTest", updatedUser.UserName);

            updatedUser.UserName = "Admin";
            service.SaveUser(updatedUser);
        }

        //TODO:  test this method out.
        [TestMethod]
        public void AddUserSubstance()
        {
            IAccountService service = new AccountService();
            UserProfile user = service.GetUser(1);

            user.Substances.Add(new UserSubstance()
            {
                Substance = new Substance() { Id = 1 }
            });

            service.SaveUser(user);

            user.Substances.Remove(user.Substances.First(s => s.Id == 1));

            service.SaveUser(user);
        }


    }
}
