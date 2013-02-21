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
    /// Summary description for WorkOrderAssignmentControllerTest
    /// </summary>
    [TestClass]
    public class WorkOrderAssignmentControllerTest
    {
        public WorkOrderAssignmentControllerTest()
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
        public void GetAllWorkOrderAssignments()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var actual = controller.GetAllWorkOrderAssignments();

            Assert.AreEqual(5, actual.Count);
        }

        [TestMethod]
        public void GetWorkOrderAssignmentByIdPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var actual = controller.GetWorkOrderAssignmentById(1);

            //WorkOrderAssignmentID	WorkOrderID	UserID	EventDate	StatusID
            //1	1	1	2013-02-03 00:00:00.000	1
            Assert.AreEqual(1, actual.WorkOrderAssignmentID);
            Assert.AreEqual(1, actual.WorkOrderID);
            Assert.AreEqual(1, actual.UserID);
            Assert.AreEqual(new DateTime(2013, 2, 3), actual.EventDate);
            Assert.AreEqual(1, actual.StatusID);
        }

        [TestMethod]
        public void GetWorkOrderAssignmentByIdFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var actual = controller.GetWorkOrderAssignmentById(100);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetAllWorkOrderAssignmentsByWorkOrderIdPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var actual = controller.GetAllWorkOrderAssignmentsByWorkOrderId(1);

            Assert.AreEqual(2, actual.Count);
            Assert.IsTrue(actual.Any(w => w.UserID == 1));
            Assert.IsTrue(actual.Any(w => w.UserID == 2));
        }

        [TestMethod]
        public void GetAllWorkOrderAssignmentsByWorkOrderIdFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var actual = controller.GetAllWorkOrderAssignmentsByWorkOrderId(100);

            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void DeleteWorkOrderAssignmentPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var woaToDelete = new WorkOrderAssignment {WorkOrderAssignmentID = 1};

            var result = controller.DeleteRecord(woaToDelete);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteWorkOrderAssignmentFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var woaToDelete = new WorkOrderAssignment {WorkOrderAssignmentID = 100};

            controller.DeleteRecord(woaToDelete);

            var count = controller.GetAllWorkOrderAssignments();

            Assert.AreEqual(5, count.Count);
        }

        [TestMethod]
        public void InsertWorkOrderAssignmentPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var woaToInsert = new WorkOrderAssignment
                {
                    WorkOrderID = 5,
                    UserID = 5,
                    EventDate = new DateTime(2013, 2, 4),
                    StatusID = 6
                };

            var resultId = controller.SaveRecord(woaToInsert);

            var result = controller.GetWorkOrderAssignmentById(resultId);

            Assert.AreEqual(5, result.WorkOrderID);
            Assert.AreEqual(5, result.UserID);
            Assert.AreEqual(new DateTime(2013,2,4), result.EventDate);
            Assert.AreEqual(6, result.StatusID);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should violate foreign key constraints")]
        public void InsertWorkOrderAssignmentFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var woaToInsert = new WorkOrderAssignment
                {
                    WorkOrderID = 100,
                    UserID = 100,
                    EventDate = new DateTime(2013, 2, 4),
                    StatusID = 600
                };

            controller.SaveRecord(woaToInsert);
        }

        [TestMethod]
        public void UpdateWorkOrderAssignmentPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var woaToUpdate = controller.GetWorkOrderAssignmentById(1);

            woaToUpdate.WorkOrderID = 5;
            woaToUpdate.UserID = 4;
            woaToUpdate.StatusID = 6;

            var resultId = controller.SaveRecord(woaToUpdate);

            var result = controller.GetWorkOrderAssignmentById(resultId);

            Assert.AreEqual(5, result.WorkOrderID);
            Assert.AreEqual(4, result.UserID);
            Assert.AreEqual(6, result.StatusID);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should violate foreign key constraints")]
        public void UpdateWorkOrderAssignmentFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            var woaToUpdate = controller.GetWorkOrderAssignmentById(1);

            woaToUpdate.WorkOrderID = 100;
            woaToUpdate.UserID = 400;
            woaToUpdate.StatusID = 600;

            controller.SaveRecord(woaToUpdate);
        }
    }
}
