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
    /// <summary>
    /// Handles access for the Asset table.
    /// </summary>
    public class AssetService : IAssetService
    {
        /// <summary>
        /// Gets all assets.
        /// </summary>
        /// <returns>A list of all asset objects.</returns>
        public List<Asset> GetAllAssets()
        {
            try
            {
                return new dbSvc().GetAllAssets();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the asset by id.
        /// </summary>
        /// <param name="id">The id of the asset to return.</param>
        /// <returns>The asset that matches the id.</returns>
        public Asset GetAssetById(int id)
        {
            try
            {
                return new dbSvc().GetAssetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the asset by organization ID.
        /// </summary>
        /// <param name="organizationID">The organization ID.</param>
        /// <returns>A list of all assets that match the OrganizationID.</returns>
        public List<Asset> GetAssetByOrganizationID(int organizationID)
        {
            try
            {
                return new dbSvc().GetAssetByOrganizationID(organizationID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the asset by loan ID.
        /// </summary>
        /// <param name="loanID">The loan ID.</param>
        /// <returns>A list of all assets that match the LoanID.</returns>
        public List<Asset> GetAssetByLoanID(int loanID)
        {
            try
            {
                return new dbSvc().GetAssetByLoanID(loanID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the asset record.
        /// </summary>
        /// <param name="asset">The asset.</param>
        public void DeleteRecord(Asset asset)
        {
            try
            {
                new dbSvc().DeleteRecord(asset);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the asset record.
        /// </summary>
        /// <param name="asset">The asset.</param>
        /// <returns>The id of the saved asset.</returns>
        public int SaveRecord(Asset asset)
        {
            try
            {
                return new dbSvc().SaveRecord(asset);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
