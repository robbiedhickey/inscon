using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for UserContactControllerTest
    /// </summary>
    [TestClass]
    public class UserContactControllerTest
    {
        public UserContactControllerTest()
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
        }

        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetAllUserContacts()
        {
            UserContactController controller = new UserContactController();
            var usrList = controller.GetAllUserContacts();

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usrList);
            Assert.AreEqual(27, usrList.Count);
        }

        [TestMethod]
        public void GetUserContactByIdPass()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactById(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usr);
        }

        [TestMethod]
        public void GetUserContactByIdFail()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactById(100);

            Assert.IsNotNull(controller);
            Assert.IsNull(usr);
        }

        [TestMethod]
        public void GetUserContactsByUserIdPass()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactsByUserId(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usr);
            Assert.AreEqual(3, usr.Count);
        }

        [TestMethod]
        public void GetUserContactsByUserIdFail()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactsByUserId(100);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usr);
            Assert.AreEqual(0, usr.Count);
        }

        [TestMethod]
        public void GetUserContactsByUserIdAndTypeIdPass()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactsByUserIdAndTypeId(1, 30);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usr);
            Assert.AreEqual(1, usr.Count);
        }

        [TestMethod]
        public void GetUserContactsByUserIdAndTypeIdFail()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactsByUserIdAndTypeId(100, 30);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usr);
            Assert.AreEqual(0, usr.Count);
        }

        [TestMethod]
        public void DeleteUserContactPass()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactById(1);
            var result = controller.DeleteRecord(usr);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usr);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteUserContactFail()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactById(1);
            usr.UserContactID = 100;
            var result = controller.DeleteRecord(usr);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usr);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InsertUserContactPass()
        {
            UserContactController controller = new UserContactController();
            UserContact usr = new UserContact
                {
                    UserID = 1,
                    Value = "test@test.com",
                    TypeID = 32,
                    IsPrimary = false
                };
            var res = controller.SaveRecord(usr);
            var newUsr = controller.GetUserContactById(res);

            Assert.IsNotNull(controller);
            Assert.IsTrue(res > 0);
            Assert.AreEqual("test@test.com", newUsr.Value);
        }

        [TestMethod]
        public void InsertUserContactFail()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactById(1);
            var res = controller.SaveRecord(usr);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(usr);
            Assert.IsTrue(res > 0);
        }

        [TestMethod]
        public void UpdateUserContactPass()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactById(1);
            usr.Value = "test@test.com";
            var res = controller.SaveRecord(usr);
            var updUsr = controller.GetUserContactById(1);

            Assert.IsNotNull(controller);
            Assert.IsTrue(res > 0);
            Assert.AreEqual("test@test.com", updUsr.Value);
        }

        [TestMethod]
        public void UpdateUserContactFail()
        {
            UserContactController controller = new UserContactController();
            var usr = controller.GetUserContactById(1);
            usr.Value = "test@test.com";
            var res = controller.SaveRecord(usr);
            var updUsr = controller.GetUserContactById(1);

            Assert.IsNotNull(controller);
            Assert.IsTrue(res > 0);
            Assert.AreEqual("test@test.com", updUsr.Value);
        }
    }
}
