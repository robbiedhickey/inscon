using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class WorkOrderItemService : ServiceBase<WorkOrderItem>
    {
        /// <summary>
        ///     Get all WorkOrderItem records
        /// </summary>
        /// <returns></returns>
        public List<WorkOrderItem> GetAllWorkOrderItems()
        {
            return QueryAll(SqlDatabase, Procedure.WorkOrderItem_SelectAll, WorkOrderItem.Build, CacheMinutesToExpire,
                            IsCached);
        }

        /// <summary>
        ///     Get WorkOrderItem record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public WorkOrderItem GetWorkOrderItemById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<WorkOrderItem> h = h2 => h2.WorkOrderItemId == id;
                return GetAllWorkOrderItems().Find(h) ?? new WorkOrderItem();
            }

            return Query(SqlDatabase, Procedure.WorkOrderItem_SelectById, WorkOrderItem.Build, id);
        }

        /// <summary>
        ///     Get WorkOrderItems by WorkorderID
        /// </summary>
        /// <param name="workOrderId"></param>
        /// <returns></returns>
        public List<WorkOrderItem> GetWorkOrderItemsByWorkOrderId(Int32 workOrderId)
        {
            if (IsCached)
            {
                Predicate<WorkOrderItem> h = h2 => h2.WorkOrderId == workOrderId;
                return GetAllWorkOrderItems().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.WorkOrderItem_SelectByWorkorderId, WorkOrderItem.Build, workOrderId);
        }
    }
}