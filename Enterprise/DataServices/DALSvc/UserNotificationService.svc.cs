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
    public class UserNotificationService : IUserNotificationService
    {
        public List<UserNotification> GetAllUserNotifications()
        {
            throw new NotImplementedException();
        }

        public UserNotification GetUserNotificationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserNotification> GetUserNotificationsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(UserNotification userNotification)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(UserNotification userNotification)
        {
            throw new NotImplementedException();
        }
    }
}
