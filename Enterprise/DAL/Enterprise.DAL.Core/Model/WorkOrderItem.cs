// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="WorkOrderItem.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class WorkOrderItem
    /// </summary>
    public class WorkOrderItem : ModelBase<WorkOrderItem>
    {
        /// <summary>
        /// The _date inserted
        /// </summary>
        private DateTime _dateInserted;

        /// <summary>
        /// The _product id
        /// </summary>
        private int _productId;

        /// <summary>
        /// The _quantity
        /// </summary>
        private decimal _quantity;

        /// <summary>
        /// The _rate
        /// </summary>
        private decimal _rate;

        /// <summary>
        /// The _work order id
        /// </summary>
        private int _workOrderId;

        /// <summary>
        /// The _work order item id
        /// </summary>
        private int _workOrderItemId;


        /// <summary>
        /// Gets or sets the work order item ID.
        /// </summary>
        /// <value>The work order item ID.</value>
        public Int32 WorkOrderItemID
        {
            get { return _workOrderItemId; }
            set { SetProperty(ref _workOrderItemId, value); }
        }

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
        /// Gets or sets the product ID.
        /// </summary>
        /// <value>The product ID.</value>
        public Int32 ProductID
        {
            get { return _productId; }
            set { SetProperty(ref _productId, value); }
        }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        public Decimal Quantity
        {
            get { return _quantity; }
            set { SetProperty(ref _quantity, value); }
        }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>The rate.</value>
        public Decimal Rate
        {
            get { return _rate; }
            set { SetProperty(ref _rate, value); }
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