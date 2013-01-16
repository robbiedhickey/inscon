using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class WorkOrderItem : SqlDataRecord
    {
        private DateTime _dateInserted;
        private int _productId;
        private decimal _quantity;
        private decimal _rate;
        private int _workOrderId;
        private int _workOrderItemId;

        public WorkOrderItem()
        {
            EntityNumber = 23;
        }

        public Int32 WorkOrderItemId
        {
            get { return _workOrderItemId; }
            set { _workOrderItemId = value; }
        }

        public Int32 WorkOrderId
        {
            get { return _workOrderId; }
            set { _workOrderId = value; }
        }

        public Int32 ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public Decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        public DateTime DateInserted
        {
            get { return _dateInserted; }
            set { _dateInserted = value; }
        }


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
        ///     Insert a new record, or update the current record using ID
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
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrderItem_Delete, _workOrderItemId));
            CacheItem.Clear<WorkOrderItem>();
        }
    }
}