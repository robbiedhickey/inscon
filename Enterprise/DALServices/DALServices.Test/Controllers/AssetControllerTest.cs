using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for AssetControllerTest
    /// </summary>
    [TestClass]
    public class AssetControllerTest
    {
        public AssetControllerTest()
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
        public void GetAllAssets()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetAssetByIdPass()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetAssetByIdFail()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetAssetByOrganizationIDPass()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetAssetByOrganizationIDFail()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteAssetPass()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteAssetFail()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertAssetPass()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertAssetFail()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateAssetPass()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateAssetFail()
        {
            AssetController controller = new AssetController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }
    }
}
