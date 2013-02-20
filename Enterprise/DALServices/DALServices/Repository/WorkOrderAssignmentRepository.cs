using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.WorkOrderAssignmentService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class WorkOrderAssignmentRepository : IWorkOrderAssignmentRepository
    {
        public List<WorkOrderAssignment> GetAllWorkOrderAssignments()
        {
            return new dbSvc().GetAllWorkOrderAssignments();
        }

        public WorkOrderAssignment GetWorkOrderAssignmentById(int id)
        {
            return new dbSvc().GetWorkOrderAssignmentById(id);
        }

        public List<WorkOrderAssignment> GetAllWorkOrderAssignmentsByWorkOrderId(int workOrderId)
        {
            return new dbSvc().GetAllWorkOrderAssignmentsByWorkOrderId(workOrderId);
        }

        public void DeleteRecord(WorkOrderAssignment workOrderAssignment)
        {
            new dbSvc().DeleteRecord(workOrderAssignment);
        }

        public int SaveRecord(WorkOrderAssignment workOrderAssignment)
        {
            return new dbSvc().SaveRecord(workOrderAssignment);
        }
    }
}