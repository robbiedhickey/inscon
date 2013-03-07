using System.Collections.Generic;
using System.Linq;

using Enterprise.DALServices.DAL.Repositories.Interfaces;
using Enterprise.DALServices.DAL.Models;

namespace Enterprise.DALServices.DAL.Repositories
{
    public class LocationRepository : CrudRepository<Location>, ILocationRepository
    {
        public LocationRepository()
            : this(new EfUnitOfWork())
        {
            
        }

        public LocationRepository(IUnitOfWork<EnterpriseDbContext> unitOfWork)
            : base(unitOfWork)
        {
        }

        public IList<Models.Location> GetBy(int organizationID)
        {
            if (organizationID < 0)
            {
                return null;
            }
            else
            {
                var locs = (from x in Context.Locations
                            where x.OrganizationID.Equals(organizationID)
                            select x).ToList();

                if (locs.Count.Equals(0))
                {
                    return null;
                }
                else
                {
                    return locs;
                }
            }
        }

        public IList<Models.Location> GetBy(int organizationID, int typeID)
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
                var locs = (from x in Context.Locations
                            where x.OrganizationID.Equals(organizationID) && 
                                  x.TypeID.Equals(typeID)
                            select x).ToList();

                if (locs.Count.Equals(0))
                {
                    return null;
                }
                else
                {
                    return locs;
                }
            }
        }
    }
}
