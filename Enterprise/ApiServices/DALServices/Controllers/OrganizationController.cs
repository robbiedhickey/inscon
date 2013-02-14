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
    public class OrganizationController : ApiController
    {
        private readonly IOrganizationRepository _repository = new OrganizationRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<Organization> GetAllOrganizations()
        {
            return _repository.GetAllOrganizations();
        }

        [HttpGet]
        public Organization GetOrganizationById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the organization must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetOrganizationById(id);
        }

        [HttpGet]
        public List<Organization> GetOrganizationsByTypeId(int? typeID)
        {
            if (typeID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Type ID for the organization must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetOrganizationsByTypeId(typeID);
        }

        [HttpDelete]
        public void DeleteRecord(Organization organization)
        {
            if (organization == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The organization must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(organization);
        }

        [HttpPost]
        public int SaveRecord(Organization organization)
        {
            if (organization == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The organization must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(organization);
        }
    }
}
