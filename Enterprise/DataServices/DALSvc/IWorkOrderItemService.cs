using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IWorkOrderItemService
    {
        [OperationContract]
        List<WorkOrderItem> GetAllWorkOrderItems();

        [OperationContract]
        WorkOrderItem GetWorkOrderItemById(Int32 id);

        [OperationContract]
        List<WorkOrderItem> GetWorkOrderItemsByWorkOrderId(Int32 workOrderId);

        [OperationContract]
        void DeleteRecord(WorkOrderItem workOrderItem);

        [OperationContract]
        int SaveRecord(WorkOrderItem workOrderItem);
    }
}
