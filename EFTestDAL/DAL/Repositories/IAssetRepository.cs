namespace Enterprise.DAL.Repositories
{
    using System;
    using System.Collections.Generic;

    using Enterprise.DAL.Models;

    public interface IAssetRepository : IDisposable
    {
        IList<Asset> Get();

        IList<Asset> Get(int organizationID);

        Asset GetByID(int id);

        void Insert(Asset asset);

        void Update(Asset asset);

        void Delete(int id);

        void Save();
    }
}
