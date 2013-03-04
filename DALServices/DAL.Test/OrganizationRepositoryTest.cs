namespace Enterprise.DALServices.DAL.Test
{
    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void OrganizatonRepositoryGetByTypeIDFail()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var orgs = target.Get(0);

            Assert.AreEqual(0,orgs.Count);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByIDPass()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var org = target.GetByID(1);

            Assert.AreEqual("BOGE",org.Code);
        }

        [TestMethod]
        public void OrganizatonRepositoryGetByIDFail()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            var org = target.GetByID(0);

            Assert.AreEqual("", org.Code);
        }

        [TestMethod]
        public void OrganizatonRepositoryInsertPass()
        {
            OrganizationRepository target = new OrganizationRepository(context);

            Organization newOrg = new Organization()
                                      {
                                          Code = "XXXX", 
                                          Name = "Test Insert", 
                                          TypeID = 3, 
                                          StatusID = 1
                                      };

            target.Insert(newOrg);
            target.Save();

        }

        [TestMethod]
        public void OrganizatonRepositoryInsertFailDuplicateOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositoryInsertFailNullOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositoryUpdatePass()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositoryUpdateFailBadID()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositoryUpdateFailBadNullOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositoryDeletePass()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositoryDeleteFailBadID()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositoryDeleteFailNullOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositoryDeleteFailAttachedOrg()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositorySavePass()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        [TestMethod]
        public void OrganizatonRepositorySaveFail()
        {
            OrganizationRepository target = new OrganizationRepository(context);
        }

        #endregion
    }
}
