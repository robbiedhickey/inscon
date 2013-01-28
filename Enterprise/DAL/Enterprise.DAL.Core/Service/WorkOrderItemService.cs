// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="WorkOrderItemService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class WorkOrderItemService
    /// </summary>
    public class WorkOrderItemService : ServiceBase<WorkOrderItem>
    {
        /// <summary>
        /// Gets all work order items.
        /// </summary>
        /// <returns>List{WorkOrderItem}.</returns>
        public List<WorkOrderItem> GetAllWorkOrderItems()
        {
            return QueryAll(SqlDatabase, Procedure.WorkOrderItem_SelectAll, WorkOrderItem.Build, CacheMinutesToExpire,
                            IsCached);
        }

        /// <summary>
        /// Gets the work order item by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>WorkOrderItem.</returns>
        public WorkOrderItem GetWorkOrderItemById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<WorkOrderItem> h = h2 => h2.WorkOrderItemId == id;
                return GetAllWorkOrderItems().Find(h) ?? new WorkOrderItem();
            }

            return Query(SqlDatabase, Procedure.WorkOrderItem_SelectById, WorkOrderItem.Build, id);
        }

        /// <summary>
        /// Gets the work order items by work order id.
        /// </summary>
        /// <param name="workOrderId">The work order id.</param>
        /// <returns>List{WorkOrderItem}.</returns>
        public List<WorkOrderItem> GetWorkOrderItemsByWorkOrderId(Int32 workOrderId)
        {
            if (IsCached)
            {
                Predicate<WorkOrderItem> h = h2 => h2.WorkOrderId == workOrderId;
                return GetAllWorkOrderItems().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.WorkOrderItem_SelectByWorkorderId, WorkOrderItem.Build, workOrderId);
        }
    }
}