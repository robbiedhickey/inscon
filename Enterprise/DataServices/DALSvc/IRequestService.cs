using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IRequestService
    {
        [OperationContract]
        List<Request> GetAllRequests();

        [OperationContract]
        Request GetRequestById(Int32 id);

        [OperationContract]
        void DeleteRecord(Request request);

        [OperationContract]
        int SaveRecord(Request request);
    }
}
