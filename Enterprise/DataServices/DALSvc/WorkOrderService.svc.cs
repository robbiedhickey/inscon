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
    /// <summary>
    /// Handles access to the WorkOrder table.
    /// </summary>
    public class WorkOrderService : IWorkOrderService
    {
        /// <summary>
        /// Gets all work orders.
        /// </summary>
        /// <returns>A list of WorkOrder objects.</returns>
        public List<WorkOrder> GetAllWorkOrders()
        {
            try
            {
                return new dbSvc().GetAllWorkOrders();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the work order by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The WorkOrder object that matches the id.</returns>
        public WorkOrder GetWorkOrderById(int id)
        {
            try
            {
                return new dbSvc().GetWorkOrderById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the work orders by request id.
        /// </summary>
        /// <param name="requestId">The request id.</param>
        /// <returns>A list of WorkOrder objects that matches the request id.</returns>
        public List<WorkOrder> GetWorkOrdersByRequestId(int requestId)
        {
            try
            {
                return new dbSvc().GetWorkOrdersByRequestId(requestId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the work orders by asset id.
        /// </summary>
        /// <param name="assetId">The asset id.</param>
        /// <returns>A list of WorkOrder object that matches the asset id.</returns>
        public List<WorkOrder> GetWorkOrdersByAssetId(int assetId)
        {
            try
            {
                return new dbSvc().GetWorkOrdersByAssetId(assetId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the WorkOrder record.
        /// </summary>
        /// <param name="workOrder">The work order to delete.</param>
        public void DeleteRecord(WorkOrder workOrder)
        {
            try
            {
                new dbSvc().DeleteRecord(workOrder);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the WorkOrder record.
        /// </summary>
        /// <param name="workOrder">The work order to save.</param>
        /// <returns>The id of the saved WorkOrder.</returns>
        public int SaveRecord(WorkOrder workOrder)
        {
            try
            {
                return new dbSvc().SaveRecord(workOrder);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
