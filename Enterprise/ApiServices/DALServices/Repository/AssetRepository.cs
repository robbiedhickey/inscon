using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.AssetService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class AssetRepository : IAssetRepository
    {
        public List<Asset> GetAllAssets()
        {
            return new dbSvc().GetAllAssets();
        }

        public Asset GetAssetById(int id)
        {
            return new dbSvc().GetAssetById(id);
        }

        public List<Asset> GetAssetByOrganizationID(int organizationId)
        {
            return new dbSvc().GetAssetByOrganizationID(organizationId);
        }

        public void DeleteRecord(Asset asset)
        {
            new dbSvc().DeleteRecord(asset);
        }

        public int SaveRecord(Asset asset)
        {
            return new dbSvc().SaveRecord(asset);
        }
    }
}