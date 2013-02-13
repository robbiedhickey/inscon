using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.ApiServices.DALServices.Controllers;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for UserControllerTest
    /// </summary>
    [TestClass]
    public class UserControllerTest
    {
        private int userCount = 9;
        private User goodUser;
        private User dupUser;
        private User insUser;

        public UserControllerTest()
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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            DataHelper.LoadData("usp_LoadAllTestData.sql");

            goodUser = new User
                {
                    UserID = 1,
                    OrganizationID = 1,
                    FirstName = "John",
                    LastName = "Carter",
                    Title = null,
                    StatusID = 8,
                    AuthenticationID = null
                };

            insUser = new User
            {
                UserID = 0,
                OrganizationID = 1,
                FirstName = "Tardos",
                LastName = "Mors",
                Title = null,
                StatusID = 8,
                AuthenticationID = null
            };

            dupUser = new User
            {
                UserID = 0,
                OrganizationID = 1,
                FirstName = "Hermes",
                LastName = "Conrad",
                Title = null,
                StatusID = 8,
                AuthenticationID = null
            };
        }

        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetAllUsers()
        {
            UserController controller = new UserController();
            var actual = controller.GetAllUsers();

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(userCount, actual.Count);
        }

        [TestMethod]
        public void GetUserByIdPass()
        {
            UserController controller = new UserController();
            var actual = controller.GetUserById(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(goodUser.UserID, actual.UserID);
            Assert.AreEqual(goodUser.FirstName, actual.FirstName);
            Assert.AreEqual(goodUser.LastName, actual.LastName);
            Assert.AreEqual(goodUser.OrganizationID, actual.OrganizationID);
            Assert.AreEqual(goodUser.Title, actual.Title);
            Assert.AreEqual(goodUser.StatusID, actual.StatusID);
            Assert.AreEqual(goodUser.AuthenticationID, actual.AuthenticationID);
        }

        [TestMethod]
        public void GetUserByIdFail()
        {
            UserController controller = new UserController();
            var actual = controller.GetUserById(100);

            Assert.IsNotNull(controller);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetUsersByOrganizationIdPass()
        {
            UserController controller = new UserController();
            var actual = controller.GetUsersByOrganizationId(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(3, actual.Count);
        }

        [TestMethod]
        public void GetUsersByOrganizationIdFail()
        {
            UserController controller = new UserController();
            var actual = controller.GetUsersByOrganizationId(4);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void GetUsersByOrganizationIdAndIsActivePass()
        {
            UserController controller = new UserController();
            var actual = controller.GetUsersByOrganizationIdAndIsActive(1, 8);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(3, actual.Count);
        }

        [TestMethod]
        public void GetUsersByOrganizationIdAndIsActiveFail()
        {
            UserController controller = new UserController();
            var actual = controller.GetUsersByOrganizationIdAndIsActive(4, 8);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void DeleteUserPass()
        {
            UserController controller = new UserController();
            controller.DeleteRecord(goodUser);
            var actual = controller.GetUserById(goodUser.UserID);

            Assert.IsNotNull(controller);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void DeleteUserFail()
        {
            UserController controller = new UserController();
            goodUser.UserID = 10;
            controller.DeleteRecord(goodUser);
            var actual = controller.GetAllUsers();

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(userCount, actual.Count);
        }

        [TestMethod]
        public void InsertUserPass()
        {
            UserController controller = new UserController();
            var actual = controller.SaveRecord(insUser);
            var usr = controller.GetUserById(actual);

            Assert.IsNotNull(controller);
            Assert.IsTrue(actual > 0);
            Assert.IsNotNull(usr);
            Assert.AreEqual(usr.OrganizationID, 1);
            Assert.AreEqual(usr.FirstName, "Tardos");
            Assert.AreEqual(usr.LastName, "Mors");
            Assert.AreEqual(usr.Title, null);
            Assert.AreEqual(usr.StatusID, 8);
            Assert.AreEqual(usr.AuthenticationID, null);
        }

        /// <summary>
        /// TODO: After User is changed in the DAL this test needs to be changed.  You should not have the exact same name in any organization more than once.
        /// </summary>
        [TestMethod]
        public void InsertUserFail()
        {
            UserController controller = new UserController();
            var actual = controller.SaveRecord(dupUser);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void UpdateUserPass()
        {
            UserController controller = new UserController();
            var actual = controller.GetUserById(1);
            actual.OrganizationID = 3;
            var results = controller.SaveRecord(actual);
            var usr = controller.GetUserById(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.IsNotNull(usr);
            Assert.IsTrue(results > 0);
            Assert.AreEqual(usr.OrganizationID, 3);
            Assert.AreEqual(usr.FirstName, "John");
            Assert.AreEqual(usr.LastName, "Carter");
            Assert.AreEqual(usr.Title, null);
            Assert.AreEqual(usr.StatusID, 8);
            Assert.AreEqual(usr.AuthenticationID, null);
        }

        /// <summary>
        /// TODO: After User is changed in the DAL this test needs to be changed.  You should not have the exact same name in any organization more than once.
        /// </summary>
        [TestMethod]
        public void UpdateUserFail()
        {
            UserController controller = new UserController();
            var actual = controller.GetUserById(1);
            actual.OrganizationID = 3;
            actual.FirstName = "Hermes";
            actual.LastName = "Conrad";
            var results = controller.SaveRecord(actual);
            var usr = controller.GetUserById(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.IsNotNull(usr);
            Assert.IsTrue(results > 0);
            Assert.AreEqual(usr.OrganizationID, 3);
            Assert.AreEqual(usr.FirstName, "Hermes");
            Assert.AreEqual(usr.LastName, "Conrad");
            Assert.AreEqual(usr.Title, null);
            Assert.AreEqual(usr.StatusID, 8);
            Assert.AreEqual(usr.AuthenticationID, null);
        }
    }
}
