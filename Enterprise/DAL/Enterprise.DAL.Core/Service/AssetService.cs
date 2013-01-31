using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class AssetService
    /// </summary>
    public class AssetService : ServiceBase<Asset>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Asset.</returns>
        public static Asset Build(ITypeReader reader)
        {
            var record = new Asset
                {
                    AssetId = reader.GetInt32("AssetId"),
                    OrganizationId = reader.GetInt32("OrganizationId"),
                    TypeId = reader.GetInt32("TypeId"),
                    LoanId = reader.GetNullInt32("LoanId"),
                    AssetNumber = reader.GetString("AssetNumber")
                };

            return record;
        }

        /// <summary>
        /// Gets all assets.
        /// </summary>
        /// <returns>List{Asset}.</returns>
        public List<Asset> GetAllAssets()
        {
            return QueryAll(SqlDatabase, Procedure.Asset_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }


        /// <summary>
        /// Gets the asset by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Asset.</returns>
        public Asset GetAssetById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<Asset> h = h2 => h2.AssetId == id;
                return GetAllAssets().Find(h) ?? new Asset();
            }

            return Query(SqlDatabase, Procedure.Asset_SelectById, Build, id);
        }


        /// <summary>
        /// Gets the asset by organization ID.
        /// </summary>
        /// <param name="organizationID">The organization ID.</param>
        /// <returns>List{Asset}.</returns>
        public List<Asset> GetAssetByOrganizationID(Int32 organizationID)
        {
            if (IsCached)
            {
                Predicate<Asset> h = h2 => h2.OrganizationId == organizationID;
                return GetAllAssets().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Asset_SelectByOrganizationId, Build, organizationID);
        }

        /// <summary>
        /// Gets the asset by loan ID.
        /// </summary>
        /// <param name="loanID">The loan ID.</param>
        /// <returns>List{Asset}.</returns>
        public List<Asset> GetAssetByLoanID(Int32 loanID)
        {
            if (IsCached)
            {
                Predicate<Asset> h = h2 => h2.LoanId == loanID;
                return GetAllAssets().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Asset_SelectByLoanId, Build, loanID);
        }
    }
}