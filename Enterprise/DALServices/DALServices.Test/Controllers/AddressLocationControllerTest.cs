using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for AddressLocationControllerTest
    /// </summary>
    [TestClass]
    public class AddressLocationControllerTest
    {
        public AddressLocationControllerTest()
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
        public void GetAllAddressesLocationRecords()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetAddressLocationByIdPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetAddressLocationByIdFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteAddressesLocationPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteAddressesLocationFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertAddressesLocationPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertAddressesLocationFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateAddressesLocationPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateAddressesLocationFail()
        {
            Assert.Inconclusive();
        }
    }
}
