using System;
using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.AddressLocationService;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Service that handles data access for the AddressLocation table.
    /// </summary>
    public class AddressLocationService : IAddressLocationService
    {
        /// <summary>
        /// Gets all addresses location records.
        /// </summary>
        /// <returns>A list of all address location records.</returns>
        public List<AddressLocation> GetAllAddressesLocationRecords()
        {
            try
            {
                return new dbSvc().GetAllAddressesLocationRecords();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the address location by id.
        /// </summary>
        /// <param name="id">The id of the address location to retrieve.</param>
        /// <returns>The record location object that matches the passed in id value.</returns>
        public AddressLocation GetAddressLocationById(int id)
        {
            try
            {
                return new dbSvc().GetAddressLocationById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the address location record.
        /// </summary>
        /// <param name="addressLocation">The address location to delete.</param>
        public void DeleteRecord(AddressLocation addressLocation)
        {
            try
            {
                new dbSvc().DeleteRecord(addressLocation);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Inserts or updates the address location record.
        /// </summary>
        /// <param name="addressLocation">The address location to save.</param>
        /// <returns>The id value of the saved record.</returns>
        public int SaveRecord(AddressLocation addressLocation)
        {
            try
            {
                return new dbSvc().SaveRecord(addressLocation);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
