using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace AuthenticationService
{
    public class MsiMembershipProvider : SqlMembershipProvider
    {
        #region Property Configuration Overrides
        public override bool EnablePasswordRetrieval
        {
            get
            {
                return false;
            }
        }

        public override bool EnablePasswordReset
        {
            get
            {
                return true;
            }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get
            {
                return true;
            }
        }

        public override bool RequiresUniqueEmail
        {
            get
            {
                return false;
            }
        }

        public override int MaxInvalidPasswordAttempts
        {
            get
            {
                return 3;
            }
        }

        public override int PasswordAttemptWindow
        {
            get
            {
                return 5;
            }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get
            {
                return 1;
            }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get
            {
                return MembershipPasswordFormat.Hashed;
            }
        }

        public override int MinRequiredPasswordLength
        {
            get
            {
                return 7;
            }
        }
        #endregion

        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            //Here we can manipulate and override config values

            //We can provide default values in this class for configuration or grab it from the database

            base.Initialize(name, config);
        }
    }
}
