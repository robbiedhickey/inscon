using System;
using System.Diagnostics;
using AuthenticationService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClientDashboard.Tests
{
    [TestClass]
    public class MembershipHelperTests
    {
        [TestMethod]
        public void EncodePassword_Should()
        {
            var helper = new MembershipHelper(new TimeSpan(0, 0, 15, 0));
            var algorithm = "SHA1"; //"HMACSHA256";

            var encodedPassword = "vIeee2b8yRNknast8mbYH9VhgKU="; //P@ssword encoded

            var pass1 = "P@ssword";
            var salt1 = "DPUBXoloFTLCKikqBmQEoQ==";

            var test1 = helper.EncodePassword(pass1, salt1, algorithm);

            Debug.WriteLine(test1);

            Assert.IsTrue(encodedPassword == test1);
        }
    }
}
