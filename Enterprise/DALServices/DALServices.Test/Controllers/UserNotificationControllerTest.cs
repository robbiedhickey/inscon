using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;
using System.Data.SqlClient;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for UserNotificationControllerTest
    /// </summary>
    [TestClass]
    public class UserNotificationControllerTest
    {
        public UserNotificationControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;
        private UserNotification insObj;

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

            insObj = new UserNotification
                {
                    UserID = 1,
                    DatePosted = DateTime.Now,
                    DateRead = null
                };
        }

        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetAllUserNotifications()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.GetAllUserNotifications();

            Assert.IsNotNull(controller);
            Assert.IsNotNull(target);
            Assert.AreEqual(18, target.Count);
        }

        [TestMethod]
        public void GetUserNotificationByIdPass()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.GetUserNotificationById(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void GetUserNotificationByIdFail()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.GetUserNotificationById(100);

            Assert.IsNotNull(controller);
            Assert.IsNull(target);
        }

        [TestMethod]
        public void GetUserNotificationsByUserIdPass()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.GetUserNotificationsByUserId(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(target);
            Assert.AreEqual(2, target.Count);
        }

        [TestMethod]
        public void GetUserNotificationsByUserIdFail()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.GetUserNotificationsByUserId(100);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(target);
            Assert.AreEqual(0, target.Count);
        }

        [TestMethod]
        public void DeleteUserNotificationPass()
        {
            UserNotificationController controller = new UserNotificationController();
            var un = controller.GetUserNotificationById(1);
            var result = controller.DeleteRecord(un);

            Assert.IsNotNull(controller);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteUserNotificationFail()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.GetUserNotificationById(1);
            target.UserNotificationID = 100;
            var result = controller.DeleteRecord(target);

            Assert.IsNotNull(controller);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InsertUserNotificationPass()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.SaveRecord(insObj);

            Assert.IsNotNull(controller);
            Assert.IsTrue(target > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void InsertUserNotificationFail()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.GetUserNotificationById(1);
            target.UserID = 0;
            var result = controller.SaveRecord(target);
            var usrList = controller.GetAllUserNotifications();

            Assert.IsNotNull(controller);
            Assert.IsTrue(result > 0);
            Assert.IsNotNull(usrList);
            Assert.AreEqual(18, usrList.Count);
        }

        [TestMethod]
        public void UpdateUserNotificationPass()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.SaveRecord(insObj);

            Assert.IsNotNull(controller);
            Assert.IsTrue(target > 0);
        }

        [TestMethod]
        public void UpdateUserNotificationFail()
        {
            UserNotificationController controller = new UserNotificationController();
            var target = controller.GetUserNotificationsByUserId(1);
            var usr = target[0];
            usr.UserNotificationID = 0;
            var result = controller.SaveRecord(usr);

            Assert.IsNotNull(controller);
            Assert.IsTrue(result > 0);
        }
    }
}
