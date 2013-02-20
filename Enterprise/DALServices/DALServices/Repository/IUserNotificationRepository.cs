using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IUserNotificationRepository
    {
        List<UserNotification> GetAllUserNotifications();
        UserNotification GetUserNotificationById(Int32 id);
        List<UserNotification> GetUserNotificationsByUserId(Int32 userId);
        bool DeleteRecord(UserNotification userNotification);
        int SaveRecord(UserNotification userNotification);
    }
}
