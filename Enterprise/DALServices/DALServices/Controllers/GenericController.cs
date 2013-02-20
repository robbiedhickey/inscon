using Enterprise.ApiServices.DALServices.Helpers;
using Enterprise.ApiServices.DALServices.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Enterprise.ApiServices.DALServices.Controllers
{
    public class GenericController : ApiController
    {
        private readonly IGenericRepository _repository = new GenericRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpPost]
        public void RunProc(string database, string procedure)
        {
            if (string.IsNullOrEmpty(database))
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The database must not be null or an empty string.",
                                                             "Null or Empty Value Not Allowed"));
            }

            if (string.IsNullOrEmpty(procedure))
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The procedure name must not be null or an empty string.",
                                                             "Null or Empty Value Not Allowed"));
            }

            _repository.RunProc(database, procedure);
        }

        [HttpGet]
        public DataTable GetDataTable(string database, string storedProcedure, params object[] parameters)
        {
            if (string.IsNullOrEmpty(database))
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The database must not be null or an empty string.",
                                                             "Null or Empty Value Not Allowed"));
            }

            if (string.IsNullOrEmpty(storedProcedure))
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The storedProcedure must not be null or an empty string.",
                                                             "Null or Empty Value Not Allowed"));
            }

            if (parameters == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The parameters must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.GetDataTable(database, storedProcedure, parameters);
        }

        [HttpGet]
        public DataSet GetDataSet(string database, string storedProcedure, params object[] parameters)
        {
            if (string.IsNullOrEmpty(database))
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The database must not be null or an empty string.",
                                                             "Null or Empty Value Not Allowed"));
            }

            if (string.IsNullOrEmpty(storedProcedure))
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The storedProcedure must not be null or an empty string.",
                                                             "Null or Empty Value Not Allowed"));
            }

            if (parameters == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The parameters must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.GetDataSet(database, storedProcedure, parameters);
        }

        [HttpGet]
        public IDataReader GetDataReader(string database, string storedProcedure, params object[] parameters)
        {
            if (string.IsNullOrEmpty(database))
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The database must not be null or an empty string.",
                                                             "Null or Empty Value Not Allowed"));
            }

            if (string.IsNullOrEmpty(storedProcedure))
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The storedProcedure must not be null or an empty string.",
                                                             "Null or Empty Value Not Allowed"));
            }

            if (parameters == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The parameters must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.GetDataReader(database, storedProcedure, parameters);
        }
    }
}
