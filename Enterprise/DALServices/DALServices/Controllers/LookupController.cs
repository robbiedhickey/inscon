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
    public class LookupController : ApiController
    {
        private readonly ILookupRepository _repository = new LookupRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<Lookup> GetAllLookups()
        {
            return _repository.GetAllLookups();
        }

        [HttpGet]
        public Lookup GetLookupById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the lookup must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetLookupById(id);
        }

        [HttpGet]
        public List<Lookup> GetLookupValuesByGroupId(Int16 groupID)
        {
            if (groupID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Group ID for the lookup must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetLookupValuesByGroupId(groupID);
        }

        [HttpDelete]
        public void DeleteRecord(Lookup lookup)
        {
            if (lookup == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The lookup must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(lookup);
        }

        [HttpPost]
        public int SaveRecord(Lookup lookup)
        {
            if (lookup == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The lookup must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(lookup);
        }
    }
}
