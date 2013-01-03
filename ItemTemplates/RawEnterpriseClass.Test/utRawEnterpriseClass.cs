using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RawEnterpriseClass;
using Microsoft.Practices.EnterpriseLibrary.Validation;

namespace RawEnterpriseClass.Test
{
    /// <summary>
    /// Summary description for utRawEnterpriseClass
    /// </summary>
    [TestClass]
    public class utRawEnterpriseClass
    {
        private EnterpriseClass testObj;

        public utRawEnterpriseClass()
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
        
        // Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            testObj = new EnterpriseClass();
        }
        
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ConstructorTest()
        {
            EnterpriseClass target = new EnterpriseClass();
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void IsValidTestPassed()
        {
            testObj.ID = 1;
            Assert.IsTrue(testObj.IsValid());
        }

        [TestMethod]
        public void IsValidTestFailedBadID()
        {
            Assert.IsFalse(testObj.IsValid());
        }

        [TestMethod]
        public void IsValidTestFailedBadinTxn()
        {
            testObj.BeginEdit();
            Assert.IsFalse(testObj.IsValid());
        }

        [TestMethod]
        public void ValidationErrors()
        {
            testObj.BeginEdit();
            ValidationResults validationResults = testObj.Validate();
            Assert.AreEqual(validationResults.Count, 2);
        }

        [TestMethod]
        public void DidPropertyChangeID()
        {
            var tester = new NotifyPropertyChangedTester(testObj);
            testObj.ID = 3;

            Assert.AreEqual(3, testObj.ID, "Value did not change.");

            Assert.AreEqual(1,tester.Changes.Count,"Change count was wrong.");
            tester.AssertChange(0, "ID");
        }
    }
}
