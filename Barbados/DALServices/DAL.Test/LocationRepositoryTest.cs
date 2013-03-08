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

        [TestMethod]
        public void LocationRepositoryGetByIDPass()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var loc = target.GetByID(1);

            Assert.AreEqual("BOGE01", loc.Code);
        }

        [TestMethod]
        public void LocationRepositoryGetByIDFailInvaidID()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var loc = target.GetByID(0);

            Assert.IsNull(loc);
        }

        [TestMethod]
        public void LocationRepositoryGetByIDFailNegativeID()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var loc = target.GetByID(-1);

            Assert.IsNull(loc);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDPass()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(1);

            Assert.AreEqual(3, locs.Count);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDFailBadOrgID()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(0);

            Assert.IsNull(locs);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDFailNegativeOrgID()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(-1);

            Assert.IsNull(locs);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDTypeIDPass()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(1, 11);

            Assert.AreEqual(1, locs.Count);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDTypeIDFailBadOrgID()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(0, 11);

            Assert.IsNull(locs);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDTypeIDFailNegativeOrgID()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(-1, 11);

            Assert.IsNull(locs);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDTypeIDFailBadTypeID()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(1, 0);

            Assert.IsNull(locs);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDTypeIDFailNegativeTypeID()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(1, -1);

            Assert.IsNull(locs);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDTypeIDFailBadIDs()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(0, 0);

            Assert.IsNull(locs);
        }

        [TestMethod]
        public void LocationRepositoryGetByOrgIDTypeIDFailNegativeIDs()
        {
            LocationRepository target = new LocationRepository(UnitOfWork);

            var locs = target.GetBy(-1, -1);

            Assert.IsNull(locs);
        }

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

        [TestMethod]
        public void LocationRepositoryInsertFailDuplicateLocation()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                Location loc = new Location()
                {
                    OrganizationID = 1,
                    Name = "Bank of the Outer Galactic Empire",
                    Code = "BOGE01",
                    TypeID = 11
                };

                target.Add(loc);
                UnitOfWork.Commit();
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LocationRepositoryInsertFailNullLocation()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                Location loc = null;

                target.Add(loc);
                UnitOfWork.Commit();
            });
        }

        [TestMethod]
        public void LocationRepositoryUpdatePass()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                var loc = target.GetByID(1);
                loc.Name = "Update Test";

                target.Update(loc);
                UnitOfWork.Commit();

                var savedLoc = target.GetByID(1);

                Assert.AreEqual(loc.Name, savedLoc.Name);
            });
        }

        [TestMethod]
        public void LocationRepositoryUpdateFailDuplicateLocation()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                var loc = target.GetByID(1);

                loc.Code = "BOGE02";
                loc.Name = "Greater Helium Branch";
                loc.TypeID = 12;

                target.Update(loc);
                UnitOfWork.Commit();
            });
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void LocationRepositoryUpdateFailBadID()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                Location loc = new Location()
                {
                    LocationID = 100,
                    OrganizationID = 1,
                    Name = "Bank of the Outer Galactic Empire",
                    Code = "BOGE01",
                    TypeID = 11
                };

                target.Update(loc);
                UnitOfWork.Commit();
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LocationRepositoryUpdateFailNullLocation()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                Location loc = null;

                target.Update(loc);
                UnitOfWork.Commit();
            });
        }

        [TestMethod]
        public void LocationRepositoryDeletePass()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                Location loc = new Location()
                {
                    OrganizationID = 1,
                    Name = "Delete Pass",
                    Code = "BOGE04",
                    TypeID = 12
                };

                target.Add(loc);
                UnitOfWork.Commit();

                var savedLoc = target.GetByID(loc.LocationID);
                target.Remove(savedLoc);
                UnitOfWork.Commit();

                var chkLoc = target.GetByID(loc.LocationID);

                Assert.IsNull(chkLoc);
            });
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LocationRepositoryDeleteFailBadID()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                Location loc = new Location()
                {
                    OrganizationID = 1,
                    Name = "Delete Pass",
                    Code = "BOGE04",
                    TypeID = 12
                };

                target.Add(loc);
                UnitOfWork.Commit();

                var savedLoc = target.GetByID(loc.LocationID);
                savedLoc.LocationID = 100;
                target.Remove(savedLoc);
                UnitOfWork.Commit();

                var chkLoc = target.GetByID(loc.LocationID);
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LocationRepositoryDeleteFailNullLocation()
        {
            TransactionHelper.Rollback(() =>
            {
                LocationRepository target = new LocationRepository(UnitOfWork);

                Location loc = null;

                target.Remove(loc);
                UnitOfWork.Commit();
            });
        }

        #endregion
    }
}
