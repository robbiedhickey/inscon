using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IAssetService
    {
        [OperationContract]
        List<Asset> GetAllAssets();

        [OperationContract]
        Asset GetAssetById(Int32 id);

        [OperationContract]
        List<Asset> GetAssetByOrganizationID(Int32 organizationID);

        [OperationContract]
        List<Asset> GetAssetByLoanID(Int32 loanID);

        [OperationContract]
        void DeleteRecord(Asset asset);

        [OperationContract]
        int SaveRecord(Asset asset);
    }
}
