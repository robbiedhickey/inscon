using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IWorkOrderAssignmentService
    {
        [OperationContract]
        List<WorkOrderAssignment> GetAllWorkOrderAssignments();

        [OperationContract]
        WorkOrderAssignment GetWorkOrderAssignmentById(Int32 id);

        [OperationContract]
        List<WorkOrderAssignment> GetAllWorkOrderAssignmentsByWorkOrderId(Int32 workOrderId);

        [OperationContract]
        void DeleteRecord(WorkOrderAssignment workOrderAssignment);

        [OperationContract]
        int SaveRecord(WorkOrderAssignment workOrderAssignment);
    }
}
