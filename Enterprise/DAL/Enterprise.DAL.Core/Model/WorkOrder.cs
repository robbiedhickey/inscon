// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="WorkOrder.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class WorkOrder
    /// </summary>
    public class WorkOrder : ModelBase
    {
        /// <summary>
        /// The _date inserted
        /// </summary>
        private DateTime _dateInserted;

        /// <summary>
        /// The _loan id
        /// </summary>
        private Int32? _loanId;

        /// <summary>
        /// The _request id
        /// </summary>
        private Int32 _requestId;

        /// <summary>
        /// The _work order id
        /// </summary>
        private Int32 _workOrderId;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrder"/> class.
        /// </summary>
        public WorkOrder()
        {
            EntityNumber = WorkOrder_EntityId;
        }

        /// <summary>
        /// Gets or sets the work order id.
        /// </summary>
        /// <value>The work order id.</value>
        public Int32 WorkOrderId
        {
            get { return _workOrderId; }
            set { SetProperty(ref _workOrderId, value); }
        }

        /// <summary>
        /// Gets or sets the request id.
        /// </summary>
        /// <value>The request id.</value>
        public Int32 RequestId
        {
            get { return _requestId; }
            set { SetProperty(ref _requestId, value); }
        }

        /// <summary>
        /// Gets or sets the loan id.
        /// </summary>
        /// <value>The loan id.</value>
        public Int32? LoanId
        {
            get { return _loanId; }
            set { SetProperty(ref _loanId, value); }
        }

        /// <summary>
        /// Gets or sets the date inserted.
        /// </summary>
        /// <value>The date inserted.</value>
        public DateTime DateInserted
        {
            get { return _dateInserted; }
            set { SetProperty(ref _dateInserted, value); }
        }

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
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_workOrderId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrder_Update
                                       , _workOrderId
                                       , _requestId
                                       , _loanId
                                       , _dateInserted));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _workOrderId = Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrder_Insert
                                                  , _requestId
                                                  , _loanId
                                                  , _dateInserted), Convert.ToInt32);
                CacheItem.Clear<WorkOrder>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrder_Delete, _workOrderId));
            CacheItem.Clear<WorkOrder>();
        }
    }
}