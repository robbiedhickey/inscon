using Enterprise.ApiServices.DALServices.Helpers;
using Enterprise.ApiServices.DALServices.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Enterprise.DAL.Core.Model;

namespace Enterprise.ApiServices.DALServices.Controllers
{
    public class EventController : ApiController
    {
        private readonly IEventRepository _repository = new EventRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        public List<Event> GetAllEvents()
        {
            return _repository.GetAllEvents();
        }

        public Event GetEventById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the event must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetEventById(id);
        }

        public Event GetEventByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (parentID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The parentID for the event must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            if (entityID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The entityID for the event must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetEventByParentIdAndEntityID(parentID, entityID);
        }

        public void DeleteRecord(Event dalEvent)
        {
            if (dalEvent == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The event must not be null.",
                                                             "Null Value Not Allowed"));
            }

            _repository.DeleteRecord(dalEvent);
        }

        public int SaveRecord(Event dalEvent)
        {
            if (dalEvent == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The event must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.SaveRecord(dalEvent);
        }
    }
}
