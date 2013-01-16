using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class WorkOrderAssignmentService: ServiceBase<WorkOrderAssignment>
    {

        /// <summary>
        /// Get all WorkOrderAssignment records
        /// </summary>
        /// <returns></returns>
        public List<WorkOrderAssignment> GetAllWorkOrderAssignments()
        {
            return QueryAll(SqlDatabase, Procedure.WorkOrderAssignment_SelectAll, WorkOrderAssignment.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get WorkOrderAssignment record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public WorkOrderAssignment GetWorkOrderAssignmentById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<WorkOrderAssignment> h = h2 => h2.WorkOrderAssignmentId == id;
                return GetAllWorkOrderAssignments().Find(h) ?? new WorkOrderAssignment();
            }

            return Query(SqlDatabase, Procedure.WorkOrderAssignment_SelectById, WorkOrderAssignment.Build, id);
        }

        /// <summary>
        /// Get All Assignments by WorkOrderID
        /// </summary>
        /// <param name="workOrderId"></param>
        /// <returns></returns>
        public List<WorkOrderAssignment> GetAllWorkOrderAssignmentsByWorkOrderId(Int32 workOrderId)
        {
            if (IsCached)
            {
                Predicate<WorkOrderAssignment> h = h2 => h2.WorkOrderId == workOrderId;
                return GetAllWorkOrderAssignments().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.WorkOrderAssignment_SelectByWorkOrderId, WorkOrderAssignment.Build, workOrderId);
        }


    }
}
