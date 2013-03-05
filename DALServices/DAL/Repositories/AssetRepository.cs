using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.DALServices.DAL.Repositories.Interfaces;
using Enterprise.DALServices.DAL.Models;

namespace Enterprise.DALServices.DAL.Repositories
{
    using System.Data.Entity;

    public class AssetRepository : IAssetRepository, IDisposable
    {
        private EnterpriseDbContext db;
        private bool disposed = false;

        public AssetRepository(EnterpriseDbContext context)
        {
            db = context;
        }

        public IList<Models.Asset> Get()
        {
            return (from x in db.Assets 
                    select x).ToList();
        }

        public IList<Models.Asset> Get(int organizationID)
        {
            if (organizationID < 0)
            {
                return null;
            }
            else
            {
                return (from x in db.Assets 
                        where x.OrganizationID.Equals(organizationID)
                        select x).ToList();
            }
        }

        public Models.Asset GetByID(int id)
        {
            if (id < 0)
            {
                return null;
            }
            else
            {
                return (from x in db.Assets
                        where x.AssetID.Equals(id)
                        select x).FirstOrDefault();
            }
        }

        public void Insert(Models.Asset asset)
        {
            if (asset == null)
            {
                throw new ArgumentNullException("asset", "Parameter may not be null.");
            }

            db.Assets.Add(asset);
        }

        public void Update(Models.Asset asset)
        {
            if (asset == null)
            {
                throw new ArgumentNullException("asset", "Parameter may not be null.");
            }

            db.Entry(asset).State = EntityState.Modified;
        }

        public void Delete(Models.Asset asset)
        {
            if (asset == null)
            {
                throw new ArgumentNullException("asset", "Parameter may not be null.");
            }

            Asset ast = db.Assets.Find(asset.AssetID);
            db.Assets.Remove(ast);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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
