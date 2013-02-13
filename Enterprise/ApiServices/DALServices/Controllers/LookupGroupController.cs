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
    public class LookupGroupController : ApiController
    {
        private readonly ILookupGroupRepository _repository = new LookupGroupRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        public List<LookupGroup> GetAllLookupGroups()
        {
            return _repository.GetAllLookupGroups();
        }

        public LookupGroup GetLookupGroupById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the lookup group must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetLookupGroupById(id);
        }

        public void DeleteRecord(LookupGroup lookupGroup)
        {
            if (lookupGroup == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The lookup group must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(lookupGroup);
        }

        public int SaveRecord(LookupGroup lookupGroup)
        {
            if (lookupGroup == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The lookup group must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(lookupGroup);
        }
    }
}
