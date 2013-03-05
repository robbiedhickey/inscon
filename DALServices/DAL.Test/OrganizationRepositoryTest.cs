namespace Enterprise.DALServices.DAL.Test
{
    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Data.Entity.Infrastructure;

    /// <summary>
    /// Summary description for OrganizationRepositoryTest
    /// </summary>
    [TestClass]
    public class OrganizationRepositoryTest
    {
        #region Variables

        private TestContext testContextInstance;
        private EnterpriseDbContext context;

        #endregion

        #region Constructors
        
        public OrganizationRepositoryTest()
        {
            context = new EnterpriseDbContext();
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

        #region Tests

        [TestMethod]
        public void OrganizatonRepositoryConstructor()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetAll()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var orgs = target.Get();

            Assert.AreEqual(3, orgs.Count);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByTypeIDPass()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var orgs = target.Get(3);

            Assert.AreEqual(3,orgs.Count);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByTypeIDFailBadTypeID()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var orgs = target.Get(0);

            Assert.IsNull(orgs);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByTypeIDFailNegativeTypeID()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var orgs = target.Get(-1);

            Assert.IsNull(orgs);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByIDPass()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var org = target.GetByID(1);

            Assert.AreEqual("BOGE", org.Code);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByIDFailNegativeID()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var org = target.GetByID(-1);

            Assert.IsNull(org);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByIDFailInvalidID()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var org = target.GetByID(0);

            Assert.IsNull(org);
        }

        [TestMethod]
        public void OrganizatonRepositoryInsertPass()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization newOrg = new Organization()
                                      {
                                          Code = "XXXX", 
                                          Name = "Insert Test", 
                                          TypeID = 3, 
                                          StatusID = 1
                                      };

            target.Insert(newOrg);
            target.Save();

            Assert.AreEqual(4, newOrg.OrganizationID);
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void OrganizatonRepositoryInsertFailDuplicateOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization newOrg = new Organization()
            {
                Code = "BOGE",
                Name = "Bank of the Outer Galactic Empire",
                TypeID = 3,
                StatusID = 1
            };

            target.Insert(newOrg);
            target.Save();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrganizatonRepositoryInsertFailNullOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization newOrg = null;

            target.Insert(newOrg);
            target.Save();
        }

        [TestMethod]
        public void OrganizatonRepositoryUpdatePass()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var org = target.GetByID(1);
            org.Name = "Update Test";
            target.Update(org);

            var savedOrg = target.GetByID(1);

            Assert.AreEqual(org.Name, savedOrg.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void OrganizatonRepositoryUpdateFailBadID()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization org = new Organization()
            {
                OrganizationID = 100,
                Code = "BOGE",
                Name = "Bank of the Outer Galactic Empire",
                TypeID = 3,
                StatusID = 1
            };

            target.Update(org);
            target.Save();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrganizatonRepositoryUpdateFailBadNullOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization org = null;

            target.Update(org);
            target.Save();
        }

        [TestMethod]
        public void OrganizatonRepositoryDeletePass()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization org = new Organization()
            {
                Code = "XXXX",
                Name = "Delete Test",
                TypeID = 3,
                StatusID = 1
            };

            target.Insert(org);
            target.Save();

            var savedOrg = target.GetByID(org.OrganizationID);
            target.Delete(savedOrg);
            target.Save();

            var chkOrg = target.GetByID(org.OrganizationID);

            Assert.IsNull(chkOrg);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void OrganizatonRepositoryDeleteFailBadID()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization org = new Organization()
            {
                Code = "XXXX",
                Name = "Delete Test",
                TypeID = 3,
                StatusID = 1
            };

            target.Insert(org);
            target.Save();

            var savedOrg = target.GetByID(org.OrganizationID);
            savedOrg.OrganizationID = 100;
            target.Delete(savedOrg);
            target.Save();

            var chkOrg = target.GetByID(org.OrganizationID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrganizatonRepositoryDeleteFailNullOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization org = null;

            target.Delete(org);
            target.Save();
        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void OrganizatonRepositoryDeleteFailAttachedOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var org = target.GetByID(1);

            target.Delete(org);
            target.Save();

            Assert.Inconclusive();
        }

        #endregion
    }
}
