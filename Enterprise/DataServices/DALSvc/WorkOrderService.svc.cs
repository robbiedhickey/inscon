using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.WorkOrderService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class WorkOrderService : IWorkOrderService
    {
        public List<WorkOrder> GetAllWorkOrders()
        {
            throw new NotImplementedException();
        }

        public WorkOrder GetWorkOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WorkOrder> GetWorkOrdersByRequestId(int requestId)
        {
            throw new NotImplementedException();
        }

        public List<WorkOrder> GetWorkOrdersByAssetId(int assetId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(WorkOrder workOrder)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(WorkOrder workOrder)
        {
            throw new NotImplementedException();
        }
    }
}
