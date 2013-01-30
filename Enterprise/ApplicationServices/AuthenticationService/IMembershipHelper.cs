using System.Web.Security;

namespace AuthenticationService
{
    public interface IMembershipHelper
    {
        /// <summary>
        /// This is how the base class encodes its passwords, used for comparison with new passwords
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="hashingAlgorithm"></param>
        /// <returns></returns>
        string EncodePassword(string password, string salt, string hashingAlgorithm);

        /// <summary>
        /// Performs a check to see if the user attempting to login needs to have their account unlocked based on our predefined <see cref="AuthenticationService.MsiMembershipProvider.AutoUnlockTimeout" />
        /// </summary>
        /// <param name="user">Membership record of the user.</param>
        /// <returns>
        /// Whether the user was successfully unlocked, can also indicate the user did not need unlocking
        /// </returns>
        bool TryAutoUnlockUser(MembershipUser user);

        /// <summary>
        /// Performs check to ensure that the user attempting to login does not need to reset their password
        /// </summary>
        /// <param name="user"></param>
        void EnforceValidateUserPreconditions(MembershipUser user);

        /// <summary>
        /// Checks to see whether a given password has been used before.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="newPassword">The new password.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        bool PasswordHasBeenUsedRecently(string username, string newPassword, int numPasswordsToEnforce);

        /// <summary>
        /// Calculates the amount of time until the user's account will be auto-unlocked
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        int TimeUntilUnlock(MembershipUser user);

        /// <summary>
        /// Checks whether the membership record is eligible for the auto unlock functionality
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>
        /// Whether the membership record is eligible for unlocking
        /// </returns>
        bool UserIsEligibleForUnlock(MembershipUser user);

        /// <summary>
        /// Logs the login attempt.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="wasSuccessful">if set to <c>true</c> [was successful].</param>
        void LogLoginAttempt(string username, bool wasSuccessful);
    }
}