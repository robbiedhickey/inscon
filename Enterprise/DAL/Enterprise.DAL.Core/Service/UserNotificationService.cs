using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
namespace Enterprise.DAL.Core.Service
{
    public class UserNotificationService : ServiceBase<UserNotification>
    {

        /// <summary>
        /// Get all UserNotification records
        /// </summary>
        /// <returns></returns>
        public List<UserNotification> GetAllUserNotifications()
        {
            return QueryAll(SqlDatabase, Procedure.UserNotification_SelectAll, UserNotification.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get UserNotification record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserNotification GetUserNotificationById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<UserNotification> h = h2 => h2.UserNotificationId == id;
                return GetAllUserNotifications().Find(h) ?? new UserNotification();
            }

            return Query(SqlDatabase, Procedure.UserNotification_SelectById, UserNotification.Build, id);
        }

        /// <summary>
        /// Get a list of User Notifications by UserDD
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<UserNotification> GetUserNotificationsByUserId(Int32 userId)
        {
            if (IsCached)
            {
                Predicate<UserNotification> h = h2 => h2.UserId == userId;
                return GetAllUserNotifications().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.UserNotification_SelectByUserId, UserNotification.Build, userId);
        }
    }
}
