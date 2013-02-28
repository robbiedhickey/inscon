namespace Enterprise.DAL.Repositories
{
    using System;
    using System.Data;
    using System.Linq;

    using Enterprise.DAL.Models;
    using System.Collections.Generic;

    public class AssetRepository : IAssetRepository
    {
        private EnterpriseDbContext db;
        private bool disposed = false;

        public AssetRepository(EnterpriseDbContext context)
        {
            this.db = context;
        }

        public IList<Asset> Get()
        {
            return (from a in db.Assets 
                    select a).ToList();
        }

        public IList<Asset> Get(int organizationID)
        {
            return (from a in db.Assets 
                    where a.OrganizationID.Equals(organizationID) 
                    select a).ToList();
        }

        public Asset GetByID(int id)
        {
            return (from a in db.Assets 
                    where a.AssetID.Equals(id) 
                    select a).FirstOrDefault();
        }

        public void Insert(Asset asset)
        {
            this.db.Assets.Add(asset);
        }

        public void Update(Asset asset)
        {
            this.db.Entry(asset).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var ast = this.db.Assets.Find(id);
            this.db.Assets.Remove(ast);
        }

        public void Save()
        {
            this.db.SaveChanges();
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
