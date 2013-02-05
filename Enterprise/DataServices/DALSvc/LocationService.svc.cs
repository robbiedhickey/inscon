using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.LocationService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Location table.
    /// </summary>
    public class LocationService : ILocationService
    {
        /// <summary>
        /// Gets all locations.
        /// </summary>
        /// <returns>A list of location objects.</returns>
        public List<Location> GetAllLocations()
        {
            try
            {
                return new dbSvc().GetAllLocations();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the location by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The location that matches the id.</returns>
        public Location GetLocationById(int id)
        {
            try
            {
                return new dbSvc().GetLocationById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the locations by organization id.
        /// </summary>
        /// <param name="orgId">The org id of the location.</param>
        /// <returns>A list of location objects that match the ordId.</returns>
        public List<Location> GetLocationsByOrganizationId(int orgId)
        {
            try
            {
                return new dbSvc().GetLocationsByOrganizationId(orgId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the locations by organization idand type id.
        /// </summary>
        /// <param name="orgId">The org id of the location.</param>
        /// <param name="typeId">The type id of the location.</param>
        /// <returns>A list of location objects that match the parameter list.</returns>
        public List<Location> GetLocationsByOrganizationIdandTypeId(int orgId, int typeId)
        {
            try
            {
                return new dbSvc().GetLocationsByOrganizationIdandTypeId(orgId, typeId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the location record.
        /// </summary>
        /// <param name="location">The location to delete.</param>
        public void DeleteRecord(Location location)
        {
            try
            {
                new dbSvc().DeleteRecord(location);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the location record.
        /// </summary>
        /// <param name="location">The location to save.</param>
        /// <returns>The id of the saved location.</returns>
        public int SaveRecord(Location location)
        {
            try
            {
                return new dbSvc().SaveRecord(location);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
