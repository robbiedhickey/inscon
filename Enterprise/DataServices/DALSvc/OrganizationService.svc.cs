using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.OrganizationService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Organization table.
    /// </summary>
    public class OrganizationService : IOrganizationService
    {
        /// <summary>
        /// Gets all organizations.
        /// </summary>
        /// <returns>A list of organization objects.</returns>
        public List<Organization> GetAllOrganizations()
        {
            try
            {
                return new dbSvc().GetAllOrganizations();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the organization by id.
        /// </summary>
        /// <param name="id">The id of the organization record.</param>
        /// <returns>An organization object that matches the id.</returns>
        public Organization GetOrganizationById(int id)
        {
            try
            {
                return new dbSvc().GetOrganizationById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the organizations by type id.
        /// </summary>
        /// <param name="typeID">The type ID.</param>
        /// <returns>A list of organization objects that match the type id.</returns>
        public List<Organization> GetOrganizationsByTypeId(int? typeID)
        {
            try
            {
                return new dbSvc().GetOrganizationsByTypeId(typeID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the organizaton record.
        /// </summary>
        /// <param name="organization">The organization to delete.</param>
        public void DeleteRecord(Organization organization)
        {
            try
            {
                new dbSvc().DeleteRecord(organization);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the organization record.
        /// </summary>
        /// <param name="organization">The organization to save.</param>
        /// <returns>The id of the saved organization.</returns>
        public int SaveRecord(Organization organization)
        {
            try
            {
                return new dbSvc().SaveRecord(organization);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
