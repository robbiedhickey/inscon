using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.UserContactService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to UserContact table.
    /// </summary>
    public class UserContactService : IUserContactService
    {
        /// <summary>
        /// Gets all user contacts.
        /// </summary>
        /// <returns>A list of UserContact objects.</returns>
        public List<UserContact> GetAllUserContacts()
        {
            try
            {
                return new dbSvc().GetAllUserContacts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user contact by id.
        /// </summary>
        /// <param name="id">The id of he UserContact.</param>
        /// <returns>The UserContact object that matches the id.</returns>
        public UserContact GetUserContactById(int id)
        {
            try
            {
                return new dbSvc().GetUserContactById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user contacts by user id.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <returns>A list of UserContact objects that match the user id.</returns>
        public List<UserContact> GetUserContactsByUserId(int userID)
        {
            try
            {
                return new dbSvc().GetUserContactsByUserId(userID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the user contacts by user id and type id.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="typeId">The type id.</param>
        /// <returns>A list of UserContact objects that match the parameter list.</returns>
        public List<UserContact> GetUserContactsByUserIdAndTypeId(int userID, int typeId)
        {
            try
            {
                return new dbSvc().GetUserContactsByUserIdAndTypeId(userID, typeId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the UserContact record.
        /// </summary>
        /// <param name="userContact">The user contact to delete.</param>
        public void DeleteRecord(UserContact userContact)
        {
            try
            {
                new dbSvc().DeleteRecord(userContact);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the UserContact record.
        /// </summary>
        /// <param name="userContact">The user contact to save.</param>
        /// <returns>The id of the saved user contact.</returns>
        public int SaveRecord(UserContact userContact)
        {
            try
            {
                return new dbSvc().SaveRecord(userContact);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
