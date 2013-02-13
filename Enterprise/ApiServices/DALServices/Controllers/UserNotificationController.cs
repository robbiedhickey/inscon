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
    public class UserNotificationController : ApiController
    {
        private readonly IUserNotificationRepository _repository = new UserNotificationRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        public List<UserNotification> GetAllUserNotifications()
        {
            return _repository.GetAllUserNotifications();
        }

        public UserNotification GetUserNotificationById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the user notofication must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetUserNotificationById(id);
        }

        public List<UserNotification> GetUserNotificationsByUserId(Int32 userId)
        {
            if (userId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the user notofication must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetUserNotificationsByUserId(userId);
        }

        public void DeleteRecord(UserNotification userNotification)
        {
            if (userNotification == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The user notofication must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(userNotification);
        }

        public int SaveRecord(UserNotification userNotification)
        {
            if (userNotification == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The user notification must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(userNotification);
        }
    }
}
