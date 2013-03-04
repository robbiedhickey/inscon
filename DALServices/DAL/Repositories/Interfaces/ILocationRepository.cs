using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        IList<Location> Get();
        IList<Location> Get(int organizationID);
        IList<Location> Get(int organizationID, int typeID);
        Location GetByID(int id);
        void Insert(Location location);
        void Update(Location location);
        void Delete(Location location);
        void Save();
    }
}
