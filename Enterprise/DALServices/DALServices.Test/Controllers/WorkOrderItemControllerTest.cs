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
    /// Summary description for WorkOrderItemControllerTest
    /// </summary>
    [TestClass]
    public class WorkOrderItemControllerTest
    {
        public WorkOrderItemControllerTest()
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
        public void GetAllWorkOrderItems()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var result = controller.GetAllWorkOrderItems();

            Assert.AreEqual(27, result.Count);
        }

        [TestMethod]
        public void GetWorkOrderItemByIdPass()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var result = controller.GetWorkOrderItemById(1);

            //WorkOrderItemID	WorkOrderID	ProductID	Quantity	Rate	DateInserted
            //1	1	1	1.00	150.00	2013-02-19 11:56:13.480
            Assert.AreEqual(1, result.WorkOrderItemID);
            Assert.AreEqual(1, result.WorkOrderID);
            Assert.AreEqual(1, result.ProductID);
            Assert.AreEqual(1.00M, result.Quantity);
            Assert.AreEqual(150.00M, result.Rate);
            Assert.IsNotNull(result.DateInserted);
        }

        [TestMethod]
        public void GetWorkOrderItemByIdFail()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var result = controller.GetWorkOrderItemById(100);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetWorkOrderItemsByWorkOrderIdPass()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var result = controller.GetWorkOrderItemsByWorkOrderId(1);

            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Any(w => w.ProductID == 1));
            Assert.IsTrue(result.Any(w => w.ProductID == 2));
            Assert.IsTrue(result.Any(w => w.ProductID == 4));
        }

        [TestMethod]
        public void GetWorkOrderItemsByWorkOrderIdFail()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var result = controller.GetWorkOrderItemsByWorkOrderId(100);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void DeleteWorkOrderItemPass()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var woToDelete = new WorkOrderItem {WorkOrderItemID = 1};

            var result = controller.DeleteRecord(woToDelete);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteWorkOrderItemFail()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var woToDelete = new WorkOrderItem {WorkOrderItemID = 100};

            controller.DeleteRecord(woToDelete);

            var count = controller.GetAllWorkOrderItems();

            Assert.AreEqual(27, count.Count);
        }

        [TestMethod]
        public void InsertWorkOrderItemPass()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var woToInsert = new WorkOrderItem
                {
                    WorkOrderID = 1,
                    ProductID = 3,
                    Quantity = 5.0M,
                    Rate = 400.00M,
                    DateInserted = DateTime.Now
                };

            var resultId = controller.SaveRecord(woToInsert);

            var result = controller.GetWorkOrderItemById(resultId);

            Assert.AreEqual(1, result.WorkOrderID);
            Assert.AreEqual(3, result.ProductID);
            Assert.AreEqual(5.0M, result.Quantity);
            Assert.AreEqual(400.00M, result.Rate);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should violate foreign key and not null constraints")]
        public void InsertWorkOrderItemFail()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var woToInsert = new WorkOrderItem
                {
                    WorkOrderID = 100,
                    ProductID = 300,
                    DateInserted = DateTime.Now
                };

            controller.SaveRecord(woToInsert);
        }

        [TestMethod]
        public void UpdateWorkOrderItemPass()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var woToUpdate = controller.GetWorkOrderItemById(1);

            woToUpdate.WorkOrderID = 4;
            woToUpdate.ProductID = 5;
            woToUpdate.Quantity = 15.0M;
            woToUpdate.Rate = 1000.40M;

            var resultId = controller.SaveRecord(woToUpdate);

            var result = controller.GetWorkOrderItemById(resultId);

            Assert.AreEqual(4, result.WorkOrderID);
            Assert.AreEqual(5, result.ProductID);
            Assert.AreEqual(15.0M, result.Quantity);
            Assert.AreEqual(1000.40M, result.Rate);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should violate foreign key constraints")]
        public void UpdateWorkOrderItemFail()
        {
            WorkOrderItemController controller = new WorkOrderItemController();

            var woToUpdate = controller.GetWorkOrderItemById(1);

            woToUpdate.ProductID = 500;
            woToUpdate.WorkOrderID = 400;

            controller.SaveRecord(woToUpdate);
        }
    }
}
