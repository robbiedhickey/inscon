using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.LookupService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Lookup table.
    /// </summary>
    public class LookupService : ILookupService
    {
        /// <summary>
        /// Gets all lookups.
        /// </summary>
        /// <returns>A list of lookup objects.</returns>
        public List<Lookup> GetAllLookups()
        {
            try
            {
                return new dbSvc().GetAllLookups();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the lookup by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The lookup that matches the id.</returns>
        public Lookup GetLookupById(int id)
        {
            try
            {
                return new dbSvc().GetLookupById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the lookup values by group id.
        /// </summary>
        /// <param name="groupID">The group ID.</param>
        /// <returns>A list of lookup objects that match the group id.</returns>
        public List<Lookup> GetLookupValuesByGroupId(short groupID)
        {
            try
            {
                return new dbSvc().GetLookupValuesByGroupId(groupID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the lookup record.
        /// </summary>
        /// <param name="lookup">The lookup to delete.</param>
        public void DeleteRecord(Lookup lookup)
        {
            try
            {
                new dbSvc().DeleteRecord(lookup);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the lookup record.
        /// </summary>
        /// <param name="lookup">The lookup to save.</param>
        /// <returns>The id of the saved lookup.</returns>
        public int SaveRecord(Lookup lookup)
        {
            try
            {
                return new dbSvc().SaveRecord(lookup);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
