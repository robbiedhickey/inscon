using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.DAL.Test
{
    using Enterprise.DAL.Models;
    using Enterprise.DAL.Repositories;

    /// <summary>
    /// Summary description for LocationRepositoryTest
    /// </summary>
    [TestClass]
    public class LocationRepositoryTest
    {
        private EnterpriseDbContext context;

        public LocationRepositoryTest()
        {
            context = new EnterpriseDbContext();
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
        public void LocationDelete()
        {
            var target = new LocationRepository(context);
            Location loc = new Location()
            {
                OrganizationID = 3,
                Name = "Test Location",
                Code = "TEST",
                TypeID = 12
            };

            target.Insert(loc);
            target.Save();
            var newLoc = target.GetByID(10);
            target.Delete(newLoc.LocationID);
            target.Save();
            var deadLoc = target.GetByID(newLoc.LocationID);

            Assert.IsNotNull(target);
            Assert.IsNull(deadLoc);
        }
    }
}
