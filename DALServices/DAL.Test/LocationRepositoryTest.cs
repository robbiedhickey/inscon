using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.DALServices.DAL.Test
{
    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories;

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
        public void Get()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void GetByOrgIDPass()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void GetByOrgIDFail()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void GetOrgIDTypeIDPass()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void GetOrgIDTypeIDFail()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void GetByIDPass()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void GetByIDFail()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void InsertPass()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void InsertFail()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void UpdatePass()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void UpdateFail()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void DeletePass()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void DeleteFail()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void SavePass()
        {
            LocationRepository target = new LocationRepository(context);
        }

        [TestMethod]
        public void SaveFail()
        {
            LocationRepository target = new LocationRepository(context);
        }
    }
}
