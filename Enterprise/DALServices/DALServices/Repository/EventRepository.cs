using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.EventService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class EventRepository : IEventRepository
    {
        public List<Event> GetAllEvents()
        {
            return new dbSvc().GetAllEvents();
        }

        public Event GetEventById(int id)
        {
            return new dbSvc().GetEventById(id);
        }

        public Event GetEventByParentIdAndEntityID(int parentId, short entityId)
        {
            return new dbSvc().GetEventByParentIdAndEntityID(parentId, entityId);
        }

        public bool DeleteRecord(Event dalEvent)
        {
            return new dbSvc().DeleteRecord(dalEvent);
        }

        public int SaveRecord(Event dalEvent)
        {
            return new dbSvc().SaveRecord(dalEvent);
        }
    }
}