using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        IList<Location> Get();
        IList<Location> Get(int organizationID);
        IList<Location> Get(int organizationID, int typeID);
        IList<Location> GetByID(int id);
        bool Insert(Location location);
        bool Update(Location location);
        bool Delete(Location location);
    }
}
