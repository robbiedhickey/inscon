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
    /// Summary description for AssetRepositoryTest
    /// </summary>
    [TestClass]
    public class AssetRepositoryTest : TestBase
    {
        #region Variables
        
        private TestContext testContextInstance;

        #endregion

        #region Constructors
        
        public AssetRepositoryTest()
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
        public void AssetRepositoryConstructor()
        {
            AssetRepository target = new AssetRepository();

            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void AssetRepositoryGetAll()
        {
            AssetRepository target = new AssetRepository();

            var asts = target.GetAll();

            Assert.AreEqual(9, asts.Count());
        }

        [TestMethod]
        public void AssetRepositoryGetByIDPass()
        {
            AssetRepository target = new AssetRepository();

            var ast = target.GetByID(1);

            Assert.Inconclusive();
        }

        [TestMethod]
        public void AssetRepositoryGetByIDFailNegativeID()
        {
            AssetRepository target = new AssetRepository();

            Assert.Inconclusive();
        }

        [TestMethod]
        public void AssetRepositoryGetByIDFailInvalidID()
        {
            AssetRepository target = new AssetRepository();

            Assert.Inconclusive();
        }

        [TestMethod]
        public void AssetRepositoryGetByOrgIDPass()
        {
            AssetRepository target = new AssetRepository();

            Assert.Inconclusive();
        }

        [TestMethod]
        public void AssetRepositoryGetByOrgIDFailInvalidOrgID()
        {
            AssetRepository target = new AssetRepository();

            Assert.Inconclusive();
        }

        [TestMethod]
        public void AssetRepositoryGetByOrgIDFailNegativeOrgID()
        {
            AssetRepository target = new AssetRepository();

            Assert.Inconclusive();
        }

        [TestMethod]
        public void AssetRepositoryInsertPass()
        {
            TransactionHelper.Rollback(() =>
                {
                    AssetRepository target = new AssetRepository();

                    Assert.Inconclusive();
                });
        }

        [TestMethod]
        public void AssetRepositoryInsertFailDuplicateAsset()
        {
            TransactionHelper.Rollback(() =>
            {
                AssetRepository target = new AssetRepository();

                Assert.Inconclusive();
            });
        }

        [TestMethod]
        public void AssetRepositoryInsertFailNullAsset()
        {
            TransactionHelper.Rollback(() =>
            {
                AssetRepository target = new AssetRepository();

                Assert.Inconclusive();
            });
        }

        [TestMethod]
        public void AssetRepositoryUpdatePass()
        {
            TransactionHelper.Rollback(() =>
            {
                AssetRepository target = new AssetRepository();

                Assert.Inconclusive();
            });
        }

        [TestMethod]
        public void AssetRepositoryUpdateFailBadID()
        {
            TransactionHelper.Rollback(() =>
            {
                AssetRepository target = new AssetRepository();

                Assert.Inconclusive();
            });
        }

        [TestMethod]
        public void AssetRepositoryUpdateFailNullAsset()
        {
            TransactionHelper.Rollback(() =>
            {
                AssetRepository target = new AssetRepository();

                Assert.Inconclusive();
            });
        }

        [TestMethod]
        public void AssetRepositoryDeletePass()
        {
            TransactionHelper.Rollback(() =>
            {
                AssetRepository target = new AssetRepository();

                Assert.Inconclusive();
            });
        }

        [TestMethod]
        public void AssetRepositoryDeleteFailBadID()
        {
            TransactionHelper.Rollback(() =>
            {
                AssetRepository target = new AssetRepository();

                Assert.Inconclusive();
            });
        }

        [TestMethod]
        public void AssetRepositoryDeleteFailNullAsset()
        {
            TransactionHelper.Rollback(() =>
            {
                AssetRepository target = new AssetRepository();

                Assert.Inconclusive();
            });
        }

        #endregion
    }
}
