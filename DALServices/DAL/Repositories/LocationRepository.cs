using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.DALServices.DAL.Repositories.Interfaces;
using Enterprise.DALServices.DAL.Models;

namespace Enterprise.DALServices.DAL.Repositories
{
    public class LocationRepository : ILocationRepository, IDisposable
    {
        private EnterpriseDbContext context;
        private bool disposed = false;

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

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
