using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.UserAreaCoverageService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the UserAreaCoverage table.
    /// </summary>
    public class UserAreaCoverageService : IUserAreaCoverageService
    {
        /// <summary>
        /// Gets all user area coverages.
        /// </summary>
        /// <returns>A list of UserAReaCoverage objects.</returns>
        public List<UserAreaCoverage> GetAllUserAreaCoverages()
        {
            try
            {
                return new dbSvc().GetAllUserAreaCoverages();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user area coverage by parent id.
        /// </summary>
        /// <param name="id">The id of the UserAreaCoverage record.</param>
        /// <returns>the UserAReaCoverage object that matches the id.</returns>
        public UserAreaCoverage GetUserAreaCoverageByParentId(int id)
        {
            try
            {
                return new dbSvc().GetUserAreaCoverageByParentId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user area coverage by user idand service id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="serviceId">The service id.</param>
        /// <returns>A list of UserAReaCoverage objects that match the parameter list.</returns>
        public List<UserAreaCoverage> GetUserAreaCoverageByUserIdandServiceId(int userId, int serviceId)
        {
            try
            {
                return new dbSvc().GetUserAreaCoverageByUserIdandServiceId(userId, serviceId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the UserAreaCoverage record.
        /// </summary>
        /// <param name="userAreaCoverage">The user area coverage to delete.</param>
        public void DeleteRecord(UserAreaCoverage userAreaCoverage)
        {
            try
            {
                new dbSvc().DeleteRecord(userAreaCoverage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the UserAreaCoverage record.
        /// </summary>
        /// <param name="userAreaCoverage">The user area coverage to save.</param>
        /// <returns>The id of the saved UserAreaCoverage record.</returns>
        public int SaveRecord(UserAreaCoverage userAreaCoverage)
        {
            try
            {
                return new dbSvc().SaveRecord(userAreaCoverage);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
