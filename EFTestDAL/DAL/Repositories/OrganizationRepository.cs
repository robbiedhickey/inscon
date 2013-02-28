namespace Enterprise.DAL.Repositories
{
    using System;
    using System.Data;
    using System.Linq;

    using Enterprise.DAL.Models;
    using System.Collections.Generic;

    public class OrganizationRepository : IOrganizationRepository
    {
        private EnterpriseDbContext db;
        private bool disposed = false;

        public OrganizationRepository(EnterpriseDbContext context)
        {
            this.db = context;
        }

        public IList<Organization> Get()
        {
            return (from o in db.Organizations select o).ToList();
        }

        public IList<Organization> Get(int typeID)
        {
            return (from o in this.db.Organizations 
                    where o.TypeID.Equals(typeID) 
                    select o).ToList();
        }

        public Organization GetByID(int id)
        {
            return (from o in this.db.Organizations 
                    where o.OrganizationID.Equals(id) 
                    select o).FirstOrDefault();
        }

        public void Insert(Organization organization)
        {
            this.db.Organizations.Add(organization);
        }

        public void Update(Organization organization)
        {
            this.db.Entry(organization).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var org = this.db.Organizations.Find(id);
            this.db.Organizations.Remove(org);
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
