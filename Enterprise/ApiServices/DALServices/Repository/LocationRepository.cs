using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.LocationService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class LocationRepository : ILocationRepository
    {
        public List<Location> GetAllLocations()
        {
            return new dbSvc().GetAllLocations();
        }

        public Location GetLocationById(int id)
        {
            return new dbSvc().GetLocationById(id);
        }

        public List<Location> GetLocationsByOrganizationId(int orgId)
        {
            return new dbSvc().GetLocationsByOrganizationId(orgId);
        }

        public List<Location> GetLocationsByOrganizationIdandTypeId(int orgId, int typeId)
        {
            return new dbSvc().GetLocationsByOrganizationIdandTypeId(orgId, typeId);
        }

        public void DeleteRecord(Location location)
        {
            new dbSvc().DeleteRecord(location);
        }

        public int SaveRecord(Location location)
        {
            return new dbSvc().SaveRecord(location);
        }
    }
}