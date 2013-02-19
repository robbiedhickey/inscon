using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for ProductCategoryControllerTest
    /// </summary>
    [TestClass]
    public class ProductCategoryControllerTest
    {
        public ProductCategoryControllerTest()
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
        public void GetAllProductCategories()
        {
            ProductCategoryController controller = new ProductCategoryController();
            var cats = controller.GetAllProductCategories();

            Assert.IsNotNull(controller);
            Assert.IsNotNull(cats);
            Assert.AreEqual(2, cats.Count);
        }

        [TestMethod]
        public void GetProductCategoryByIdPass()
        {
            ProductCategoryController controller = new ProductCategoryController();
            var cat = controller.GetProductCategoryById(1);

            Assert.IsNotNull(controller);
            Assert.IsNotNull(cat);
            Assert.AreEqual("Maintenance", cat.Name);
            Assert.AreEqual("MANT", cat.Code);
        }

        [TestMethod]
        public void GetProductCategoryByIdFail()
        {
            ProductCategoryController controller = new ProductCategoryController();
            var cat = controller.GetProductCategoryById(100);

            Assert.IsNotNull(controller);
            Assert.IsNull(cat);
        }

        [TestMethod]
        public void DeleteProductCategoryPass()
        {
            ProductCategoryController controller = new ProductCategoryController();

            var insCat = new ProductCategory
            {
                Name = "Test Category",
                Code = "Test"
            };

            var catID = controller.SaveRecord(insCat);
            var newCat = controller.GetProductCategoryById(catID);
            controller.DeleteRecord(newCat);
            var deadCat = controller.GetProductCategoryById(newCat.ProductCategoryId);

            Assert.IsNotNull(controller);
            Assert.AreEqual(3, catID);
            Assert.IsNotNull(newCat);
            Assert.IsNull(deadCat);
        }

        [TestMethod]
        public void DeleteProductCategoryFail()
        {
            ProductCategoryController controller = new ProductCategoryController();
            var cat = controller.GetProductCategoryById(1);
            cat.ProductCategoryId = 100;
            controller.DeleteRecord(cat);
            var res = controller.GetAllProductCategories();

            Assert.IsNotNull(controller);
            Assert.IsNotNull(cat);
            Assert.AreEqual(2,res.Count);
        }

        [TestMethod]
        public void InsertProductCategoryPass()
        {
            ProductCategoryController controller = new ProductCategoryController();
            var insCat = new ProductCategory
                {
                    Name = "Test Category",
                    Code = "Test"
                };

            var catID = controller.SaveRecord(insCat);
            var cat = controller.GetProductCategoryById(catID);

            Assert.IsNotNull(controller);
            Assert.IsTrue(catID > 0);
            Assert.AreEqual(cat.ProductCategoryId, catID);
            Assert.AreEqual(cat.Name, insCat.Name);
            Assert.AreEqual(cat.Code, insCat.Code);
        }

        [TestMethod]
        public void InsertProductCategoryFail()
        {
            ProductCategoryController controller = new ProductCategoryController();
            var insCat = new ProductCategory
            {
                Name = "Maintenance",
                Code = "MANT"
            };

            var catID = controller.SaveRecord(insCat);

            Assert.IsNotNull(controller);
            Assert.AreEqual(3, catID);
        }

        [TestMethod]
        public void UpdateProductCategoryPass()
        {
            ProductCategoryController controller = new ProductCategoryController();
            var cat = controller.GetProductCategoryById(1);
            cat.Name = "Mater";
            var catID = controller.SaveRecord(cat);
            var res = controller.GetProductCategoryById(1);

            Assert.IsNotNull(controller);
            Assert.AreEqual(cat.ProductCategoryId, res.ProductCategoryId);
            Assert.AreEqual(cat.Name, res.Name);
        }

        [TestMethod]
        public void UpdateProductCategoryFail()
        {
            ProductCategoryController controller = new ProductCategoryController();
            var cat = controller.GetProductCategoryById(1);
            cat.Name = "Inspection";
            cat.Code = "INSP";
            var catID = controller.SaveRecord(cat);
            var res = controller.GetProductCategoryById(1);

            Assert.IsNotNull(controller);
            Assert.AreEqual(cat.ProductCategoryId, res.ProductCategoryId);
            Assert.AreEqual(cat.Name, res.Name);
        }
    }
}
