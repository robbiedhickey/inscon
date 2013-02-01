using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.WorkOrderItemService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class WorkOrderItemService : IWorkOrderItemService
    {
        public List<WorkOrderItem> GetAllWorkOrderItems()
        {
            throw new NotImplementedException();
        }

        public WorkOrderItem GetWorkOrderItemById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WorkOrderItem> GetWorkOrderItemsByWorkOrderId(int workOrderId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(WorkOrderItem workOrderItem)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(WorkOrderItem workOrderItem)
        {
            throw new NotImplementedException();
        }
    }
}
