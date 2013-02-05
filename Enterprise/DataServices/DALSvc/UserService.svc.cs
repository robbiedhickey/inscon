using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.UserService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the User table.
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns>A list of User objecs.</returns>
        public List<User> GetAllUsers()
        {
            try
            {
                return new dbSvc().GetAllUsers();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user by id.
        /// </summary>
        /// <param name="idUser">The id user.</param>
        /// <returns>The User objec that matches the idUser.</returns>
        public User GetUserById(int idUser)
        {
            try
            {
                return new dbSvc().GetUserById(idUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the users by organization id.
        /// </summary>
        /// <param name="idOrganization">The id organization.</param>
        /// <returns>A list of User objecs that match the organization id.</returns>
        public List<User> GetUsersByOrganizationId(int idOrganization)
        {
            try
            {
                return new dbSvc().GetUsersByOrganizationId(idOrganization);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the users by organization id and is active.
        /// </summary>
        /// <param name="idOrganization">The id organization.</param>
        /// <param name="idStatus">The id status.</param>
        /// <returns>A list of User objecs that matches the parameter list.</returns>
        public List<User> GetUsersByOrganizationIdAndIsActive(int idOrganization, int idStatus)
        {
            try
            {
                return new dbSvc().GetUsersByOrganizationIdAndIsActive(idOrganization, idStatus);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the User record.
        /// </summary>
        /// <param name="user">The user to delete.</param>
        public void DeleteRecord(User user)
        {
            try
            {
                new dbSvc().DeleteRecord(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the User record.
        /// </summary>
        /// <param name="user">The user to save.</param>
        /// <returns>The id of the saved user record.</returns>
        public int SaveRecord(User user)
        {
            try
            {
                return new dbSvc().SaveRecord(user);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
