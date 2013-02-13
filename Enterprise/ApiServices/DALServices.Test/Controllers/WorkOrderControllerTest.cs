using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for WorkOrderControllerTest
    /// </summary>
    [TestClass]
    public class WorkOrderControllerTest
    {
        public WorkOrderControllerTest()
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
        public void GetAllWorkOrders()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetWorkOrderByIdPass()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetWorkOrderByIdFail()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetWorkOrdersByRequestIdPass()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetWorkOrdersByRequestIdFail()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetWorkOrdersByAssetIdPass()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetWorkOrdersByAssetIdFail()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteWorkOrderPass()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteWorkOrderFail()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertWorkOrderPass()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertWorkOrderFail()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateWorkOrderPass()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateWorkOrderFail()
        {
            WorkOrderController controller = new WorkOrderController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }
    }
}
