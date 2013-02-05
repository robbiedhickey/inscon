using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.AddressService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Address table.
    /// </summary>
    public class AddressService : IAddressService
    {
        /// <summary>
        /// Gets all address records.
        /// </summary>
        /// <returns>A list of all addresses.</returns>
        public List<Address> GetAllAddressRecords()
        {
            try
            {
                return new dbSvc().GetAllAddressRecords();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the address record by id.
        /// </summary>
        /// <param name="id">The id of the address to retreive.</param>
        /// <returns>The address that matches the id.</returns>
        public Address GetAddressRecordById(int id)
        {
            try
            {
                return new dbSvc().GetAddressRecordById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the address record by parent id and entity ID.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns>A list of address objects.</returns>
        public List<Address> GetRecordByParentIdAndEntityID(int parentID, short entityID)
        {
            try
            {
                return new dbSvc().GetRecordByParentIdAndEntityID(parentID, entityID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the address record.
        /// </summary>
        /// <param name="address">The address to delete.</param>
        public void DeleteRecord(Address address)
        {
            try
            {
                new dbSvc().DeleteRecord(address);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the address record.
        /// </summary>
        /// <param name="address">The address to save.</param>
        /// <returns>The id number of the saved record.</returns>
        public int SaveRecord(Address address)
        {
            try
            {
                return new dbSvc().SaveRecord(address);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
