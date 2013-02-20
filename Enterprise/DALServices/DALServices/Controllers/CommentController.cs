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
    public class CommentController : ApiController
    {
        private readonly ICommentRepository _repository = new CommentRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        private List<Comment> GetAllComments()
        {
            return _repository.GetAllComments();
        }

        [HttpGet]
        public Comment GetCommentById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the comment must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetCommentById(id);
        }

        [HttpGet]
        public Comment GetCommentByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (parentID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The parentID for the comment must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            if (entityID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The entityID for the comment must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetCommentByParentIdAndEntityID(parentID, entityID);
        }

        [HttpDelete]
        public void DeleteRecord(Comment comment)
        {
            if (comment == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The comment must not be null.",
                                                             "Null Value Not Allowed"));
            }

            _repository.DeleteRecord(comment);
        }

        [HttpPost]
        public int SaveRecord(Comment comment)
        {
            if (comment == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The comment must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.SaveRecord(comment);
        }
    }
}
