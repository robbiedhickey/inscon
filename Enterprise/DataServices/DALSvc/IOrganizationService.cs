using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IOrganizationService
    {
        [OperationContract]
        List<Organization> GetAllOrganizations();

        [OperationContract]
        Organization GetOrganizationById(int id);

        [OperationContract]
        List<Organization> GetOrganizationsByTypeId(int? typeID);

        [OperationContract]
        void DeleteRecord(Organization organization);

        [OperationContract]
        int SaveRecord(Organization organization);
    }
}
