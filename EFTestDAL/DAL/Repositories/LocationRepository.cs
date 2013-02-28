namespace Enterprise.DAL.Repositories
{
    using System;
    using System.Data;
    using System.Linq;

    using Enterprise.DAL.Models;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class LocationRepository : ILocationRepository
    {
        private EnterpriseDbContext db;
        private bool disposed = false;

        public LocationRepository(EnterpriseDbContext context)
        {
            this.db = context;
        }

        public IList<Location> Get()
        {
            return (from l in db.Locations
                    select l).ToList();
        }

        public IList<Location> Get(int organizationID)
        {
            return (from l in db.Locations 
                    where l.OrganizationID.Equals(organizationID) 
                    select l).ToList();
        }

        public IList<Location> Get(int organizationID, int typeID)
        {
            return (from l in db.Locations
                    where l.OrganizationID.Equals(organizationID) && 
                          l.TypeID.Equals(typeID)
                    select l).ToList();
        }

        public Location GetByID(int id)
        {
            return (from l in db.Locations 
                    where l.LocationID.Equals(id) 
                    select l).FirstOrDefault();
        }

        public void Insert(Location location)
        {
            var prmOrganizationID = new SqlParameter("@OrganizationID", location.OrganizationID);
            var prmName = new SqlParameter("@Name", location.Name);
            var prmCode = new SqlParameter("@Code", location.Code);
            var prmTypeID = new SqlParameter("@TypeID", location.TypeID);

            db.Database.ExecuteSqlCommand(
                "crud.Location_Insert @OrganizationID @Name @Code @TypeID",
                prmOrganizationID,
                prmName,
                prmCode,
                prmTypeID);
        }

        public void Update(Location location)
        {
            var prmLocationID = new SqlParameter("@LocationID", location.LocationID);
            var prmOrganizationID = new SqlParameter("@OrganizationID", location.OrganizationID);
            var prmName = new SqlParameter("@Name", location.Name);
            var prmCode = new SqlParameter("@Code", location.Code);
            var prmTypeID = new SqlParameter("@TypeID", location.TypeID);

            db.Database.ExecuteSqlCommand(
                "crud.Location_Update @LocationID @OrganizationID @Name @Code @TypeID",
                prmLocationID,
                prmOrganizationID,
                prmName,
                prmCode,
                prmTypeID);
        }

        public void Delete(int id)
        {
            var prmID = new SqlParameter("@LocationID", id);
            db.Database.ExecuteSqlCommand("crud.Location_Delete @LocationID", prmID);
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
