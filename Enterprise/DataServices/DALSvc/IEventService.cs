using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IEventService
    {
        [OperationContract]
        List<Event> GetAllEvents();

        [OperationContract]
        Event GetEventById(int id);

        [OperationContract]
        Event GetEventByParentIdAndEntityID(int parentID, Int16 entityID);

        [OperationContract]
        void DeleteRecord(Event dalEvent);

        [OperationContract]
        int SaveRecord(Event dalEvent);
    }
}
