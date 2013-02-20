using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for ProductControllerTest
    /// </summary>
    [TestClass]
    public class ProductControllerTest
    {
        public ProductControllerTest()
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
        public void GetAllProducts()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetProductByIdPass()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetProductByIdFail()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetProductsByCategoryIdPass()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetProductsByCategoryIdFail()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteProductPass()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteProductFail()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertProductPass()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertProductFail()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateProductPass()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateProductFail()
        {
            ProductController controller = new ProductController();

            Assert.IsNotNull(controller);
            Assert.Inconclusive();
        }
    }
}
