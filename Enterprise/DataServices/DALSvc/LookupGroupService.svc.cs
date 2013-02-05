using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.LookupGroupService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the LookupGroup table.
    /// </summary>
    public class LookupGroupService : ILookupGroupService
    {
        /// <summary>
        /// Gets all lookup groups.
        /// </summary>
        /// <returns>A list of lookup group objects.</returns>
        public List<LookupGroup> GetAllLookupGroups()
        {
            try
            {
                return new dbSvc().GetAllLookupGroups();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the lookup group by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The lookup group that matches the id.</returns>
        public LookupGroup GetLookupGroupById(int id)
        {
            try
            {
                return new dbSvc().GetLookupGroupById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the lookupo group record.
        /// </summary>
        /// <param name="lookupGroup">The lookup group to delete.</param>
        public void DeleteRecord(LookupGroup lookupGroup)
        {
            try
            {
                new dbSvc().DeleteRecord(lookupGroup);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the lookup group record.
        /// </summary>
        /// <param name="lookupGroup">The lookup group to save.</param>
        /// <returns>The id of the saved lookup grouop.</returns>
        public int SaveRecord(LookupGroup lookupGroup)
        {
            try
            {
                return new dbSvc().SaveRecord(lookupGroup);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
