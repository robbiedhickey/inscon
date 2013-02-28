using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.DAL.Test
{
    using Enterprise.DAL.Models;
    using Enterprise.DAL.Repositories;

    /// <summary>
    /// Summary description for OrganizationRepositoryTest
    /// </summary>
    [TestClass]
    public class OrganizationRepositoryTest
    {
        private EnterpriseDbContext context;

        public OrganizationRepositoryTest()
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
            var target = new OrganizationRepository(context);

            var orgs = target.Get();

            Assert.IsNotNull(target);
            Assert.AreEqual(3, orgs.Count);
        }

        [TestMethod]
        public void GetByType()
        {
            var target = new OrganizationRepository(context);

            var orgs = target.Get(3);

            Assert.IsNotNull(target);
            Assert.AreEqual(3, orgs.Count);
        }

        [TestMethod]
        public void GetByID()
        {
            var target = new OrganizationRepository(context);

            var org = target.GetByID(1);

            Assert.IsNotNull(target);
            Assert.AreEqual("Bank of the Outer Galactic Empire", org.Name);
        }

        [TestMethod]
        public void Insert()
        {
            var target = new OrganizationRepository(context);

            Organization org = new Organization()
                                   {
                                       Name = "Test Organization",
                                       Code = "TEST",
                                       TypeID = 3,
                                       StatusID = 1
                                   };

            target.Insert(org);
            target.Save();

            Assert.IsNotNull(target);
            Assert.AreEqual(4, org.OrganizationID);
        }

        [TestMethod]
        public void Update()
        {
            var target = new OrganizationRepository(context);
            var org = target.GetByID(1);
            org.Code = "XXXX";
            target.Update(org);
            target.Save();
            var uOrg = target.GetByID(1);

            Assert.IsNotNull(target);
            Assert.AreEqual("XXXX", uOrg.Code);
        }

        [TestMethod]
        public void Delete()
        {
            var target = new OrganizationRepository(context);
            Organization org = new Organization()
            {
                Name = "Test Organization",
                Code = "TEST",
                TypeID = 3,
                StatusID = 1
            };

            target.Insert(org);
            target.Save();
            target.Delete(org.OrganizationID);
            target.Save();
            var deadOrg = target.GetByID(org.OrganizationID);

            Assert.IsNotNull(target);
            Assert.IsNull(deadOrg);
        }

        [TestMethod]
        public void Save()
        {
            var target = new OrganizationRepository(context);

            Organization org = new Organization()
            {
                Name = "Test Organization",
                Code = "TEST",
                TypeID = 3,
                StatusID = 1
            };

            target.Insert(org);
            target.Save();

            Assert.IsNotNull(target);
            Assert.AreEqual(4, org.OrganizationID);
        }

        //[TestMethod]
        //public void GetUsers()
        //{
        //    var target = new OrganizationRepository(context);

        //    var org = target.GetByID(1);

        //    Assert.IsNotNull(target);
        //}
    }
}
