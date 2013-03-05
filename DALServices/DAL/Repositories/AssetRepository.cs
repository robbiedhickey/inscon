using System.Collections.Generic;
using System.Linq;

using Enterprise.DALServices.DAL.Repositories.Interfaces;
using Enterprise.DALServices.DAL.Models;

namespace Enterprise.DALServices.DAL.Repositories
{
    public class AssetRepository : BaseCrudRepository<Asset>, IAssetRepository
    {
        public AssetRepository()
            : this(new EfUnitOfWork())
        {
        }

        public AssetRepository(IUnitOfWork<EnterpriseDbContext> unitOfWork)
            : base(unitOfWork)
        {
        }

        public IList<Models.Asset> GetBy(int organizationID)
        {
            if (organizationID < 0)
            {
                return null;
            }
            else
            {
                return (from x in Context.Assets
                        where x.OrganizationID.Equals(organizationID)
                        select x).ToList();
            }
        }
    }
}
