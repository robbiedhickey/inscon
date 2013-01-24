using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class WorkOrderAssignment : ModelBase
    {
        private DateTime _eventDate;
        private int _statusId;
        private int _userId;
        private int _workOrderAssignmentId;
        private int _workOrderId;

        public WorkOrderAssignment()
        {
            EntityNumber = (short)Entities.WorkOrderAssignment;
        }

        public Int32 WorkOrderAssignmentId
        {
            get { return _workOrderAssignmentId; }
            set { SetProperty(ref _workOrderAssignmentId, value); }
        }

        public Int32 WorkOrderId
        {
            get { return _workOrderId; }
            set { SetProperty(ref _workOrderId, value); }
        }

        public Int32 UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        public DateTime EventDate
        {
            get { return _eventDate; }
            set { SetProperty(ref _eventDate, value); }
        }

        public Int32 StatusId
        {
            get { return _statusId; }
            set { SetProperty(ref _statusId, value); }
        }

        public static WorkOrderAssignment Build(ITypeReader reader)
        {
            var record = new WorkOrderAssignment
                {
                    WorkOrderAssignmentId = reader.GetInt32("WorkOrderAssignmentID"),
                    WorkOrderId = reader.GetInt32("WorkOrderID"),
                    UserId = reader.GetInt32("UserID"),
                    EventDate = reader.GetDate("EventDate"),
                    StatusId = reader.GetInt32("StatusID")
                };

            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_workOrderAssignmentId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrderAssignment_Update
                                       , _workOrderAssignmentId
                                       , _workOrderId
                                       , _userId
                                       , _eventDate
                                       , _statusId));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _workOrderAssignmentId = Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrderAssignment_Insert
                                                            , _workOrderId
                                                            , _userId
                                                            , _eventDate
                                                            , _statusId), Convert.ToInt32);
                CacheItem.Clear<WorkOrderAssignment>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.WorkOrderAssignment_Delete, _workOrderAssignmentId));
            CacheItem.Clear<WorkOrderAssignment>();
        }
    }
}