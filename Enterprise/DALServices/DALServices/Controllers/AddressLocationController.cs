using Enterprise.ApiServices.DALServices.Helpers;
using Enterprise.ApiServices.DALServices.Repository;
using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;


namespace Enterprise.ApiServices.DALServices.Controllers
{
    public class AddressLocationController : ApiController
    {
        private readonly IAddressLocationRepository _repository = new AddressLocationRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<AddressLocation> GetAllAddressesLocationRecords()
        {
            return _repository.GetAllAddressesLocationRecords();
        }

        [HttpGet]
        public AddressLocation GetAddressLocationById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the address location must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetAddressLocationById(id);
        }

        [HttpDelete]
        public bool DeleteRecord(AddressLocation addressLocation)
        {
            if (addressLocation == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The address location must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.DeleteRecord(addressLocation);
        }

        [HttpPost]
        public int SaveRecord(AddressLocation addressLocation)
        {
            if (addressLocation == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The address location must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.SaveRecord(addressLocation);
        }
    }
}
