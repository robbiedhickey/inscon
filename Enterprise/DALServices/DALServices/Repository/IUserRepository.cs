using Enterprise.DAL.Core.Model;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int idUser);
        List<User> GetUsersByOrganizationId(int idOrganization);
        List<User> GetUsersByOrganizationIdAndIsActive(int idOrganization, int idStatus);
        bool DeleteRecord(User user);
        int SaveRecord(User user);
    }
}
