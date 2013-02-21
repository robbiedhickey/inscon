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
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class WorkOrderItemService
    /// </summary>
    public class WorkOrderItemService : ServiceBase<WorkOrderItem>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>WorkOrderItem.</returns>
        public static WorkOrderItem Build(ITypeReader reader)
        {
            var record = new WorkOrderItem
                {
                    WorkOrderItemID = reader.GetInt32("WorkOrderItemID"),
                    WorkOrderID = reader.GetInt32("WorkOrderID"),
                    ProductID = reader.GetInt32("ProductID"),
                    Quantity = reader.GetDecimal("Quantity"),
                    Rate = reader.GetDecimal("Rate"),
                    DateInserted = reader.GetDate("DateInserted")
                };

            return record;
        }


        /// <summary>
        /// Gets all work order items.
        /// </summary>
        /// <returns>List{WorkOrderItem}.</returns>
        public List<WorkOrderItem> GetAllWorkOrderItems()
        {
            return QueryAll(SqlDatabase, Procedure.WorkOrderItem_SelectAll, Build, CacheMinutesToExpire,
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
                Predicate<WorkOrderItem> h = h2 => h2.WorkOrderItemID == id;
                return GetAllWorkOrderItems().Find(h);
            }

            return Query(SqlDatabase, Procedure.WorkOrderItem_SelectById, Build, id);
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
                Predicate<WorkOrderItem> h = h2 => h2.WorkOrderID == workOrderId;
                return GetAllWorkOrderItems().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.WorkOrderItem_SelectByWorkorderId, Build, workOrderId);
        }
    }
}