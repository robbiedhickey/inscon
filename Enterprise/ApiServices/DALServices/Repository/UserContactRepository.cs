using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.UserContactService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class UserContactRepository : IUserContactRepository
    {
        public List<UserContact> GetAllUserContacts()
        {
            return new dbSvc().GetAllUserContacts();
        }

        public UserContact GetUserContactById(int id)
        {
            return new dbSvc().GetUserContactById(id);
        }

        public List<UserContact> GetUserContactsByUserId(int userId)
        {
            return new dbSvc().GetUserContactsByUserId(userId);
        }

        public List<UserContact> GetUserContactsByUserIdAndTypeId(int userId, int typeId)
        {
            return new dbSvc().GetUserContactsByUserIdAndTypeId(userId, typeId);
        }

        public void DeleteRecord(UserContact userContact)
        {
            new dbSvc().DeleteRecord(userContact);
        }

        public int SaveRecord(UserContact userContact)
        {
            return new dbSvc().SaveRecord(userContact);
        }
    }
}