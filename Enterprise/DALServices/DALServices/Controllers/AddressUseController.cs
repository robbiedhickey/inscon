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
    public class AddressUseController : ApiController
    {
        private readonly IAddressUseRepository _repository = new AddressUseRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<AddressUse> GetAllAddressUseRecords()
        {
            return _repository.GetAllAddressUseRecords();
        }

        [HttpGet]
        public AddressUse GetAddressUseById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the address use must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetAddressUseById(id);
        }

        [HttpGet]
        public List<AddressUse> GetAddressUseByAddressId(int addressID)
        {
            if (addressID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The addressID for the address use must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetAddressUseByAddressId(addressID);
        }

        [HttpGet]
        public AddressUse GetAddressUseByAddressIdAndTypeId(int addressID, Int16 typeID)
        {
            if (addressID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The addressID for the address use must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            if (typeID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The typeID for the address use must not be negative.",
                                                             "Negative Value Not Allowed"));
            }
            
            return _repository.GetAddressUseByAddressIdAndTypeId(addressID, typeID);
        }

        [HttpDelete]
        public void DeleteRecord(AddressUse addressUse)
        {
            if (addressUse == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The address use must not be null.",
                                                             "Null Value Not Allowed"));
            }

            _repository.DeleteRecord(addressUse);
        }

        [HttpPost]
        public int SaveRecord(AddressUse addressUse)
        {
            if (addressUse == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The address use must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.SaveRecord(addressUse);
        }
    }
}
