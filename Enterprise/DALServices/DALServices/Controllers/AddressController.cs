using Enterprise.ApiServices.DALServices.Helpers;
using Enterprise.ApiServices.DALServices.Repository;
using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace Enterprise.ApiServices.DALServices.Controllers
{
    public class AddressController : ApiController
    {
        private readonly IAddressRepository _repository = new AddressRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<Address> GetAllAddressRecords()
        {
            return _repository.GetAllAddressRecords();
        }

        [HttpGet]
        public Address GetAddressRecordById(int id)
        {
            if(id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the address must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetAddressRecordById(id);
        }

        [HttpGet]
        public List<Address> GetRecordByParentIdAndEntityID(int parentId, Int16 entityId)
        {
            if (parentId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the parent record must not be negative.",
                                                             "Negative Value Not Allowed"));
            }
            
            if (entityId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the entity must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetRecordByParentIdAndEntityID(parentId, entityId);
        }

        [HttpDelete]
        public void DeleteAddress(Address address)
        {
            if (address == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The address you are tying to delete must not be null.",
                                                             "Null Value Not Allowed"));
            }

            _repository.DeleteRecord(address);
        }

        [HttpPost]
        public int SaveAddress(Address address)
        {
            if (address == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The address you are tying to save must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.SaveRecord(address);
        }
    }
}
