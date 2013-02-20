using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using Enterprise.ApiServices.DALServices.Controllers;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for FileControllerTest
    /// </summary>
    /// 
    /// CRUD fails because reflection assumes ID postfix and we use Id
    [TestClass]
    public class FileControllerTest
    {
        private readonly FileController _controller;

        public FileControllerTest()
        {
            _controller = new FileController();
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
        public void GetAllFiles()
        {
            var actual = _controller.GetAllFiles();

            Assert.AreEqual(9, actual.Count);
        }

        [TestMethod]
        public void GetFileByIdPass()
        {
            var actual = _controller.GetFileById(1);

            Assert.IsNotNull(actual);
            Assert.AreEqual(1, actual.FileID);
            Assert.AreEqual(24, actual.EntityID);
            Assert.AreEqual(1, actual.ParentID);
            Assert.AreEqual(150.50M, actual.Size);
            Assert.AreEqual(@"\\Resources\2012\12\01", actual.ParentFolder);
            Assert.AreEqual(@"picture01.jpg", actual.Name);
        }

        [TestMethod]
        public void GetFileByIdFail()
        {
            var actual = _controller.GetFileById(100);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void GetFileByParentIdAndEntityIDPass()
        {
            var actual = _controller.GetFileByParentIdAndEntityID(2, 24);

            Assert.IsNotNull(actual);
            Assert.AreEqual(2, actual.FileID);
            Assert.AreEqual(24, actual.EntityID);
            Assert.AreEqual(2, actual.ParentID);
            Assert.AreEqual(150.50M, actual.Size);
            Assert.AreEqual(@"\\Resources\2012\12\01", actual.ParentFolder);
            Assert.AreEqual(@"picture02.jpg", actual.Name);
        }

        [TestMethod]
        public void GetFileByParentIdAndEntityIDFail()
        {
            var actual = _controller.GetFileByParentIdAndEntityID(1, 20);//invalid entityId
            var actual1 = _controller.GetFileByParentIdAndEntityID(100, 24);//invalid parentId

            Assert.IsNull(actual);
            Assert.IsNull(actual1);
        }

        [TestMethod]
        public void DeleteFilePass()
        {
            var fileToDelete = new File { FileID = 1 };
            _controller.DeleteRecord(fileToDelete);
            var recordAfterDelete = _controller.GetFileById(1);
            Assert.IsNull(recordAfterDelete);
        }

        [TestMethod]
        public void DeleteFileFail()
        {
            var fileToDelete = new File() { FileID = 100 }; //file does not exist

            _controller.DeleteRecord(fileToDelete);
            var recordAfterDelete = _controller.GetFileById(100);
            Assert.IsNull(recordAfterDelete);
        }


        [TestMethod]
        public void InsertFilePass()
        {
            var fileToInsert = new File
            {
                Caption = "asdf",
                EntityID = 24,
                Name = "picture.jpeg",
                ParentFolder = @"C:\Files",
                Size = 10M,
                TypeID = 35,
            };

            var result = _controller.SaveRecord(fileToInsert);

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void InsertFileFail()
        {
            var fileToInsert = new File
            {
                EntityID = 5,
                TypeID = 1,
            };

            var result = _controller.SaveRecord(fileToInsert);
        }

        [TestMethod]
        public void UpdateFilePass()
        {
            var before = _controller.GetFileById(1);

            before.EntityID = 30;

            _controller.SaveRecord(before);

            var after = _controller.GetFileById(1);

            Assert.AreEqual(30, after.EntityID);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void UpdateFileFail()
        {
            var before = _controller.GetFileById(1);

            before.ParentFolder = null;
            before.Name = null;

            var after = _controller.SaveRecord(before);
        }
    }
}
