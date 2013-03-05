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

    public class LocationRepository : ILocationRepository, IDisposable
    {
        private EnterpriseDbContext db;
        private bool disposed = false;

        public LocationRepository(EnterpriseDbContext context)
        {
            db = context;
        }

        public IList<Models.Location> Get()
        {
            return (from x in db.Locations 
                select x).ToList();
        }

        public IList<Models.Location> Get(int organizationID)
        {
            if (organizationID < 0)
            {
                return null;
            }
            else
            {
                return (from x in db.Locations
                        where x.OrganizationID.Equals(organizationID)
                        select x).ToList();
            }
        }

        public IList<Models.Location> Get(int organizationID, int typeID)
        {
            if (organizationID < 0)
            {
                return null;
            }
            else if (typeID < 0)
            {
                return null;
            }
            else
            {
                return (from x in db.Locations
                        where x.OrganizationID.Equals(organizationID) && 
                              x.TypeID.Equals(typeID)
                        select x).ToList();
            }
        }

        public Models.Location GetByID(int id)
        {
            if (id < 0)
            {
                return null;
            }
            else
            {
                return (from x in db.Locations 
                        where x.LocationID.Equals(id) 
                        select x).FirstOrDefault();
            }
        }

        public void Insert(Models.Location location)
        {
            if (location == null)
            {
                throw new ArgumentNullException("location", "Parameter may not be null.");
            }

            db.Locations.Add(location);
        }

        public void Update(Models.Location location)
        {
            if (location == null)
            {
                throw new ArgumentNullException("location", "Parameter may not be null.");
            }

            db.Entry(location).State = EntityState.Modified;
        }

        public void Delete(Models.Location location)
        {
            if (location == null)
            {
                throw new ArgumentNullException("location", "Parameter may not be null.");
            }

            Location loc = db.Locations.Find(location.LocationID);
            db.Locations.Remove(loc);

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
