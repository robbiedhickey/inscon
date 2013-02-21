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
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class WorkOrderAssignmentService
    /// </summary>
    public class WorkOrderAssignmentService : ServiceBase<WorkOrderAssignment>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>WorkOrderAssignment.</returns>
        public static WorkOrderAssignment Build(ITypeReader reader)
        {
            var record = new WorkOrderAssignment
                {
                    WorkOrderAssignmentID = reader.GetInt32("WorkOrderAssignmentID"),
                    WorkOrderID = reader.GetInt32("WorkOrderID"),
                    UserID = reader.GetInt32("UserID"),
                    EventDate = reader.GetDate("EventDate"),
                    StatusID = reader.GetInt32("StatusID")
                };

            return record;
        }

        /// <summary>
        /// Gets all work order assignments.
        /// </summary>
        /// <returns>List{WorkOrderAssignment}.</returns>
        public List<WorkOrderAssignment> GetAllWorkOrderAssignments()
        {
            return QueryAll(SqlDatabase, Procedure.WorkOrderAssignment_SelectAll, Build,
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
                Predicate<WorkOrderAssignment> h = h2 => h2.WorkOrderAssignmentID == id;
                return GetAllWorkOrderAssignments().Find(h);
            }

            return Query(SqlDatabase, Procedure.WorkOrderAssignment_SelectById, Build, id);
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
                Predicate<WorkOrderAssignment> h = h2 => h2.WorkOrderID == workOrderId;
                return GetAllWorkOrderAssignments().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.WorkOrderAssignment_SelectByWorkOrderId, Build,
                            workOrderId);
        }
    }
}