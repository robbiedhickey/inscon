using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface IAssetRepository
    {
        IList<Asset> Get();
        IList<Asset> Get(int organizationID);
        Asset GetByID(int id);
        void Insert(Asset asset);
        void Update(Asset asset);
        void Delete(Asset asset);
        void Save();
    }
}
