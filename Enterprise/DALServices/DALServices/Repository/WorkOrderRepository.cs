using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.WorkOrderService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class WorkOrderRepository : IWorkOrderRepository
    {
        public List<WorkOrder> GetAllWorkOrders()
        {
            return new dbSvc().GetAllWorkOrders();
        }

        public WorkOrder GetWorkOrderById(int id)
        {
            return new dbSvc().GetWorkOrderById(id);
        }

        public List<WorkOrder> GetWorkOrdersByRequestId(int requestId)
        {
            return new dbSvc().GetWorkOrdersByRequestId(requestId);
        }

        public List<WorkOrder> GetWorkOrdersByAssetId(int assetId)
        {
            return new dbSvc().GetWorkOrdersByAssetId(assetId);
        }

        public bool DeleteRecord(WorkOrder workOrder)
        {
            return new dbSvc().DeleteRecord(workOrder);
        }

        public int SaveRecord(WorkOrder workOrder)
        {
            return new dbSvc().SaveRecord(workOrder);
        }
    }
}