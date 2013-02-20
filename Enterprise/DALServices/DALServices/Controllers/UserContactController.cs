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
    public class UserContactController : ApiController
    {
        private readonly IUserContactRepository _repository = new UserContactRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<UserContact> GetAllUserContacts()
        {
            return _repository.GetAllUserContacts();
        }

        [HttpGet]
        public UserContact GetUserContactById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the user contact must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetUserContactById(id);
        }

        [HttpGet]
        public List<UserContact> GetUserContactsByUserId(Int32 userID)
        {
            if (userID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The User ID for the user contact must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetUserContactsByUserId(userID);
        }

        [HttpGet]
        public List<UserContact> GetUserContactsByUserIdAndTypeId(Int32 userID, Int32 typeId)
        {
            if (userID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The User ID for the user contact must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            if (typeId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Type ID for the user contact must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetUserContactsByUserIdAndTypeId(userID, typeId);
        }

        [HttpDelete]
        public void DeleteRecord(UserContact userContact)
        {
            if (userContact == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The user contact must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(userContact);
        }

        [HttpPost]
        public int SaveRecord(UserContact userContact)
        {
            if (userContact == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The user contact must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(userContact);
        }
    }
}
