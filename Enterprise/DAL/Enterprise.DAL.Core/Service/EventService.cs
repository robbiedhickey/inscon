using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
namespace Enterprise.DAL.Core.Service
{
    public class EventService : ServiceBase<Event>
    {

        /// <summary>
        /// Get all Event records
        /// </summary>
        /// <returns></returns>
        public List<Event> GetAllEvents()
        {
            return QueryAll(SqlDatabase, Procedure.Event_SelectAll, Event.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get Address record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Event GetEventById(int id)
        {
            if (IsCached)
            {
                Predicate<Event> h = h2 => h2.EventId == id;
                return GetAllEvents().Find(h) ?? new Event();
            }

            return Query(SqlDatabase, Procedure.Event_SelectById, Event.Build, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="entityID"></param>
        /// <returns></returns>
        public Event GetEventByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (IsCached)
            {
                Predicate<Event> h = h2 => h2.ParentId == parentID && h2.EntityId == entityID;
                return GetAllEvents().Find(h) ?? new Event();
            }

            return Query(SqlDatabase, Procedure.Address_SelectByParentIdAndEntityId, Event.Build, parentID, entityID);
        }
    }
}
