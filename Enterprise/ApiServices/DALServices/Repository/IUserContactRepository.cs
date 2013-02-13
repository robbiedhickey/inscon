using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IUserContactRepository
    {
        List<UserContact> GetAllUserContacts();
        UserContact GetUserContactById(Int32 id);
        List<UserContact> GetUserContactsByUserId(Int32 userId);
        List<UserContact> GetUserContactsByUserIdAndTypeId(Int32 userId, Int32 typeId);
        void DeleteRecord(UserContact userContact);
        int SaveRecord(UserContact userContact);
    }
}
