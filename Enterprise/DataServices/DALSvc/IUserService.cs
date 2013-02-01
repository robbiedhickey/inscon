using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IUserService
    {
        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        User GetUserById(int idUser);

        [OperationContract]
        List<User> GetUsersByOrganizationId(int idOrganization);

        [OperationContract]
        List<User> GetUsersByOrganizationIdAndIsActive(int idOrganization, int idStatus);

        [OperationContract]
        void DeleteRecord(User user);

        [OperationContract]
        int SaveRecord(User user);
    }
}
