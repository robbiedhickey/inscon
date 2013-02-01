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
    public class LocationService : ILocationService
    {
        public List<Location> GetAllLocations()
        {
            throw new NotImplementedException();
        }

        public Location GetLocationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetLocationsByOrganizationId(int orgId)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetLocationsByOrganizationIdandTypeId(int orgId, int typeId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Location location)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
