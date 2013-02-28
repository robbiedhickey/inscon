namespace Enterprise.DAL.Repositories
{
    using System;
    using System.Collections.Generic;

    using Enterprise.DAL.Models;

    public interface ILocationRepository : IDisposable
    {
        IList<Location> Get();

        Location GetByID(int id);

        IList<Location> Get(int organizationID);

        IList<Location> Get(int organizationID, int typeID); 

        void Insert(Location location);

        void Update(Location location);

        void Delete(int id);

        void Save();
    }
}
