using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.DALServices.DAL.Repositories.Interfaces;
using Enterprise.DALServices.DAL.Models;

namespace Enterprise.DALServices.DAL.Repositories
{
    public class AssetRepository : IAssetRepository, IDisposable
    {
        private EnterpriseDbContext context;
        private bool disposed = false;

        public IList<Models.Asset> Get()
        {
            throw new NotImplementedException();
        }

        public IList<Models.Asset> Get(int organizationID)
        {
            throw new NotImplementedException();
        }

        public Models.Asset GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Models.Asset asset)
        {
            throw new NotImplementedException();
        }

        public bool Update(Models.Asset asset)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Models.Asset asset)
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
