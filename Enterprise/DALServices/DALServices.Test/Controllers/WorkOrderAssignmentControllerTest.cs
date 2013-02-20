using System;
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

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetWorkOrderAssignmentByIdPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetWorkOrderAssignmentByIdFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetAllWorkOrderAssignmentsByWorkOrderIdPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetAllWorkOrderAssignmentsByWorkOrderIdFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteWorkOrderAssignmentPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteWorkOrderAssignmentFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertWorkOrderAssignmentPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertWorkOrderAssignmentFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateWorkOrderAssignmentPass()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateWorkOrderAssignmentFail()
        {
            WorkOrderAssignmentController controller = new WorkOrderAssignmentController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }
    }
}
