using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class WorkOrder : ModelBase
    {
        private DateTime _dateInserted;
        private Int32? _loanId;
        private Int32 _requestId;
        private Int32 _workOrderId;

        public WorkOrder()
        {
            EntityNumber = (short) Entities.WorkOrder;
        }

        public Int32 WorkOrderId
        {
            get { return _workOrderId; }
            set { SetProperty(ref _workOrderId, value); }
        }

        public Int32 RequestId
        {
            get { return _requestId; }
            set { SetProperty(ref _requestId, value); }
        }

        public Int32? LoanId
        {
            get { return _loanId; }
            set { SetProperty(ref _loanId, value); }
        }

        public DateTime DateInserted
        {
            get { return _dateInserted; }
            set { SetProperty(ref _dateInserted, value); }
        }

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
        ///     Insert a new record, or update the current record using ID
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
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrder_Delete, _workOrderId));
            CacheItem.Clear<WorkOrder>();
        }
    }
}