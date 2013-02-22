// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressController.cs" company="Mortgage Specialist International">
//   Copyright (c) Mortgage Specialist International.  All rights reserved.
// </copyright>
// <summary>
//   Defines the AddressController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Enterprise.ApiServices.DALServices.Controllers
{
    using System.Collections.Generic;
    using System.Net;
    using System.Web.Http;

    using Enterprise.ApiServices.DALServices.Helpers;
    using Enterprise.ApiServices.DALServices.Repository;
    using Enterprise.DAL.Core.Model;

    /// <summary>
    /// Handles all database access to the Address data.
    /// </summary>
    public class AddressController : ApiController
    {
        private readonly IAddressRepository repository = new AddressRepository();
        private readonly ExceptionHelper exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<Address> GetAllAddressRecords()
        {
            return repository.GetAllAddressRecords();
        }

        [HttpGet]
        public Address GetAddressRecordById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    exceptionHelper.BuildHttpResponseMessage(
                        HttpStatusCode.NotAcceptable,
                        "The ID for the address must not be negative.",
                        "Negative Value Not Allowed"));
            }

            return repository.GetAddressRecordById(id);
        }

        [HttpGet]
        public List<Address> GetRecordByParentIdAndEntityId(int parentId, short entityId)
        {
            if (parentId < 0)
            {
                throw new HttpResponseException(
                    exceptionHelper.BuildHttpResponseMessage(
                        HttpStatusCode.NotAcceptable,
                        "The ID for the parent record must not be negative.",
                        "Negative Value Not Allowed"));
            }
            
            if (entityId < 0)
            {
                throw new HttpResponseException(
                    exceptionHelper.BuildHttpResponseMessage(
                        HttpStatusCode.NotAcceptable,
                        "The ID for the entity must not be negative.",
                        "Negative Value Not Allowed"));
            }

            return repository.GetRecordByParentIdAndEntityID(parentId, entityId);
        }

        [HttpDelete]
        public bool DeleteAddress(Address address)
        {
            if (address == null)
            {
                throw new HttpResponseException(
                    exceptionHelper.BuildHttpResponseMessage(
                        HttpStatusCode.NotAcceptable,
                        "The address you are tying to delete must not be null.",
                        "Null Value Not Allowed"));
            }

            return repository.DeleteRecord(address);
        }

        /// <summary> Saves the passed in address to the database. </summary>
        /// <param name="address"> The address to save. </param>
        /// <returns> The ID value for the saved address. </returns>
        /// <exception cref="HttpResponseException">
        /// Throws a custom exception if the address parameter is null.
        /// </exception>
        [HttpPost]
        public int SaveAddress(Address address)
        {
            if (address == null)
            {
                throw new HttpResponseException(
                    exceptionHelper.BuildHttpResponseMessage(
                        HttpStatusCode.NotAcceptable,
                        "The address you are tying to save must not be null.",
                        "Null Value Not Allowed"));
            }

            return repository.SaveRecord(address);
        }
    }
}
