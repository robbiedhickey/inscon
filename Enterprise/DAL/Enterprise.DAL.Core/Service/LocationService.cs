using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class LocationService : ServiceBase<Location>
    {
        /// <summary>
        /// Get all Location records
        /// </summary>
        /// <returns></returns>
        public List<Location> GetAllLocations()
        {
            return QueryAll(SqlDatabase, Procedure.Location_SelectAll, Location.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        ///     Get Location record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Location GetLocationById(int id)
        {
            if (IsCached)
            {
                Predicate<Location> h = h2 => h2.LocationId == id;
                return GetAllLocations().Find(h) ?? new Location();
            }

            return Query(SqlDatabase, Procedure.Address_SelectById, Location.Build, id);
        }

        /// <summary>
        /// Get All locations by Organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <returns></returns>
        public List<Location> GetLocationsByOrganizationId(int orgId)
        {
            if (IsCached)
            {
                Predicate<Location> h = h2 => h2.OrganizationId == orgId;
                return GetAllLocations().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Location_SelectByOrganizationId, Location.Build, orgId);
        }

        /// <summary>
        /// Get All locations by Organization and Type
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public List<Location> GetLocationsByOrganizationIdandTypeId(Int32 orgId, Int32 typeId)
        {
            if (IsCached)
            {
                Predicate<Location> h = h2 => h2.OrganizationId == orgId && h2.TypeId == typeId;
                return GetAllLocations().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Location_SelectByOrganizationIdAndTypeId, Location.Build, orgId,
                            typeId);
        }
    }
}