using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for AddressUseControllerTest
    /// </summary>
    [TestClass]
    public class AddressUseControllerTest
    {
        public AddressUseControllerTest()
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
        public void GetAllAddressUseRecords()
        {
            AddressUseController controller = new AddressUseController();
            var adds = controller.GetAllAddressUseRecords();

            Assert.IsNotNull(controller);
            Assert.IsNotNull(adds);
            Assert.AreEqual(9, adds.Count);
        }

        [TestMethod]
        public void GetAddressUseByIdFail()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetAddressUseByAddressIdPass()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetAddressUseByAddressIdFail()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetAddressUseByAddressIdAndTypeIdPass()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetAddressUseByAddressIdAndTypeIdFail()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void DeleteAddressUsePass()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void DeleteAddressUseFail()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void InsertAddressUsePass()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void InsertAddressUseFail()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void UpdateAddressUsePass()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void UpdateAddressUseFail()
        {
            AddressUseController controller = new AddressUseController();

            Assert.IsNotNull(controller);
        }
    }
}
