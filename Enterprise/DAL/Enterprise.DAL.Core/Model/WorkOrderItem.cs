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
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class WorkOrderItem
    /// </summary>
    public class WorkOrderItem : ModelBase
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
        /// Initializes a new instance of the <see cref="WorkOrderItem"/> class.
        /// </summary>
        public WorkOrderItem()
        {
            EntityNumber = WorkOrderItem_EntityId;
        }

        /// <summary>
        /// Gets or sets the work order item id.
        /// </summary>
        /// <value>The work order item id.</value>
        public Int32 WorkOrderItemId
        {
            get { return _workOrderItemId; }
            set { SetProperty(ref _workOrderItemId, value); }
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
        /// Gets or sets the product id.
        /// </summary>
        /// <value>The product id.</value>
        public Int32 ProductId
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


        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>WorkOrderItem.</returns>
        public static WorkOrderItem Build(ITypeReader reader)
        {
            var record = new WorkOrderItem
                {
                    WorkOrderItemId = reader.GetInt32("WorkOrderItemID"),
                    WorkOrderId = reader.GetInt32("WorkorderID"),
                    ProductId = reader.GetInt32("ProductID"),
                    Quantity = reader.GetDecimal("Quantity"),
                    Rate = reader.GetDecimal("Rate"),
                    DateInserted = reader.GetDate("DateInserted")
                };

            return record;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_workOrderItemId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrderItem_Update
                                       , _workOrderItemId
                                       , _workOrderId
                                       , _productId
                                       , _quantity
                                       , _rate
                                       , _dateInserted));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _workOrderItemId = Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrderItem_Insert
                                                      , _workOrderId
                                                      , _productId
                                                      , _quantity
                                                      , _rate
                                                      , _dateInserted), Convert.ToInt32);
                CacheItem.Clear<WorkOrderItem>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrderItem_Delete, _workOrderItemId));
            CacheItem.Clear<WorkOrderItem>();
        }
    }
}