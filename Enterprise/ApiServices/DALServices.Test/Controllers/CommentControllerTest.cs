using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for CommentControllerTest
    /// </summary>
    [TestClass]
    public class CommentControllerTest
    {
        public CommentControllerTest()
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
        public void GetAllComments()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetCommentByIdPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetCommentByIdFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetCommentByParentIdAndEntityIDPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetCommentByParentIdAndEntityIDFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteCommentPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DeleteCommentFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertCommentPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void InsertCommentFail()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateCommentPass()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void UpdateCommentFail()
        {
            Assert.Inconclusive();
        }
    }
}
