using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IUserContactService
    {
        [OperationContract]
        List<UserContact> GetAllUserContacts();

        [OperationContract]
        UserContact GetUserContactById(Int32 id);

        [OperationContract]
        List<UserContact> GetUserContactsByUserId(Int32 userID);

        [OperationContract]
        List<UserContact> GetUserContactsByUserIdAndTypeId(Int32 userID, Int32 typeId);

        [OperationContract]
        void DeleteRecord(UserContact userContact);

        [OperationContract]
        int SaveRecord(UserContact userContact);
    }
}
