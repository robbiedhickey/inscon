// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="WorkOrderAssignmentService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class WorkOrderAssignmentService
    /// </summary>
    public class WorkOrderAssignmentService : ServiceBase<WorkOrderAssignment>
    {
        /// <summary>
        /// Gets all work order assignments.
        /// </summary>
        /// <returns>List{WorkOrderAssignment}.</returns>
        public List<WorkOrderAssignment> GetAllWorkOrderAssignments()
        {
            return QueryAll(SqlDatabase, Procedure.WorkOrderAssignment_SelectAll, WorkOrderAssignment.Build,
                            CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the work order assignment by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>WorkOrderAssignment.</returns>
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
        /// Gets all work order assignments by work order id.
        /// </summary>
        /// <param name="workOrderId">The work order id.</param>
        /// <returns>List{WorkOrderAssignment}.</returns>
        public List<WorkOrderAssignment> GetAllWorkOrderAssignmentsByWorkOrderId(Int32 workOrderId)
        {
            if (IsCached)
            {
                Predicate<WorkOrderAssignment> h = h2 => h2.WorkOrderId == workOrderId;
                return GetAllWorkOrderAssignments().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.WorkOrderAssignment_SelectByWorkOrderId, WorkOrderAssignment.Build,
                            workOrderId);
        }
    }
}