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
    /// <summary>
    /// Handles access to the WorkOrderItem table.
    /// </summary>
    public class WorkOrderItemService : IWorkOrderItemService
    {
        /// <summary>
        /// Gets all work order items.
        /// </summary>
        /// <returns>A list of WorkOrderItem objects.</returns>
        public List<WorkOrderItem> GetAllWorkOrderItems()
        {
            try
            {
                return new dbSvc().GetAllWorkOrderItems();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the work order item by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The WorkOrderItem object that matches the id.</returns>
        public WorkOrderItem GetWorkOrderItemById(int id)
        {
            try
            {
                return new dbSvc().GetWorkOrderItemById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the work order items by work order id.
        /// </summary>
        /// <param name="workOrderId">The work order id.</param>
        /// <returns>A list of WorkOrderItem objects that matches the work order id.</returns>
        public List<WorkOrderItem> GetWorkOrderItemsByWorkOrderId(int workOrderId)
        {
            try
            {
                return new dbSvc().GetWorkOrderItemsByWorkOrderId(workOrderId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the WorkOrderItem record.
        /// </summary>
        /// <param name="workOrderItem">The work order item to delete.</param>
        public void DeleteRecord(WorkOrderItem workOrderItem)
        {
            try
            {
                new dbSvc().DeleteRecord(workOrderItem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the WorkOrderItem record.
        /// </summary>
        /// <param name="workOrderItem">The work order item to save.</param>
        /// <returns>The id of the saved WorkOrderItem.</returns>
        public int SaveRecord(WorkOrderItem workOrderItem)
        {
            try
            {
                return new dbSvc().SaveRecord(workOrderItem);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
