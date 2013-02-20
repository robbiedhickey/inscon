using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IAssetRepository
    {
        List<Asset> GetAllAssets();
        Asset GetAssetById(Int32 id);
        List<Asset> GetAssetByOrganizationID(Int32 organizationId);
        void DeleteRecord(Asset asset);
        int SaveRecord(Asset asset);
    }
}
