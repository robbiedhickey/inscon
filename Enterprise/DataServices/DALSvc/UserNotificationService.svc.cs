using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.UserNotificationService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the UserNotificaton table.
    /// </summary>
    public class UserNotificationService : IUserNotificationService
    {
        /// <summary>
        /// Gets all user notifications.
        /// </summary>
        /// <returns>A list of UserNotification objects.</returns>
        public List<UserNotification> GetAllUserNotifications()
        {
            try
            {
                return new dbSvc().GetAllUserNotifications();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user notification by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The UserNotification object that matches the id.</returns>
        public UserNotification GetUserNotificationById(int id)
        {
            try
            {
                return new dbSvc().GetUserNotificationById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user notifications by user id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>A list of UserNotification objects that match the user id.</returns>
        public List<UserNotification> GetUserNotificationsByUserId(int userId)
        {
            try
            {
                return new dbSvc().GetUserNotificationsByUserId(userId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the UserNotification record.
        /// </summary>
        /// <param name="userNotification">The user notification to delete.</param>
        public void DeleteRecord(UserNotification userNotification)
        {
            try
            {
                new dbSvc().DeleteRecord(userNotification);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the UserNotification record.
        /// </summary>
        /// <param name="userNotification">The user notification to save.</param>
        /// <returns>The id of the saved UserNotification.</returns>
        public int SaveRecord(UserNotification userNotification)
        {
            try
            {
                return new dbSvc().SaveRecord(userNotification);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
