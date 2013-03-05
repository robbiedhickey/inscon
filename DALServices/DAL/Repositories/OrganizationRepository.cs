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
    using System.Data.SqlClient;

    public class OrganizationRepository : IOrganizationRepository, IDisposable
    {
        private EnterpriseDbContext db;
        private bool disposed = false;

        public OrganizationRepository(EnterpriseDbContext context)
        {
            db = context;
        }

        public IList<Models.Organization> Get()
        {
            var orgs = (from o in db.Organizations 
                        select o).ToList();

            if (orgs.Count.Equals(0))
            {
                return null;
            }
            else
            {
                return orgs;
            }
        }

        public IList<Models.Organization> Get(int typeID)
        {
            if (typeID < 0)
            {
                return null;
            }
            else
            {
                var orgs = (from o in db.Organizations 
                            where o.TypeID.Equals(typeID) 
                            select o).ToList();

                if (orgs.Count.Equals(0))
                {
                    return null;
                }
                else
                {
                    return orgs;
                }
            }
        }

        public Models.Organization GetByID(int id)
        {
            if (id < 0)
            {
                return null;
            }
            else
            {
                return (from o in db.Organizations 
                        where o.OrganizationID.Equals(id) 
                        select o).FirstOrDefault();
            }
        }

        public void Insert(Models.Organization organization)
        {
            if (organization == null)
            {
                throw new ArgumentNullException("organization", "Parameter may not be null.");
            }

            db.Organizations.Add(organization);
        }

        public void Update(Models.Organization organization)
        {
            if (organization == null)
            {
                throw new ArgumentNullException("organization", "Parameter may not be null.");
            }

            db.Entry(organization).State = EntityState.Modified;
        }

        public void Delete(Models.Organization organization)
        {
            if (organization == null)
            {
                throw new ArgumentNullException("organization", "Parameter may not be null.");
            }

            Organization org = db.Organizations.Find(organization.OrganizationID);
            db.Organizations.Remove(org);
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
