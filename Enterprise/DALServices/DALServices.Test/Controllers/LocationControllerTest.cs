using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for LocationControllerTest
    /// </summary>
    [TestClass]
    public class LocationControllerTest
    {
        public LocationControllerTest()
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
        public void GetAllLocations()
        {
            LocationController controller = new LocationController();

            var actual = controller.GetAllLocations();

            Assert.IsNotNull(controller);
            Assert.AreEqual(9, actual.Count);
        }

        [TestMethod]
        public void GetLocationByIdPass()
        {
            LocationController controller = new LocationController();

            var actual = controller.GetLocationById(1);

            //LocationID	OrganizationID	Name	Code	TypeID
            //1	1	Bank of the Outer Galactic Empire	BOGE01	11
            Assert.IsNotNull(controller);
            Assert.AreEqual(actual.LocationID, 1);
            Assert.AreEqual(actual.OrganizationID, 1);
            Assert.AreEqual(actual.Name, "Bank of the Outer Galactic Empire");
            Assert.AreEqual(actual.Code, "BOGE01");
            Assert.AreEqual(actual.TypeID, 11);
        }

        [TestMethod]
        public void GetLocationByIdFail()
        {
            LocationController controller = new LocationController();

            var actual = controller.GetLocationById(100);

            Assert.IsNotNull(controller);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetLocationsByOrganizationIdPass()
        {
            LocationController controller = new LocationController();

            var actual = controller.GetLocationsByOrganizationId(1);
            Assert.IsNotNull(controller);
            Assert.AreEqual(3, actual.Count);
            Assert.IsTrue(actual.Any(l => l.Name == "Bank of the Outer Galactic Empire"));
            Assert.IsTrue(actual.Any(l => l.Name == "Greater Helium Branch"));
            Assert.IsTrue(actual.Any(l => l.Name == "Wastelands Branch"));
        }

        [TestMethod]
        public void GetLocationsByOrganizationIdFail()
        {
            LocationController controller = new LocationController();

            var actual = controller.GetLocationsByOrganizationId(100);
            Assert.IsNotNull(controller);
            Assert.AreEqual(actual.Count, 0);
        }

        [TestMethod]
        public void GetLocationsByOrganizationIdandTypeIdPass()
        {
            LocationController controller = new LocationController();

            var actual = controller.GetLocationsByOrganizationIdandTypeId(1, 12);
            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.Count, 2);
            Assert.IsTrue(actual.Any(l => l.Name == "Greater Helium Branch"));
            Assert.IsTrue(actual.Any(l => l.Name == "Wastelands Branch"));
        }

        [TestMethod]
        public void GetLocationsByOrganizationIdandTypeIdFail()
        {
            LocationController controller = new LocationController();

            var actual = controller.GetLocationsByOrganizationIdandTypeId(200, 200);
            Assert.IsNotNull(controller);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void DeleteLocationPass()
        {
            LocationController controller = new LocationController();

            var locationToDelete = new Location { LocationID = 1 };

            controller.DeleteRecord(locationToDelete);

            var postDelete = controller.GetLocationById(1);

            Assert.IsNull(postDelete);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void DeleteLocationFail()
        {
            LocationController controller = new LocationController();

            var locationToDelete = new Location { LocationID = 100 };

            controller.DeleteRecord(locationToDelete);

            var postDelete = controller.GetLocationById(100);

            Assert.IsNull(postDelete);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void InsertLocationPass()
        {
            LocationController controller = new LocationController();

            var locationToInsert = new Location
            {
                Name = "Some place purdy",
                OrganizationID = 1,
                TypeID = 1,
                Code = "OSLO"
            };

            var resultId = controller.SaveRecord(locationToInsert);

            var result = controller.GetLocationById(resultId);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Name == "Some place purdy");
            Assert.IsTrue(result.OrganizationID == 1);
            Assert.IsTrue(result.TypeID == 1);
            Assert.IsTrue(result.Code == "OSLO");
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void InsertLocationFail()
        {
            LocationController controller = new LocationController();

            var locationToInsert = new Location
            {
                Code = "OSLO"
            };

            var resultId = controller.SaveRecord(locationToInsert);

            var result = controller.GetLocationById(resultId);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Name == "Some place purdy");
            Assert.IsTrue(result.OrganizationID == 1);
            Assert.IsTrue(result.TypeID == 1);
            Assert.IsTrue(result.Code == "OSLO");
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void UpdateLocationPass()
        {
            LocationController controller = new LocationController();

            var locationToUpdate = controller.GetLocationById(1);

            locationToUpdate.Name = "A much better name";

            var resultId = controller.SaveRecord(locationToUpdate);

            var result = controller.GetLocationById(resultId);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Name == "A much better name");
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should enforce constraints")]
        public void UpdateLocationFail()
        {
            LocationController controller = new LocationController();

            var locationToUpdate = controller.GetLocationById(1);

            locationToUpdate.Name = "Wastelands Branch";

            controller.SaveRecord(locationToUpdate);
        }
    }
}
