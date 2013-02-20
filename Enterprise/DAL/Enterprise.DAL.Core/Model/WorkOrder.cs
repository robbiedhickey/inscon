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

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class WorkOrder
    /// </summary>
    public class WorkOrder : ModelBase<WorkOrder>
    {
        /// <summary>
        /// The _date inserted
        /// </summary>
        private DateTime _dateInserted;

        /// <summary>
        /// The _asset id
        /// </summary>
        private Int32? _assetId ;

        /// <summary>
        /// The _request id
        /// </summary>
        private Int32 _requestId;

        /// <summary>
        /// The _work order id
        /// </summary>
        private Int32 _workOrderId;

        /// <summary>
        /// Gets or sets the work order ID.
        /// </summary>
        /// <value>The work order ID.</value>
        public Int32 WorkOrderID
        {
            get { return _workOrderId; }
            set { SetProperty(ref _workOrderId, value); }
        }

        /// <summary>
        /// Gets or sets the request ID.
        /// </summary>
        /// <value>The request ID.</value>
        public Int32 RequestID
        {
            get { return _requestId; }
            set { SetProperty(ref _requestId, value); }
        }

        /// <summary>
        /// Gets or sets the asset ID.
        /// </summary>
        /// <value>The asset ID.</value>
        public Int32? AssetID   
        {
            get { return _assetId; }
            set { SetProperty(ref _assetId, value); }
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
    }
}