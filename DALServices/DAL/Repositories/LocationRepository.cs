using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.DALServices.DAL.Repositories.Interfaces;

namespace Enterprise.DALServices.DAL.Repositories
{
    public class LocationRepository : ILocationRepository, IDisposable
    {
        public IList<Models.Location> Get()
        {
            throw new NotImplementedException();
        }

        public IList<Models.Location> Get(int organizationID)
        {
            throw new NotImplementedException();
        }

        public IList<Models.Location> Get(int organizationID, int typeID)
        {
            throw new NotImplementedException();
        }

        public IList<Models.Location> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Models.Location location)
        {
            throw new NotImplementedException();
        }

        public bool Update(Models.Location location)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Models.Location location)
        {
            throw new NotImplementedException();
        }
    }
}
