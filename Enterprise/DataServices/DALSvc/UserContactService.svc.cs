using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.UserContactService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class UserContactService : IUserContactService
    {
        public List<UserContact> GetAllUserContacts()
        {
            throw new NotImplementedException();
        }

        public UserContact GetUserContactById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserContact> GetUserContactsByUserId(int userID)
        {
            throw new NotImplementedException();
        }

        public List<UserContact> GetUserContactsByUserIdAndTypeId(int userID, int typeId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(UserContact userContact)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(UserContact userContact)
        {
            throw new NotImplementedException();
        }
    }
}
