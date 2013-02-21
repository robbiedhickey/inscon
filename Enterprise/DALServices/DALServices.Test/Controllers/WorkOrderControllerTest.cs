using System;
using System.Data.SqlClient;
using System.Linq;
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

            var actual = controller.GetAllWorkOrders();

            Assert.AreEqual(9, actual.Count);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetWorkOrderByIdPass()
        {
            WorkOrderController controller = new WorkOrderController();

            var actual = controller.GetWorkOrderById(1);
            //WorkOrderID	RequestID	AssetID	DateInserted
            //1	1	1	2013-02-19 11:22:47.863
            Assert.AreEqual(1, actual.RequestID);
            Assert.AreEqual(1, actual.WorkOrderID);
            Assert.AreEqual(1, actual.AssetID);
            Assert.IsNotNull(actual.DateInserted);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetWorkOrderByIdFail()
        {
            WorkOrderController controller = new WorkOrderController();

            var actual = controller.GetWorkOrderById(100);

            Assert.IsNull(actual);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetWorkOrdersByRequestIdPass()
        {
            WorkOrderController controller = new WorkOrderController();

            var actual = controller.GetWorkOrdersByRequestId(1);

            var record = actual.First();
            //WorkOrderID	RequestID	AssetID	DateInserted
            //1	1	1	2013-02-19 11:22:47.863
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual(1, record.RequestID);
            Assert.AreEqual(1, record.WorkOrderID);
            Assert.AreEqual(1, record.AssetID);
            Assert.IsNotNull(record.DateInserted);
        }

        [TestMethod]
        public void GetWorkOrdersByRequestIdFail()
        {
            WorkOrderController controller = new WorkOrderController();

            var actual = controller.GetWorkOrdersByRequestId(100);

            Assert.AreEqual(0, actual.Count);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetWorkOrdersByAssetIdPass()
        {
            WorkOrderController controller = new WorkOrderController();

            var actual = controller.GetWorkOrdersByAssetId(1);

            var record = actual.First();
            //WorkOrderID	RequestID	AssetID	DateInserted
            //1	1	1	2013-02-19 11:22:47.863
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual(1, record.RequestID);
            Assert.AreEqual(1, record.WorkOrderID);
            Assert.AreEqual(1, record.AssetID);
            Assert.IsNotNull(record.DateInserted);
        }

        [TestMethod]
        public void GetWorkOrdersByAssetIdFail()
        {
            WorkOrderController controller = new WorkOrderController();

            var actual = controller.GetWorkOrdersByAssetId(100);

            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void DeleteWorkOrderPass()
        {
            WorkOrderController controller = new WorkOrderController();

            var woToDelete = new WorkOrder {WorkOrderID = 1};

            var result = controller.DeleteRecord(woToDelete);

            var count = controller.GetAllWorkOrders();

            Assert.AreEqual(8, count.Count);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteWorkOrderFail()
        {
            WorkOrderController controller = new WorkOrderController();

            var woToDelete = new WorkOrder {WorkOrderID = 100};

            controller.DeleteRecord(woToDelete);

            var count = controller.GetAllWorkOrders();

            Assert.AreEqual(9, count.Count);
        }

        [TestMethod]
        public void InsertWorkOrderPass()
        {
            WorkOrderController controller = new WorkOrderController();

            var woToInsert = new WorkOrder
                {
                    DateInserted = new DateTime(2013, 2, 3),
                    AssetID = 1,
                    RequestID = 1
                };

            var resultId = controller.SaveRecord(woToInsert);

            var result = controller.GetWorkOrderById(resultId);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.AssetID);
            Assert.AreEqual(1, result.RequestID);
            Assert.AreEqual(new DateTime(2013,2,3), result.DateInserted);

        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should violate foreign key constraints")]
        public void InsertWorkOrderFail()
        {
            WorkOrderController controller = new WorkOrderController();

            var woToInsert = new WorkOrder
                {
                    DateInserted = new DateTime(2013, 2, 3),
                    AssetID = 100,
                    RequestID = 100
                };

            controller.SaveRecord(woToInsert);
        }

        [TestMethod]
        public void UpdateWorkOrderPass()
        {
            WorkOrderController controller = new WorkOrderController();

            var woToUpdate = controller.GetWorkOrderById(1);

            woToUpdate.AssetID = 2;
            woToUpdate.RequestID = 2;

            var resultId = controller.SaveRecord(woToUpdate);

            var result = controller.GetWorkOrderById(resultId);

            Assert.AreEqual(2, result.RequestID);
            Assert.AreEqual(2, result.AssetID);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should violate foreign key constraints")]
        public void UpdateWorkOrderFail()
        {
            WorkOrderController controller = new WorkOrderController();

            var woToUpdate = controller.GetWorkOrderById(1);

            woToUpdate.AssetID = 200;
            woToUpdate.RequestID = 200;

            controller.SaveRecord(woToUpdate);
        }
    }
}
