using System;
using System.Text;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise.ApiServices.DALServices.Controllers;
using System.Data.SqlClient;

namespace Enterprise.ApiServices.DALServices.Test.Controllers
{
    /// <summary>
    /// Summary description for OrganizationControllerTest
    /// </summary>
    [TestClass]
    public class OrganizationControllerTest
    {
        public OrganizationControllerTest()
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
        public void GetAllOrganizations()
        {
            OrganizationController controller = new OrganizationController();
            var actual = controller.GetAllOrganizations();

            Assert.IsNotNull(actual);
            Assert.AreEqual(3, actual.Count);
        }

        [TestMethod]
        public void GetOrganizationByIdPass()
        {
            OrganizationController controller = new OrganizationController();
            var actual = controller.GetOrganizationById(1);

            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.Name, "Bank of the Outer Galactic Empire");
            Assert.AreEqual(actual.Code, "BOGE");
            Assert.AreEqual(actual.TypeID, 3);
            Assert.AreEqual(actual.StatusID, 1);
        }

        [TestMethod]
        public void GetOrganizationByIdFail()
        {
            OrganizationController controller = new OrganizationController();
            var actual = controller.GetOrganizationById(5);

            Assert.IsNotNull(actual);
            Assert.IsNull(actual.Name);
            Assert.IsNull(actual.Code);
            Assert.AreEqual(actual.TypeID, 0);
            Assert.AreEqual(actual.StatusID, 0);
        }

        [TestMethod]
        public void GetOrganizationByTypeIdPass()
        {
            OrganizationController controller = new OrganizationController();
            var actual = controller.GetOrganizationsByTypeId(3);

            Assert.IsNotNull(actual);
            Assert.AreEqual(3, actual.Count);
        }

        [TestMethod]
        public void GetOrganizationByTypeIdFail()
        {
            OrganizationController controller = new OrganizationController();
            var actual = controller.GetOrganizationsByTypeId(5);

            Assert.IsNotNull(actual);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void DeleteOrganizationPass()
        {
            OrganizationController controller = new OrganizationController();
            Organization org = new Organization
            {
                OrganizationID = 0,
                Name = "Test Organization",
                Code = "TORG",
                TypeID = 3,
                StatusID = 1
            };

            var actual = controller.SaveRecord(org);
            var newOrg = controller.GetOrganizationById(actual);
            bool ret = controller.DeleteRecord(newOrg);

            Assert.IsNotNull(controller);
            Assert.AreEqual(4, actual);
            Assert.IsNotNull(newOrg);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void DeleteOrganizationFail()
        {
            OrganizationController controller = new OrganizationController();
            Organization org = new Organization
                {
                    OrganizationID = 5,
                    Name = "Test Org",
                    Code = "x",
                    TypeID = 3,
                    StatusID = 1
                };

            var res = controller.DeleteRecord(org);

            Assert.IsNotNull(controller);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void InsertOrganizationPass()
        {
            OrganizationController controller = new OrganizationController();

            Organization org = new Organization
            {
                OrganizationID = 0,
                Name = "Test Organization",
                Code = "TORG",
                TypeID = 3,
                StatusID = 1
            };
            
            var actual = controller.SaveRecord(org);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void InsertOrganizationFail()
        {
            OrganizationController controller = new OrganizationController();

            Organization org = new Organization
            {
                OrganizationID = 0,
                Name = "Bank of the Outer Galactic Empire",
                Code = "BOGE",
                TypeID = 3,
                StatusID = 1
            };

            var actual = controller.SaveRecord(org);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void UpdateOrganizationPass()
        {
            OrganizationController controller = new OrganizationController();
            var org = controller.GetOrganizationById(1);
            org.Name = "UpdateOrganizationPass";
            var actual = controller.SaveRecord(org);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void UpdateOrganizationFailCodeTooLong()
        {
            OrganizationController controller = new OrganizationController();
            var org = controller.GetOrganizationById(1);
            org.Code = "UpdateOrganizationPass";
            var actual = controller.SaveRecord(org);
            var result = controller.GetOrganizationById(1);

            Assert.IsNotNull(actual);
            Assert.AreNotEqual("UpdateOrganizationPass", result.Code);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void UpdateOrganizationFailDuplicateNameOrCode()
        {
            OrganizationController controller = new OrganizationController();
            var org = controller.GetOrganizationById(1);
            org.Name= "Oort Clout Savings and Loan";
            org.Code = "OCSL";
            var actual = controller.SaveRecord(org);
            var result = controller.GetOrganizationById(1);

            Assert.IsNotNull(actual);
            Assert.AreEqual("Oort Clout Savings and Loan", result.Name);
            Assert.AreEqual("OCSL", result.Code);
        }
    }
}
