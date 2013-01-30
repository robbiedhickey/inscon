// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="WorkOrderService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class WorkOrderService
    /// </summary>
    public class WorkOrderService : ServiceBase<WorkOrder>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>WorkOrder.</returns>
        public static WorkOrder Build(ITypeReader reader)
        {
            var record = new WorkOrder
                {
                    WorkOrderId = reader.GetInt32("WorkOrderID"),
                    RequestId = reader.GetInt32("RequestID"),
                    LoanId = reader.GetInt32("LoanID"),
                    DateInserted = reader.GetDate("DateInserted")
                };

            return record;
        }

        /// <summary>
        /// Gets all work orders.
        /// </summary>
        /// <returns>List{WorkOrder}.</returns>
        public List<WorkOrder> GetAllWorkOrders()
        {
            return QueryAll(SqlDatabase, Procedure.WorkOrder_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the work order by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>WorkOrder.</returns>
        public WorkOrder GetWorkOrderById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<WorkOrder> h = h2 => h2.WorkOrderId == id;
                return GetAllWorkOrders().Find(h) ?? new WorkOrder();
            }

            return Query(SqlDatabase, Procedure.File_SelectById, Build, id);
        }


        /// <summary>
        /// Gets the work orders by request id.
        /// </summary>
        /// <param name="requestId">The request id.</param>
        /// <returns>List{WorkOrder}.</returns>
        public List<WorkOrder> GetWorkOrdersByRequestId(Int32 requestId)
        {
            if (IsCached)
            {
                Predicate<WorkOrder> h = h2 => h2.RequestId == requestId;
                return GetAllWorkOrders().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.WorkOrder_SelectByRequestId, Build, requestId);
        }
    }
}