// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressLocationController.cs" company="Mortgage Specialist International">
//   Copyright (c) Mortgage Specialist International.  All rights reserved.
// </copyright>
// <summary>
//   Defines the AddressLocationController type.
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
    /// Handles all database action to the AddressLocation.
    /// </summary>
    public class AddressLocationController : ApiController
    {
        private readonly IAddressLocationRepository repository = new AddressLocationRepository();
        private readonly ExceptionHelper exceptionHelper = new ExceptionHelper();

        /// <summary>
        /// Gets all AddressLocation records.
        /// </summary>
        /// <returns>A list of type AddressLocation.</returns>
        [HttpGet]
        public List<AddressLocation> GetAllAddressesLocationRecords()
        {
            return repository.GetAllAddressesLocationRecords();
        }

        /// <summary>
        /// Gets the address location by its id value.
        /// </summary>
        /// <param name="id">The id of the AddressLocation.</param>
        /// <returns>
        /// The AddressLocation that corresponds to the id parameter.
        /// </returns>
        /// <exception cref="System.Web.Http.HttpResponseException">
        /// Throws a custom exception if the addressLocation parameter is negative.
        /// </exception>
        [HttpGet]
        public AddressLocation GetAddressLocationById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    exceptionHelper.BuildHttpResponseMessage(
                        HttpStatusCode.NotAcceptable,
                        "The ID for the address location must not be negative.",
                        "Negative Value Not Allowed"));
            }

            return repository.GetAddressLocationById(id);
        }

        /// <summary>
        /// Deletes the AddressLocation from the database.
        /// </summary>
        /// <param name="addressLocation">The address location to delete.</param>
        /// <returns>
        /// True if the delete is successful, otherwise, false is returned.
        /// </returns>
        /// <exception cref="System.Web.Http.HttpResponseException">
        /// Throws a custom exception if the addressLocation parameter is null.
        /// </exception>
        [HttpDelete]
        public bool DeleteRecord(AddressLocation addressLocation)
        {
            if (addressLocation == null)
            {
                throw new HttpResponseException(
                    exceptionHelper.BuildHttpResponseMessage(
                        HttpStatusCode.NotAcceptable,
                        "The address location must not be null.",
                        "Null Value Not Allowed"));
            }

            return repository.DeleteRecord(addressLocation);
        }

        /// <summary>
        /// Saves the passed in AddressLocation to the database.
        /// </summary>
        /// <param name="addressLocation">The address location to save.</param>
        /// <returns>
        /// The id of the saved record.
        /// </returns>
        /// <exception cref="System.Web.Http.HttpResponseException">
        /// Throws a custom exception if the addressLocation parameter is null.
        /// </exception>
        [HttpPost]
        public int SaveRecord(AddressLocation addressLocation)
        {
            if (addressLocation == null)
            {
                throw new HttpResponseException(
                    exceptionHelper.BuildHttpResponseMessage(
                        HttpStatusCode.NotAcceptable,
                        "The address location must not be null.",
                        "Null Value Not Allowed"));
            }

            return repository.SaveRecord(addressLocation);
        }
    }
}
