using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace="http://msi.enterprise.dataservices.dalsvc")]
    public interface IWorkOrderService
    {
        [OperationContract]
        List<WorkOrder> GetAllWorkOrders();

        [OperationContract]
        WorkOrder GetWorkOrderById(Int32 id);

        [OperationContract]
        List<WorkOrder> GetWorkOrdersByRequestId(Int32 requestId);

        [OperationContract]
        List<WorkOrder> GetWorkOrdersByAssetId(Int32 assetId);

        [OperationContract]
        void DeleteRecord(WorkOrder workOrder);

        [OperationContract]
        int SaveRecord(WorkOrder workOrder);
    }
}
