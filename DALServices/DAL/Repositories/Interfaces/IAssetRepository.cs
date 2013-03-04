using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface IAssetRepository
    {
        IList<Asset> Get();
        IList<Asset> Get(int organizationID);
        Asset GetByID(int id);
        bool Insert(Asset asset);
        bool Update(Asset asset);
        bool Delete(Asset asset);
    }
}
