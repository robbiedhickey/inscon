using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using Enterprise.ApiServices.DALServices.Controllers;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for LookupGroupControllerTest
    /// </summary>
    [TestClass]
    public class LookupGroupControllerTest
    {
        private readonly LookupGroupController _controller;
        public LookupGroupControllerTest()
        {
            _controller = new LookupGroupController();
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
        public void GetAllLookupGroups()
        {
            var actual = _controller.GetAllLookupGroups();

            Assert.IsTrue(actual.Count == 12);
        }

        [TestMethod]
        public void GetLookupGroupByIdPass()
        {
            var actual = _controller.GetLookupGroupById(1);

            //LookupGroupID	Name
            //1	OrganizationStatus
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.LookupGroupID == 1);
            Assert.IsTrue(actual.Name == "OrganizationStatus");
        }

        [TestMethod]
        public void GetLookupGroupByIdFail()
        {
            var actual = _controller.GetLookupGroupById(100);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void DeleteLookupGroupPass()
        {
            var groupToDelete = new LookupGroup { LookupGroupID = 1 };

            _controller.DeleteRecord(groupToDelete);

            var result = _controller.GetLookupGroupById(1);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void DeleteLookupGroupFail()
        {
            var groupToDelete = new LookupGroup { LookupGroupID = 100 };

            _controller.DeleteRecord(groupToDelete);

            var result = _controller.GetLookupGroupById(100);

            Assert.IsNull(result);

        }

        [TestMethod]
        public void InsertLookupGroupPass()
        {
            var groupToInsert = new LookupGroup { Name = "FancyNewGroup" };

            var resultId = _controller.SaveRecord(groupToInsert);

            var result = _controller.GetLookupGroupById(resultId);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Name == "FancyNewGroup");
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should enforce unqiqueness of name")]
        public void InsertLookupGroupFail()
        {
            var groupToInsert = new LookupGroup { Name = "OrganizationStatus" };

            var resultId = _controller.SaveRecord(groupToInsert);
        }

        [TestMethod]
        public void UpdateLookupGroupPass()
        {
            var groupToUpdate = _controller.GetLookupGroupById(2);

            groupToUpdate.Name = "SomethingNew";

            var resultId = _controller.SaveRecord(groupToUpdate);

            var result = _controller.GetLookupGroupById(resultId);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Name == "SomethingNew");
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should enforce uniqueness of name")]
        public void UpdateLookupGroupFail()
        {
            var groupToUpdate = _controller.GetLookupGroupById(2);

            groupToUpdate.Name = "UserStatus";

            var resultId = _controller.SaveRecord(groupToUpdate);
        }
    }
}
