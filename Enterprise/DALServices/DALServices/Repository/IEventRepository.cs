using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEventById(int id);
        Event GetEventByParentIdAndEntityID(int parentId, Int16 entityId);
        void DeleteRecord(Event dalEvent);
        int SaveRecord(Event dalEvent);
    }
}
