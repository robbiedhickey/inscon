using System;
using System.Diagnostics;
using AuthenticationService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClientDashboard.Tests
{
    [TestClass]
    public class MembershipHelperTests
    {
        private readonly MembershipHelper _helper;

        public MembershipHelperTests()
        {
            _helper = new MembershipHelper(new TimeSpan(0,0,15,0));
        }

        [TestMethod]
        public void EncodePassword_ShouldHashIdenticalPasswordsInSameFashion()
        {
            var algorithm = "SHA1"; //"HMACSHA256";

            var encodedPassword = "vIeee2b8yRNknast8mbYH9VhgKU="; //P@ssword encoded

            var pass1 = "P@ssword";
            var salt1 = "DPUBXoloFTLCKikqBmQEoQ==";

            var newlyHashedPassword = _helper.EncodePassword(pass1, salt1, algorithm);

            Debug.WriteLine(newlyHashedPassword);

            Assert.IsTrue(encodedPassword == newlyHashedPassword);
        }

        [TestMethod]
        public void RecentPasswords_ShouldDetectPreviouslyUsed()
        {
            var result = _helper.PasswordHasBeenUsedRecently("robert.hickey", "P@ssword", 40); //used
            var result2 = _helper.PasswordHasBeenUsedRecently("robert.hickey", "P@ssword1", 40); //used
            var result3 = _helper.PasswordHasBeenUsedRecently("robert.hickey", "131lkjdkjkj1", 40); //never used

            Assert.IsTrue(result);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
        }
    }
}
