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
    public class UserAreaCoverageController : ApiController
    {
        private readonly IUserAreaCoverageRepository _repository = new UserAreaCoverageRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        public List<UserAreaCoverage> GetAllUserAreaCoverages()
        {
            return _repository.GetAllUserAreaCoverages();
        }

        public UserAreaCoverage GetUserAreaCoverageByParentId(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the user area coverage must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetUserAreaCoverageByParentId(id);
        }

        public List<UserAreaCoverage> GetUserAreaCoverageByUserIdandServiceId(Int32 userId, Int32 serviceId)
        {
            if (userId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The User ID for the user area coverage must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            if (serviceId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Service ID for the user area coverage must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetUserAreaCoverageByUserIdandServiceId(userId, serviceId);
        }

        public void DeleteRecord(UserAreaCoverage userAreaCoverage)
        {
            if (userAreaCoverage == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The user area coverage must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(userAreaCoverage);
        }

        public int SaveRecord(UserAreaCoverage userAreaCoverage)
        {
            if (userAreaCoverage == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The user area coverage must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(userAreaCoverage);
        }
    }
}
