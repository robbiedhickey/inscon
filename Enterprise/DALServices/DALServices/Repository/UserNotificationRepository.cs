using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.UserNotificationService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class UserNotificationRepository : IUserNotificationRepository
    {
        public List<UserNotification> GetAllUserNotifications()
        {
            return new dbSvc().GetAllUserNotifications();
        }

        public UserNotification GetUserNotificationById(int id)
        {
            return new dbSvc().GetUserNotificationById(id);
        }

        public List<UserNotification> GetUserNotificationsByUserId(int userId)
        {
            return new dbSvc().GetUserNotificationsByUserId(userId);
        }

        public bool DeleteRecord(UserNotification userNotification)
        {
            return new dbSvc().DeleteRecord(userNotification);
        }

        public int SaveRecord(UserNotification userNotification)
        {
            return new dbSvc().SaveRecord(userNotification);
        }
    }
}