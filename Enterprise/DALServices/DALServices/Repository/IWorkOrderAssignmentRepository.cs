using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IWorkOrderAssignmentRepository
    {
        List<WorkOrderAssignment> GetAllWorkOrderAssignments();
        WorkOrderAssignment GetWorkOrderAssignmentById(Int32 id);
        List<WorkOrderAssignment> GetAllWorkOrderAssignmentsByWorkOrderId(Int32 workOrderId);
        bool DeleteRecord(WorkOrderAssignment workOrderAssignment);
        int SaveRecord(WorkOrderAssignment workOrderAssignment);
    }
}
