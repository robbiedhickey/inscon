using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.DALServices.DAL.Test
{
    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories;

    /// <summary>
    /// Summary description for AssetRepositoryTest
    /// </summary>
    [TestClass]
    public class AssetRepositoryTest
    {
        private EnterpriseDbContext context;

        public AssetRepositoryTest()
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
        }

        public void GetByOrgIDPass()
        {
        }

        public void GetByOrgIDFail()
        {
        }

        public void GetByIDPass()
        {
        }

        public void GetByIDFail()
        {
        }

        public void InsertPass()
        {
        }

        public void InsertFail()
        {
        }

        public void UpdatePass()
        {
        }

        public void UpdateFail()
        {
        }

        public void DeletePass()
        {
        }

        public void DeleteFail()
        {
        }

        public void SavePass()
        {
        }

        public void SaveFail()
        {
        }
    }
}
