using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface ILocationRepository
    {
        List<Location> GetAllLocations();
        Location GetLocationById(int id);
        List<Location> GetLocationsByOrganizationId(int orgId);
        List<Location> GetLocationsByOrganizationIdandTypeId(Int32 orgId, Int32 typeId);
        void DeleteRecord(Location location);
        int SaveRecord(Location location);
    }
}
