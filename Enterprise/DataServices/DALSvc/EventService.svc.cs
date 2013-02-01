using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.EventService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class EventService : IEventService
    {
        public List<Event> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public Event GetEventById(int id)
        {
            throw new NotImplementedException();
        }

        public Event GetEventByParentIdAndEntityID(int parentID, short entityID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Event dalEvent)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Event dalEvent)
        {
            throw new NotImplementedException();
        }
    }
}
