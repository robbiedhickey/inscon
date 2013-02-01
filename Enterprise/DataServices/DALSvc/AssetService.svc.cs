using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.AssetService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class AssetService : IAssetService
    {
        public List<Asset> GetAllAssets()
        {
            throw new NotImplementedException();
        }

        public Asset GetAssetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Asset> GetAssetByOrganizationID(int organizationID)
        {
            throw new NotImplementedException();
        }

        public List<Asset> GetAssetByLoanID(int loanID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Asset asset)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}
