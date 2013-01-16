using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;


namespace Enterprise.DAL.Core.Service
{
    public class WorkOrderService : ServiceBase<WorkOrder>
    {

        /// <summary>
        /// Get all WorkOrder records
        /// </summary>
        /// <returns></returns>
        public List<WorkOrder> GetAllWorkOrders()
        {
            return QueryAll(SqlDatabase, Procedure.WorkOrder_SelectAll, WorkOrder.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get WorkOrder record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public WorkOrder GetWorkOrderById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<WorkOrder> h = h2 => h2.WorkOrderId == id;
                return GetAllWorkOrders().Find(h) ?? new WorkOrder();
            }

            return Query(SqlDatabase, Procedure.File_SelectById, WorkOrder.Build, id);
        }

        
        public List<WorkOrder> GetWorkOrdersByRequestId(Int32 requestId)
        {
            if (IsCached)
            {
                Predicate<WorkOrder> h = h2 => h2.RequestId == requestId;
                return GetAllWorkOrders().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.WorkOrder_SelectByRequestId, WorkOrder.Build, requestId);
        }
    }
}
