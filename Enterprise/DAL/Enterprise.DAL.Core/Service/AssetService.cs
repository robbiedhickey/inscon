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
                    AssetID = reader.GetInt32("AssetID"),
                    OrganizationID = reader.GetInt32("OrganizationID"),
                    TypeID = reader.GetInt32("TypeID"),
                    AssetNumber = reader.GetString("AssetNumber"),
                    LoanNumber = reader.GetString("LoanNumber"),
                    LoanTypeID = reader.GetNullInt32("LoanTypeID"),
                    MortgagorName = reader.GetString("MortgagorName"),
                    MortgagorPhone = reader.GetString("MortgagorPhone"),
                    HudCaseNumber = reader.GetString("HudCaseNumber"),
                    ConveyanceDate = reader.GetNullDate("ConveyanceDate"),
                    FirstTimeVacantDate = reader.GetNullDate("FirstTimeVacantDate")
                    
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
                Predicate<Asset> h = h2 => h2.AssetID == id;
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
                Predicate<Asset> h = h2 => h2.OrganizationID == organizationID;
                return GetAllAssets().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Asset_SelectByOrganizationId, Build, organizationID);
        }

    }
}