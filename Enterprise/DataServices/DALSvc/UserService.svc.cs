using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.UserService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int idUser)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersByOrganizationId(int idOrganization)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersByOrganizationIdAndIsActive(int idOrganization, int idStatus)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(User user)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(User user)
        {
            throw new NotImplementedException();
        }
    }
}
