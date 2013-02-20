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
    public class LocationController : ApiController
    {
        private readonly ILocationRepository _repository = new LocationRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<Location> GetAllLocations()
        {
            return _repository.GetAllLocations();
        }

        [HttpGet]
        public Location GetLocationById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the location must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetLocationById(id);
        }

        [HttpGet]
        public List<Location> GetLocationsByOrganizationId(int orgId)
        {
            if (orgId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Organization ID for the location must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetLocationsByOrganizationId(orgId);
        }

        [HttpGet]
        public List<Location> GetLocationsByOrganizationIdandTypeId(Int32 orgId, Int32 typeId)
        {
            if (orgId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Organization ID for the location must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            if (typeId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Type ID for the location must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetLocationsByOrganizationIdandTypeId(orgId, typeId);
        }

        [HttpDelete]
        public bool DeleteRecord(Location location)
        {
            if (location == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The location must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.DeleteRecord(location);
        }

        [HttpPost]
        public int SaveRecord(Location location)
        {
            if (location == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The location must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(location);
        }
    }
}
