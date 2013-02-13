using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IWorkOrderRepository
    {
        List<WorkOrder> GetAllWorkOrders();
        WorkOrder GetWorkOrderById(Int32 id);
        List<WorkOrder> GetWorkOrdersByRequestId(Int32 requestId);
        List<WorkOrder> GetWorkOrdersByAssetId(Int32 assetId);
        void DeleteRecord(WorkOrder workOrder);
        int SaveRecord(WorkOrder workOrder);
    }
}
