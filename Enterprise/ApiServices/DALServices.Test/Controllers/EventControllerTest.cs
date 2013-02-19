using System;
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
            Assert.AreEqual(1, actual.EventId);
            Assert.AreEqual(1, actual.ParentId);
            Assert.AreEqual(20, actual.EntityId);
            Assert.AreEqual(30, actual.TypeId);
            Assert.AreEqual(40, actual.UserId);
            Assert.AreEqual(new DateTime(2013,2,1), actual.EventDate);
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
            Assert.AreEqual(1, actual.EventId);
            Assert.AreEqual(1, actual.ParentId);
            Assert.AreEqual(20, actual.EntityId);
            Assert.AreEqual(30, actual.TypeId);
            Assert.AreEqual(40, actual.UserId);
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
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteEventFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertEventPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertEventFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateEventPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateEventFail()
        {
            Assert.Inconclusive();
        }
    }
}
