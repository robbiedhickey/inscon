using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IUserNotificationService
    {
        [OperationContract]
        List<UserNotification> GetAllUserNotifications();

        [OperationContract]
        UserNotification GetUserNotificationById(Int32 id);

        [OperationContract]
        List<UserNotification> GetUserNotificationsByUserId(Int32 userId);

        [OperationContract]
        void DeleteRecord(UserNotification userNotification);

        [OperationContract]
        int SaveRecord(UserNotification userNotification);
    }
}
