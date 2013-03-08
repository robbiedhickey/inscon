using System.Collections.Generic;
using System.Linq;

using Enterprise.DALServices.DAL.Repositories.Interfaces;
using Enterprise.DALServices.DAL.Models;

namespace Enterprise.DALServices.DAL.Repositories
{
    public class OrganizationRepository : BaseCrudRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository()
            : this(new EfUnitOfWork())
        {

        }

        public OrganizationRepository(IUnitOfWork<EnterpriseDbContext> unitOfWork)
            : base(unitOfWork)
        {
        }

        public IList<Models.Organization> GetBy(int typeID)
        {
            if (typeID < 0)
            {
                return null;
            }
            else
            {
                var orgs = (from o in Context.Organizations 
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

    }
}
