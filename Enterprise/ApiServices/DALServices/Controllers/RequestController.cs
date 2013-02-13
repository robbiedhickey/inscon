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
    public class RequestController : ApiController
    {
        private readonly IRequestRepository _repository = new RequestRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        public List<Request> GetAllRequests()
        {
            return _repository.GetAllRequests();
        }

        public Request GetRequestById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the request must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetRequestById(id);
        }

        public void DeleteRecord(Request request)
        {
            if (request == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The request must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(request);
        }

        public int SaveRecord(Request request)
        {
            if (request == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The request must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(request);
        }
    }
}
