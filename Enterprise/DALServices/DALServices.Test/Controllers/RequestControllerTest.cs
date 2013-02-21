using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for RequestControllerTest
    /// </summary>
    [TestClass]
    public class RequestControllerTest
    {
        public RequestControllerTest()
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
        public void GetAllRequests()
        {
            RequestController controller = new RequestController();

            var actual = controller.GetAllRequests();

            Assert.AreEqual(9, actual.Count);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetRequestByIdPass()
        {
            RequestController controller = new RequestController();

            var actual = controller.GetRequestById(1);

            //RequestID	DateInserted	CustomerRequestID
            //1	2013-02-19 10:45:34.863	BOGE-Req01

            Assert.AreEqual(1, actual.RequestID);
            Assert.AreEqual("2013-02-19 10:45:34.863", actual.DateInserted.ToString());
            Assert.AreEqual("BOGE-Req01", actual.CustomerRequestID);

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetRequestByIdFail()
        {
            RequestController controller = new RequestController();

            var actual = controller.GetRequestById(10);

            Assert.IsNull(actual);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void DeleteRequestPass()
        {
            RequestController controller = new RequestController();

            var requestToDelete = new Request {RequestID = 1};

            var result = controller.DeleteRecord(requestToDelete);

            Assert.IsTrue(result);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void DeleteRequestFail()
        {
            RequestController controller = new RequestController();

            var requestToDelete = new Request {RequestID = 100};

            controller.DeleteRecord(requestToDelete);

            var result = controller.GetRequestById(100);

            Assert.IsNull(result);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void InsertRequestPass()
        {
            RequestController controller = new RequestController();


            var requestToInsert = new Request
                {
                    DateInserted = new DateTime(2013, 1, 2),
                    CustomerRequestID = "1234"
                };

            var resultId = controller.SaveRecord(requestToInsert);

            var result = controller.GetRequestById(resultId);

            Assert.AreEqual(new DateTime(2013,1,2), result.DateInserted);
            Assert.AreEqual("1234", result.CustomerRequestID);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should overflow CustomerRequestId column")]
        public void InsertRequestFail()
        {
            RequestController controller = new RequestController();

            var requestToInsert = new Request();

            requestToInsert.CustomerRequestID = "123412341234123412341234123412341234124412341244121342413132323122323";
            requestToInsert.DateInserted = new DateTime(2013, 1, 3);

            controller.SaveRecord(requestToInsert);
        }

        [TestMethod]
        public void UpdateRequestPass()
        {
            RequestController controller = new RequestController();

            var requestToUpdate = controller.GetRequestById(1);

            requestToUpdate.CustomerRequestID = "1234";
            requestToUpdate.DateInserted = new DateTime(2013,1,3);

            var resultId = controller.SaveRecord(requestToUpdate);

            var result = controller.GetRequestById(resultId);

            Assert.AreEqual(new DateTime(2013,1,3), result.DateInserted);
            Assert.AreEqual("1234", result.CustomerRequestID);

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should overflow CustomerRequestId column")]
        public void UpdateRequestFail()
        {
            RequestController controller = new RequestController();

            var requestToUpdate = controller.GetRequestById(1);

            requestToUpdate.CustomerRequestID = "123412341234123412341234123412341234124412341244121342413132323122323";
            requestToUpdate.DateInserted = new DateTime(2013,1,3);

            controller.SaveRecord(requestToUpdate);
        }
    }
}
