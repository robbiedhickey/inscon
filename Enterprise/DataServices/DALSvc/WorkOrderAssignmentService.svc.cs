using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.WorkOrderAssignmentService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class WorkOrderAssignmentService : IWorkOrderAssignmentService
    {
        public List<WorkOrderAssignment> GetAllWorkOrderAssignments()
        {
            throw new NotImplementedException();
        }

        public WorkOrderAssignment GetWorkOrderAssignmentById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WorkOrderAssignment> GetAllWorkOrderAssignmentsByWorkOrderId(int workOrderId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(WorkOrderAssignment workOrderAssignment)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(WorkOrderAssignment workOrderAssignment)
        {
            throw new NotImplementedException();
        }
    }
}
