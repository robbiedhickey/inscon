namespace Enterprise.DALServices.DAL.Test
{
    using System.Linq;

    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories;
    using Enterprise.DALServices.DAL.Test.Helpers;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Data.Entity.Infrastructure;

    /// <summary>
    /// Summary description for LocationRepositoryTest
    /// </summary>
    [TestClass]
    public class LocationRepositoryTest : TestBase
    {
        #region Variables
        
        private TestContext testContextInstance;

        #endregion

        #region Constructors
        
        public LocationRepositoryTest()
        {
            UnitOfWork = new EfUnitOfWork();
        }

        #endregion

        #region Properties
        
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

        #endregion

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
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Tests

        [TestMethod]
        public void LocationRepositoryConstructorTest()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void LocationRepositoryGetAll()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetAll();

            Assert.AreEqual(9, locs.Count());
        }

        //public void LocationRepositoryGetByIDPass()
        //public void LocationRepositoryGetByIDFail()
        //public void LocationRepositoryGetByIDFail()


        [TestMethod]
        public void LocationRepositoryInsertPass()
        {
            TransactionHelper.Rollback(() =>
                {
                    LocationRepository target = new LocationRepository(UnitOfWork);

                    Location loc = new Location()
                    {
                        OrganizationID = 1,
                        Name = "Home Office",
                        Code = "BOGE01",
                        TypeID = 11
                    };

                    target.Add(loc);
                    UnitOfWork.Commit();

                    Assert.AreEqual(10,loc.LocationID);
                });
        }

        #endregion
    }
}
