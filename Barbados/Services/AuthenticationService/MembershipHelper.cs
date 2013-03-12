using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Enterprise.Services.Authentication
{
    using Enterprise.Services.Authentication.Models;

    /// <summary>
    /// 
    /// </summary>
    public class MembershipHelper : IMembershipHelper
    {
        /// <summary>
        /// Gets or sets the auto unlock timeout.
        /// </summary>
        /// <value>
        /// The auto unlock timeout.
        /// </value>
        protected TimeSpan AutoUnlockTimeout { get; set; }
        /// <summary>
        /// Gets the encryption algorithm.
        /// </summary>
        /// <value>
        /// The encryption algorithm.
        /// </value>
        protected String EncryptionAlgorithm { get { return "SHA"; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipHelper" /> class.
        /// </summary>
        /// <param name="autoUnlockTimeout">The auto unlock timeout.</param>
        public MembershipHelper(TimeSpan autoUnlockTimeout)
        {
            AutoUnlockTimeout = autoUnlockTimeout;
        }

        #region Public Methods

        /// <summary>
        /// This is how the base SqlMembershipProvider class encodes its passwords, used for comparison with new passwords
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="hashingAlgorithm"></param>
        /// <returns></returns>
        public string EncodePassword(string password, string salt, string hashingAlgorithm)
        {
            byte[] bIn = Encoding.Unicode.GetBytes(password);
            byte[] bSalt = Convert.FromBase64String(salt);
            byte[] bRet = null;

            var hm = HashAlgorithm.Create(hashingAlgorithm);
            if (hm is KeyedHashAlgorithm)
            {
                KeyedHashAlgorithm kha = (KeyedHashAlgorithm)hm;
                if (kha.Key.Length == bSalt.Length)
                {
                    kha.Key = bSalt;
                }
                else if (kha.Key.Length < bSalt.Length)
                {
                    byte[] bKey = new byte[kha.Key.Length];
                    Buffer.BlockCopy(bSalt, 0, bKey, 0, bKey.Length);
                    kha.Key = bKey;
                }
                else
                {
                    byte[] bKey = new byte[kha.Key.Length];
                    for (int iter = 0; iter < bKey.Length; )
                    {
                        int len = Math.Min(bSalt.Length, bKey.Length - iter);
                        Buffer.BlockCopy(bSalt, 0, bKey, iter, len);
                        iter += len;
                    }
                    kha.Key = bKey;
                }
                bRet = kha.ComputeHash(bIn);
            }
            else
            {
                byte[] bAll = new byte[bSalt.Length + bIn.Length];
                Buffer.BlockCopy(bSalt, 0, bAll, 0, bSalt.Length);
                Buffer.BlockCopy(bIn, 0, bAll, bSalt.Length, bIn.Length);
                bRet = hm.ComputeHash(bAll);
            }


            return Convert.ToBase64String(bRet);

        }

        /// <summary>
        /// Performs a check to see if the user attempting to login needs to have their account unlocked based on our predefined <see cref="AuthenticationService.MsiMembershipProvider.AutoUnlockTimeout" />
        /// </summary>
        /// <param name="user">Membership record of the user.</param>
        /// <returns>
        /// Whether the user was successfully unlocked, can also indicate the user did not need unlocking
        /// </returns>
        public bool TryAutoUnlockUser(MembershipUser user)
        {
            //check if the user is locked out and if the lockout date is in excess of the auto-unlock timeout
            if (UserIsEligibleForUnlock(user))
            {
                return user.UnlockUser();
            }
            else
            {
                //default case, user does not require unlocking
                return false;
            }
        }

        /// <summary>
        /// Performs check to ensure that the user attempting to login does not need to reset their password
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="System.Configuration.Provider.ProviderException">Invalid username provided.</exception>
        public void EnforceValidateUserPreconditions(MembershipUser user)
        {
            //invalid user
            if (user == null)
            {
                throw new ProviderException("Invalid username provided.");
            }

            //account is locked and not eligible for auto unlock
            if (user.IsLockedOut && !UserIsEligibleForUnlock(user))
            {
                throw new ProviderException(String.Format("User account is locked. Please wait {0} minutes and try again.", TimeUntilUnlock(user)));
            }

            //account is not approved
            if (!user.IsApproved)
            {
                throw new ProviderException("User account is not approved. Please contact support.");
            }
        }

        /// <summary>
        /// Checks to see whether a given password has been used before.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newPassword">The new password.</param>
        /// <param name="numPasswordsToEnforce"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool PasswordHasBeenUsedRecently(string username, string newPassword, int numPasswordsToEnforce)
        {
            var conn = GetOpenConnection();

            var cmd = BuildStoredProcedureCommand(conn, "dbo.PasswordHistory_SelectRecentByUsername",
                                                new SqlParameter("userName", username),
                                                new SqlParameter("numberOfRecentPasswordsToRetrieve",
                                                                 numPasswordsToEnforce));

            var reader = cmd.ExecuteReader();
            var history = new List<PasswordHistory>();
            while (reader.Read())
            {

                var oldPassword = reader["Password"].ToString();
                var oldSalt = reader["PasswordSalt"].ToString();
                history.Add(new PasswordHistory(oldPassword, oldSalt));
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            foreach (var record in history)
            {
                var encodedPassword = EncodePassword(newPassword, record.PasswordSalt, EncryptionAlgorithm);

                if (history.Any(h => h.Password == encodedPassword)) { return true; }
            }

            return false;
        }


        /// <summary>
        /// Calculates the amount of time until the user's account will be auto-unlocked
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public int TimeUntilUnlock(MembershipUser user)
        {
            var result = user.LastLockoutDate.ToUniversalTime().Add(AutoUnlockTimeout).Subtract(DateTime.UtcNow).Minutes;

            return result == 0 ? 1 : result;
        }

        /// <summary>
        /// Checks whether the membership record is eligible for the auto unlock functionality
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>
        /// Whether the membership record is eligible for unlocking
        /// </returns>
        public bool UserIsEligibleForUnlock(MembershipUser user)
        {
            if (user != null
                    && user.IsLockedOut
                    && user.LastLockoutDate.ToUniversalTime().Add(AutoUnlockTimeout) < DateTime.UtcNow)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Logs the login attempt.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="wasSuccessful">if set to <c>true</c> [was successful].</param>
        public void LogLoginAttempt(string username, bool wasSuccessful)
        {
            var conn = GetOpenConnection();

            var appName =
                new SqlConnectionStringBuilder(
                    System.Configuration.ConfigurationManager.ConnectionStrings["MembershipDB"].ConnectionString).ApplicationName;

            var cmd = BuildStoredProcedureCommand(conn, "dbo.LoginAttemptHistory_Insert",
                                                  new SqlParameter("userName", username),
                                                  new SqlParameter("wasSuccessful", wasSuccessful),
                                                  new SqlParameter("appName", appName));

            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Builds the stored procedure command.
        /// </summary>
        /// <param name="conn">The conn.</param>
        /// <param name="procedureName">Name of the procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        private SqlCommand BuildStoredProcedureCommand(SqlConnection conn, string procedureName, params SqlParameter[] parameters)
        {
            var cmd = new SqlCommand(procedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddRange(parameters);

            return cmd;
        }

        /// <summary>
        /// Gets the open connection.
        /// </summary>
        /// <returns></returns>
        private SqlConnection GetOpenConnection()
        {
            var conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MembershipDB"].ConnectionString);
            conn.Open();
            return conn;
        } 
        #endregion
    }
}
