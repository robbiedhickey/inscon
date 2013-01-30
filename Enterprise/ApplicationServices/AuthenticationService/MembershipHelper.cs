using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace AuthenticationService
{
    public class MembershipHelper : IMembershipHelper
    {
        protected TimeSpan AutoUnlockTimeout { get; set; }

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
        /// Performs any necessary checks to ensure that the user is eligible to change their password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool EnforceChangePasswordPreconditions(MembershipUser user, string newPassword)
        {

            if (PasswordHasBeenUsedBefore(user, newPassword))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks to see whether a given password has been used before.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="newPassword">The new password.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool PasswordHasBeenUsedBefore(MembershipUser user, string newPassword)
        {
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
        #endregion
    }
}
