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
    /// <summary>
    /// Handles access to the WorkOrderAssignment table.
    /// </summary>
    public class WorkOrderAssignmentService : IWorkOrderAssignmentService
    {
        /// <summary>
        /// Gets all work order assignments.
        /// </summary>
        /// <returns>A list of WorkOrderAssignment objects.</returns>
        public List<WorkOrderAssignment> GetAllWorkOrderAssignments()
        {
            try
            {
                return new dbSvc().GetAllWorkOrderAssignments();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the work order assignment by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The WorkOrderAssignment object that matches the id.</returns>
        public WorkOrderAssignment GetWorkOrderAssignmentById(int id)
        {
            try
            {
                return new dbSvc().GetWorkOrderAssignmentById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets all work order assignments by work order id.
        /// </summary>
        /// <param name="workOrderId">The work order id.</param>
        /// <returns>A list of WorkOrderAssignment objects that match the work order id.</returns>
        public List<WorkOrderAssignment> GetAllWorkOrderAssignmentsByWorkOrderId(int workOrderId)
        {
            try
            {
                return new dbSvc().GetAllWorkOrderAssignmentsByWorkOrderId(workOrderId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the WorkOrderAssignment record.
        /// </summary>
        /// <param name="workOrderAssignment">The work order assignment to delete.</param>
        public void DeleteRecord(WorkOrderAssignment workOrderAssignment)
        {
            try
            {
                new dbSvc().DeleteRecord(workOrderAssignment);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the WorkOrderAssignment record.
        /// </summary>
        /// <param name="workOrderAssignment">The work order assignment to save.</param>
        /// <returns>The id of the saved WorkOrderAssignment.</returns>
        public int SaveRecord(WorkOrderAssignment workOrderAssignment)
        {
            try
            {
                return new dbSvc().SaveRecord(workOrderAssignment);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
