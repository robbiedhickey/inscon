using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface IAssetRepository : ICrudRepository<Asset>
    {
        IList<Asset> GetBy(int organizationID);
    }
}
