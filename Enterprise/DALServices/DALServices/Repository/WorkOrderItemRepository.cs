using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.WorkOrderItemService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class WorkOrderItemRepository : IWorkOrderItemRepository
    {
        public List<WorkOrderItem> GetAllWorkOrderItems()
        {
            return new dbSvc().GetAllWorkOrderItems();
        }

        public WorkOrderItem GetWorkOrderItemById(int id)
        {
            return new dbSvc().GetWorkOrderItemById(id);
        }

        public List<WorkOrderItem> GetWorkOrderItemsByWorkOrderId(int workOrderId)
        {
            return new dbSvc().GetWorkOrderItemsByWorkOrderId(workOrderId);
        }

        public void DeleteRecord(WorkOrderItem workOrderItem)
        {
            new dbSvc().DeleteRecord(workOrderItem);
        }

        public int SaveRecord(WorkOrderItem workOrderItem)
        {
            return new dbSvc().SaveRecord(workOrderItem);
        }
    }
}