using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IWorkOrderItemRepository
    {
        List<WorkOrderItem> GetAllWorkOrderItems();
        WorkOrderItem GetWorkOrderItemById(Int32 id);
        List<WorkOrderItem> GetWorkOrderItemsByWorkOrderId(Int32 workOrderId);
        bool DeleteRecord(WorkOrderItem workOrderItem);
        int SaveRecord(WorkOrderItem workOrderItem);
    }
}
