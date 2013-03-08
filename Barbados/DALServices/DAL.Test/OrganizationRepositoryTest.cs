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
    /// Summary description for OrganizationRepositoryTest
    /// </summary>
    [TestClass]
    public class OrganizationRepositoryTest : TestBase
    {
        #region Variables

        private TestContext testContextInstance;

        #endregion

        #region Constructors
        
        public OrganizationRepositoryTest()
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

        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Tests

        [TestMethod]
        public void OrganizatonRepositoryConstructor()
        {
            OrganizationRepository target = new OrganizationRepository(UnitOfWork);

            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetAll()
        {
            OrganizationRepository target = new OrganizationRepository(UnitOfWork);

            var orgs = target.GetAll();

            Assert.AreEqual(3, orgs.Count());
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByTypeIDPass()
        {
            OrganizationRepository target = new OrganizationRepository(UnitOfWork);

            var orgs = target.GetBy(3);

            Assert.AreEqual(3,orgs.Count);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByTypeIDFailBadTypeID()
        {
            OrganizationRepository target = new OrganizationRepository(UnitOfWork);

            var orgs = target.GetBy(0);

            Assert.IsNull(orgs);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByTypeIDFailNegativeTypeID()
        {
            OrganizationRepository target = new OrganizationRepository(UnitOfWork);

            var orgs = target.GetBy(-1);

            Assert.IsNull(orgs);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByIDPass()
        {
            OrganizationRepository target = new OrganizationRepository(UnitOfWork);

            var org = target.GetByID(1);

            Assert.AreEqual("BOGE", org.Code);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByIDFailNegativeID()
        {
            OrganizationRepository target = new OrganizationRepository(UnitOfWork);

            var org = target.GetByID(-1);

            Assert.IsNull(org);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByIDFailInvalidID()
        {
            OrganizationRepository target = new OrganizationRepository(UnitOfWork);

            var org = target.GetByID(0);

            Assert.IsNull(org);
        }

        [TestMethod]
        public void OrganizatonRepositoryInsertPass()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    Organization newOrg = new Organization()
                    {
                        Code = "XXXX",
                        Name = "Insert Test",
                        TypeID = 3,
                        StatusID = 1
                    };

                    target.Add(newOrg);
                    UnitOfWork.Commit();

                    Assert.AreEqual(4, newOrg.OrganizationID);
                });
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void OrganizatonRepositoryInsertFailDuplicateOrg()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    Organization newOrg = new Organization()
                    {
                        Code = "BOGE",
                        Name = "Bank of the Outer Galactic Empire",
                        TypeID = 3,
                        StatusID = 1
                    };

                    target.Add(newOrg);
                    UnitOfWork.Commit();
                });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrganizatonRepositoryInsertFailNullOrg()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    Organization newOrg = null;

                    target.Add(newOrg);
                    UnitOfWork.Commit();
                });
        }

        [TestMethod]
        public void OrganizatonRepositoryUpdatePass()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    var org = target.GetByID(1);
                    org.Name = "Update Test";
                    target.Update(org);

                    var savedOrg = target.GetByID(1);

                    Assert.AreEqual(org.Name, savedOrg.Name);
                });
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void OrganizatonRepositoryUpdateFailBadID()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    Organization org = new Organization()
                    {
                        OrganizationID = 100,
                        Code = "BOGE",
                        Name = "Bank of the Outer Galactic Empire",
                        TypeID = 3,
                        StatusID = 1
                    };

                    target.Update(org);
                    UnitOfWork.Commit();
                });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrganizatonRepositoryUpdateFailBadNullOrg()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    Organization org = null;

                    target.Update(org);
                    UnitOfWork.Commit();
                });
        }

        [TestMethod]
        public void OrganizatonRepositoryDeletePass()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    Organization org = new Organization()
                    {
                        Code = "XXXX",
                        Name = "Delete Test",
                        TypeID = 3,
                        StatusID = 1
                    };

                    target.Add(org);
                    UnitOfWork.Commit();

                    var savedOrg = target.GetByID(org.OrganizationID);
                    target.Remove(savedOrg);
                    UnitOfWork.Commit();

                    var chkOrg = target.GetByID(org.OrganizationID);

                    Assert.IsNull(chkOrg);
                });
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void OrganizatonRepositoryDeleteFailBadID()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    Organization org = new Organization()
                    {
                        Code = "XXXX",
                        Name = "Delete Test",
                        TypeID = 3,
                        StatusID = 1
                    };

                    target.Add(org);
                    UnitOfWork.Commit();

                    var savedOrg = target.GetByID(org.OrganizationID);
                    savedOrg.OrganizationID = 100;
                    target.Remove(savedOrg);
                    UnitOfWork.Commit();

                    var chkOrg = target.GetByID(org.OrganizationID);
                });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrganizatonRepositoryDeleteFailNullOrg()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    Organization org = null;

                    target.Remove(org);
                    UnitOfWork.Commit();
                });
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void OrganizatonRepositoryDeleteFailAttachedOrg()
        {
            TransactionHelper.Rollback(() =>
                {
                    OrganizationRepository target = new OrganizationRepository(UnitOfWork);

                    var org = target.GetByID(1);

                    target.Remove(org);
                    UnitOfWork.Commit();
                });
        }

        #endregion
    }
}
