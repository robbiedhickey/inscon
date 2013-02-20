using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for UserAreaCoverageControllerTest
    /// </summary>
    [TestClass]
    public class UserAreaCoverageControllerTest
    {
        private int recCount = 9;
        private UserAreaCoverage delObj = new UserAreaCoverage();
        private UserAreaCoverage insObj = new UserAreaCoverage();

        public UserAreaCoverageControllerTest()
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

            insObj = new UserAreaCoverage
                {
                    UserID = 1,
                    ZipCode = "76021",
                    ServiceID = 0
                };

            delObj = new UserAreaCoverage
                {
                    UserAreaCoverageID = 1,
                    UserID = 1,
                    ZipCode = "75656",
                    ServiceID = 0
                };
        }

        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetAllUserAreaCoverages()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var actual = controller.GetAllUserAreaCoverages();

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(recCount, actual.Count);
        }

        [TestMethod]
        public void GetUserAreaCoverageByParentIdPass()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var actual = controller.GetUserAreaCoverageByParentId(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.UserAreaCoverageID, 1);
            Assert.AreEqual(actual.UserID, 1);
            Assert.AreEqual(actual.ZipCode, "75656");
            Assert.AreEqual(actual.ServiceID, 0);
        }

        [TestMethod]
        public void GetUserAreaCoverageByParentIdFail()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var actual = controller.GetUserAreaCoverageByParentId(10);

            Assert.IsNotNull(controller);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetUserAreaCoverageByUserIdandServiceIdPass()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var actual = controller.GetUserAreaCoverageByUserIdandServiceId(1, 0);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual[0].UserAreaCoverageID, 1);
            Assert.AreEqual(actual[0].UserID, 1);
            Assert.AreEqual(actual[0].ZipCode, "75656");
            Assert.AreEqual(actual[0].ServiceID, 0);
        }

        [TestMethod]
        public void GetUserAreaCoverageByUserIdandServiceIdFail()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var actual = controller.GetUserAreaCoverageByUserIdandServiceId(10, 0);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(0,actual.Count);
        }

        [TestMethod]
        public void DeleteUserAreaCoveragePass()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            controller.DeleteRecord(delObj);
            var actual = controller.GetUserAreaCoverageByParentId(delObj.UserID);

            Assert.IsNotNull(controller);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void DeleteUserAreaCoverageFail()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            delObj.UserAreaCoverageID = 100;
            controller.DeleteRecord(delObj);
            var actual = controller.GetAllUserAreaCoverages();

            Assert.IsNotNull(controller);
            Assert.AreEqual(9, actual.Count);
        }

        [TestMethod]
        public void InsertUserAreaCoveragePass()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var actual = controller.SaveRecord(insObj);
            var result = controller.GetUserAreaCoverageByParentId(actual);

            Assert.IsNotNull(controller);
            Assert.IsTrue(actual > 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.UserID, 1);
            Assert.AreEqual(result.ZipCode, "76021");
            Assert.AreEqual(result.ServiceID, 0);
        }

        [TestMethod]
        public void InsertUserAreaCoverageFail()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var uac = controller.GetUserAreaCoverageByParentId(1);
            uac.UserAreaCoverageID = 0;
            var actual = controller.SaveRecord(uac);

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void UpdateUserAreaCoveragePass()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var uac = controller.GetUserAreaCoverageByParentId(1);
            uac.ZipCode = "00000";
            var actual = controller.SaveRecord(uac);
            var result = controller.GetUserAreaCoverageByParentId(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(uac);
            Assert.IsTrue(actual > 0);
            Assert.IsNotNull(result);
            Assert.AreEqual("00000", result.ZipCode);
        }

        [TestMethod]
        public void UpdateUserAreaCoverageFail()
        {
            UserAreaCoverageController controller = new UserAreaCoverageController();
            var uac = controller.GetUserAreaCoverageByParentId(1);
            uac.UserID = 4;
            uac.ZipCode = "00000";
            var actual = controller.SaveRecord(uac);
            var result = controller.GetUserAreaCoverageByParentId(1);

            Assert.IsNotNull(controller);
        }
    }
}
