using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface ILookupService
    {
        [OperationContract]
        List<Lookup> GetAllLookups();

        [OperationContract]
        Lookup GetLookupById(Int32 id);

        [OperationContract]
        List<Lookup> GetLookupValuesByGroupId(Int16 groupID);

        [OperationContract]
        void DeleteRecord(Lookup lookup);

        [OperationContract]
        int SaveRecord(Lookup lookup);
    }
}
