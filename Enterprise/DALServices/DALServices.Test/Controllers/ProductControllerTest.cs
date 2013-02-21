using System;
using System.Data.SqlClient;
using System.Linq;
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

            var actual = controller.GetAllProducts();

            Assert.AreEqual(actual.Count, 11);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetProductByIdPass()
        {
            ProductController controller = new ProductController();

            //ProductID	ProductCategoryID	Caption	Code	SKU	Rate	Cost
            //1	1	Flush Galactic Dust Filtration System	MANT01	123	150.00	15.00
            var actual = controller.GetProductById(1);

            Assert.IsNotNull(actual);
            Assert.AreEqual(1, actual.ProductID);
            Assert.AreEqual(1, actual.ProductCategoryID);
            Assert.AreEqual("Flush Galactic Dust Filtration System", actual.Caption);
            Assert.AreEqual("MANT01", actual.Code);
            Assert.AreEqual("123", actual.SKU);
            Assert.AreEqual(150.00M, actual.Rate);
            Assert.AreEqual(15.00M, actual.Cost);

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetProductByIdFail()
        {
            ProductController controller = new ProductController();

            var actual = controller.GetProductById(100);

            Assert.IsNull(actual);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetProductsByCategoryIdPass()
        {
            ProductController controller = new ProductController();

            var actual = controller.GetProductsByCategoryId(1);

            Assert.AreEqual(5, actual.Count);
            Assert.AreEqual(true, actual.Any(p => p.Code == "MANT01"));
            Assert.AreEqual(true, actual.Any(p => p.Code == "MANT02"));
            Assert.AreEqual(true, actual.Any(p => p.Code == "MANT03"));
            Assert.AreEqual(true, actual.Any(p => p.Code == "MANT04"));
            Assert.AreEqual(true, actual.Any(p => p.Code == "MANT05"));

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void GetProductsByCategoryIdFail()
        {
            ProductController controller = new ProductController();

            var actual = controller.GetProductsByCategoryId(100);

            Assert.AreEqual(0, actual.Count);

            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void DeleteProductPass()
        {
            ProductController controller = new ProductController();
            var productToDelete = new Product {ProductID = 11};
            var result = controller.DeleteRecord(productToDelete);

            Assert.IsNotNull(controller);
            Assert.IsTrue(result);
        }
        // HACK: this is only true if the product has a dependant record.  If it was just added the product will delete.
        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should receive foreign key constraint violation on WorkOrderItems")]
        public void DeleteProductFail()
        {
            ProductController controller = new ProductController();

            var productToDelete = new Product {ProductID = 1};

            controller.DeleteRecord(productToDelete);
        }

        [TestMethod]
        public void InsertProductPass()
        {
            ProductController controller = new ProductController();

            var productToInsert = new Product
                {
                    ProductCategoryID = 2,
                    Caption = "Hitchhiker's Guide To The Galaxy",
                    Code = "ERHM01",
                    SKU = "100",
                    Rate = 1000M,
                    Cost = 100M
                };

            var resultId = controller.SaveRecord(productToInsert);

            var result = controller.GetProductById(resultId);

            Assert.IsNotNull(result);
            Assert.AreEqual(12, result.ProductID);
            Assert.AreEqual(2, result.ProductCategoryID);
            Assert.AreEqual("Hitchhiker's Guide To The Galaxy", result.Caption);
            Assert.AreEqual("ERHM01", result.Code);
            Assert.AreEqual("100", result.SKU);
            Assert.AreEqual(1000M, result.Rate);
            Assert.AreEqual(100M, result.Cost);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should enforce uniqueness of Caption and possibly Code")]
        public void InsertProductFail()
        {
            ProductController controller = new ProductController();

            var productToInsert = new Product
            {
                ProductCategoryID = 100,
                Caption = "Flush Galactic Dust Filtration System",
                Code = "MANT01",
            };

            controller.SaveRecord(productToInsert);
        }

        [TestMethod]
        public void UpdateProductPass()
        {
            ProductController controller = new ProductController();

            var productToUpdate = controller.GetProductById(1);

            productToUpdate.Code = "MERG01";
            productToUpdate.Caption = "Something else";
            productToUpdate.SKU = "122";
            productToUpdate.Rate = 100M;
            productToUpdate.Cost = 10M;

            var resultId = controller.SaveRecord(productToUpdate);

            var result = controller.GetProductById(resultId);

            Assert.IsNotNull(result);
            Assert.AreEqual("MERG01", result.Code);
            Assert.AreEqual("Something else", result.Caption);
            Assert.AreEqual("122", result.SKU);
            Assert.AreEqual(100M, result.Rate);
            Assert.AreEqual(10M, result.Cost);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException), "Should enforce uniqueness of Caption and possibly Code")]
        public void UpdateProductFail()
        {
            ProductController controller = new ProductController();

            var productToUpdate = controller.GetProductById(1);

            productToUpdate.ProductCategoryID = 100;
            productToUpdate.Code = "MANT02";
            productToUpdate.Caption = "Reseal Outer Shell Seams with Dark Matter Sealant";

            controller.SaveRecord(productToUpdate);
        }
    }
}
