using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface ILookupGroupService
    {
        [OperationContract]
        List<LookupGroup> GetAllLookupGroups();

        [OperationContract]
        LookupGroup GetLookupGroupById(int id);

        [OperationContract]
        void DeleteRecord(LookupGroup lookupGroup);

        [OperationContract]
        int SaveRecord(LookupGroup lookupGroup);
    }
}
