using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Enterprise.ApiServices.DALServices.Controllers;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for LookupControllerTest
    /// </summary>
    [TestClass]
    public class LookupControllerTest
    {

        private LookupController _controller;

        public LookupControllerTest()
        {
            _controller = new LookupController();
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
        public void GetAllLookups()
        {
            var actual = _controller.GetAllLookups();

            Assert.IsNotNull(actual);
            Assert.AreEqual(43, actual.Count);
        }

        [TestMethod]
        public void GetLookupByIdPass()
        {
            var actual = _controller.GetLookupById(1);

            //LookupID	LookupGroupID	Value	OldID
            //1	1	Active	NULL
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.LookupID, 1);
            Assert.AreEqual(actual.LookupGroupID, 1);
            Assert.AreEqual(actual.Value, "Active");

        }

        [TestMethod]
        public void GetLookupByIdFail()
        {
            var actual = _controller.GetLookupById(100);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetLookupValuesByGroupIdPass()
        {
            var actual = _controller.GetLookupValuesByGroupId(2);

            Assert.IsTrue(actual.Count == 5);
            Assert.IsTrue(actual.Any(l => l.Value == "Customer"));
            Assert.IsTrue(actual.Any(l => l.Value == "Contractor"));
            Assert.IsTrue(actual.Any(l => l.Value == "Employee"));
            Assert.IsTrue(actual.Any(l => l.Value == "Auditor"));
            Assert.IsTrue(actual.Any(l => l.Value == "Investor"));
        }

        [TestMethod]
        public void GetLookupValuesByGroupIdFail()
        {
            var actual = _controller.GetLookupValuesByGroupId(100);

            Assert.IsTrue(actual.Count == 0);
        }

        [TestMethod]
        public void DeleteLookupPass()
        {
            var lookupToDelete = new Lookup { LookupID = 1 };

            _controller.DeleteRecord(lookupToDelete);

            var result = _controller.GetLookupById(1);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void DeleteLookupFail()
        {
            var lookupToDelete = new Lookup { LookupID = 100 };

            _controller.DeleteRecord(lookupToDelete);

            var result = _controller.GetLookupById(100);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void InsertLookupPass()
        {
            var lookupToInsert = new Lookup
            {
                Value = "BlahBlah",
                LookupGroupID = 12
            };

            var result = _controller.SaveRecord(lookupToInsert);

            var record = _controller.GetLookupById(result);

            Assert.IsNotNull(record);
            Assert.IsTrue(record.Value == "BlahBlah");
            Assert.IsTrue(record.LookupGroupID == 12);
        }

        //need to add constraint for lookup group
        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void InsertLookupFail()
        {
            var lookupToInsert = new Lookup
            {
                Value = "BlahBlah",
                LookupGroupID = 120 //lookup group does not exist
            };

            var result = _controller.SaveRecord(lookupToInsert);

            var record = _controller.GetLookupById(result);

            Assert.IsNull(record);
        }

        [TestMethod]
        public void UpdateLookupPass()
        {
            var lookupToUpdate = _controller.GetLookupById(2);

            lookupToUpdate.Value = "Something else";

            _controller.SaveRecord(lookupToUpdate);

            var postUpdate = _controller.GetLookupById(2);

            Assert.IsNotNull(postUpdate);
            Assert.IsTrue(postUpdate.Value == "Something else");
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should enforce uniqueness given a Value with the same LookupGroudID")]
        public void UpdateLookupFail()
        {
            var lookupToUpdate = _controller.GetLookupById(2);

            lookupToUpdate.Value = "Active"; //duplicate value for a lookupgroup, should be a constraint

            _controller.SaveRecord(lookupToUpdate);

            var postUpdate = _controller.GetLookupById(2);

            Assert.IsNotNull(postUpdate);
            Assert.IsTrue(postUpdate.Value == "Inactive"); //value should not have changed

        }
    }
}
