using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.UserService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            return new dbSvc().GetAllUsers();
        }

        public User GetUserById(int idUser)
        {
            return new dbSvc().GetUserById(idUser);
        }

        public List<User> GetUsersByOrganizationId(int idOrganization)
        {
            return new dbSvc().GetUsersByOrganizationId(idOrganization);
        }

        public List<User> GetUsersByOrganizationIdAndIsActive(int idOrganization, int idStatus)
        {
            return new dbSvc().GetUsersByOrganizationIdAndIsActive(idOrganization, idStatus);
        }

        public bool DeleteRecord(User user)
        {
            return new dbSvc().DeleteRecord(user);
        }

        public int SaveRecord(User user)
        {
            return new dbSvc().SaveRecord(user);
        }
    }
}