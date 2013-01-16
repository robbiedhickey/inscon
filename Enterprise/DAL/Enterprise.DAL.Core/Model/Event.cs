using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class Event : SqlDataRecord
    {
        private DateTime _date;
        private short _entityId;
        private int _eventId;
        private int _parentId;
        private int _typeId;
        private int _userId;

        public Event()
        {
            EntityNumber = 9;
        }

        public Int32 EventId
        {
            get { return _eventId; }
            set { SetProperty(ref _eventId, value); }
        }

        public Int32 ParentId
        {
            get { return _parentId; }
            set { SetProperty(ref _parentId, value); }
        }

        public Int16 EntityId
        {
            get { return _entityId; }
            set { SetProperty(ref _entityId, value); }
        }

        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        public Int32 UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        public DateTime Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeId).Value; }
        }

        #region public methods


        public static Event Build(ITypeReader reader)
        {
            var record = new Event
                {
                    EventId = reader.GetInt32("EventID"),
                    ParentId = reader.GetInt32("ParentID"),
                    EntityId = reader.GetInt16("EntityID"),
                    TypeId = reader.GetInt32("TypeID"),
                    UserId = reader.GetInt32("UserID"),
                    Date = reader.GetDate("EventDate")
                };

            return record;
        }


        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_eventId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Event_Update
                                       , _eventId
                                       , _parentId
                                       , _entityId
                                       , _typeId
                                       , _userId
                                       , _date));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _eventId = Execute(GetCommand(Database.EnterpriseDb, Procedure.Event_Insert
                                              , _parentId
                                              , _entityId
                                              , _typeId
                                              , _userId
                                              , _date), Convert.ToInt32);
                CacheItem.Clear<Event>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Event_Delete, _eventId));
            CacheItem.Clear<Event>();
        }

        #endregion
    }
}