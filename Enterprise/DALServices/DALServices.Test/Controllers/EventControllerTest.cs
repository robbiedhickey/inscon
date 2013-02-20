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
    /// Summary description for EventControllerTest
    /// </summary>
    [TestClass]
    public class EventControllerTest
    {
        private EventController _controller;

        public EventControllerTest()
        {
            _controller = new EventController();
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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            DataHelper.LoadData("usp_LoadAllTestData.sql");
        }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetAllEvents()
        {
            var actual = _controller.GetAllEvents();

            Assert.AreEqual(6, actual.Count);
        }

        [TestMethod]
        public void GetEventByIdPass()
        {
            var actual = _controller.GetEventById(1);
            //EventID	ParentID	EntityID	TypeID	UserID	EventDate
            //1	1	20	30	40	2013-02-01 00:00:00.000
            Assert.AreEqual(1, actual.EventID);
            Assert.AreEqual(1, actual.ParentID);
            Assert.AreEqual(20, actual.EntityID);
            Assert.AreEqual(30, actual.TypeID);
            Assert.AreEqual(40, actual.UserID);
            Assert.AreEqual(new DateTime(2013, 2, 1), actual.EventDate);
        }

        [TestMethod]
        public void GetEventByIdFail()
        {
            var actual = _controller.GetEventById(200);

            Assert.IsNull(actual);
        }

        /// <summary>
        /// Not sure why this is failing.. valid record exists and DAL service is not pulling it back
        /// </summary>
        [TestMethod]
        public void GetEventByParentIdAndEntityIDPass()
        {
            var actual = _controller.GetEventByParentIdAndEntityID(1, 20);

            Assert.IsNotNull(actual);
            //EventID	ParentID	EntityID	TypeID	UserID	EventDate
            //1	1	20	30	40	2013-02-01 00:00:00.000
            Assert.AreEqual(1, actual.EventID);
            Assert.AreEqual(1, actual.ParentID);
            Assert.AreEqual(20, actual.EntityID);
            Assert.AreEqual(30, actual.TypeID);
            Assert.AreEqual(40, actual.UserID);
            Assert.AreEqual(new DateTime(2013, 2, 1), actual.EventDate);
        }

        [TestMethod]
        public void GetEventByParentIdAndEntityIDFail()
        {
            var actual = _controller.GetEventByParentIdAndEntityID(1, 200);

            Assert.IsNull(actual);

        }


        [TestMethod]
        public void DeleteEventPass()
        {
            var eventToDelete = new Event { EventID = 1 };
            _controller.DeleteRecord(eventToDelete);

            var after = _controller.GetEventById(1);

            Assert.IsNull(after);
        }

        [TestMethod]
        public void DeleteEventFail()
        {
            var eventToDelete = new Event { EventID = 100 };
            _controller.DeleteRecord(eventToDelete);

            var after = _controller.GetEventById(100);

            Assert.IsNull(after);
        }

        [TestMethod]
        public void InsertEventPass()
        {
            var eventToInsert = new Event
            {
                EventDate = new DateTime(2013, 2, 1),
                ParentID = 1,
                TypeID = 1,
                UserID = 1
            };

            var resultId = _controller.SaveRecord(eventToInsert);

            var result = _controller.GetEventById(resultId);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.EventDate == new DateTime(2013, 2, 1));
            Assert.IsTrue(result.ParentID == 1);
            Assert.IsTrue(result.TypeID == 1);
            Assert.IsTrue(result.UserID == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Needs constraints on foreign keys")]
        public void InsertEventFail()
        {
            var eventToInsert = new Event { EventDate = DateTime.Now };

            var resultId = _controller.SaveRecord(eventToInsert);
        }

        [TestMethod]
        public void UpdateEventPass()
        {
            var eventToUpdate = _controller.GetEventById(1);

            eventToUpdate.EntityID = 5;

            var resultId = _controller.SaveRecord(eventToUpdate);

            var result = _controller.GetEventById(resultId);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.EntityID == 5);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Needs constraints on foreign keys")]
        public void UpdateEventFail()
        {
            var eventToUpdate = _controller.GetEventById(1);

            eventToUpdate.TypeID = 100;
            eventToUpdate.EntityID = 200;
            eventToUpdate.TypeID = 300;

            _controller.SaveRecord(eventToUpdate);
        }
    }
}
