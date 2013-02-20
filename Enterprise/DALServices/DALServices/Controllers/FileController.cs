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
    public class FileController : ApiController
    {
        private readonly IFileRepository _repository = new FileRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<File> GetAllFiles()
        {
            return _repository.GetAllFiles();
        }

        [HttpGet]
        public File GetFileById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the file must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetFileById(id);
        }

        [HttpGet]
        public File GetFileByParentIdAndEntityID(Int32 parentID, Int16 entityID)
        {
            if (parentID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The parentID for the file must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            if (entityID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The entityID for the file must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetFileByParentIdAndEntityID(parentID, entityID);
        }

        [HttpDelete]
        public bool DeleteRecord(File file)
        {
            if (file == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The file must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.DeleteRecord(file);
        }

        [HttpPost]
        public int SaveRecord(File file)
        {
            if (file == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The file must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.SaveRecord(file);
        }
    }
}
