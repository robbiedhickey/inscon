using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class UserService : ServiceBase<User>
    {

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return QueryAll(SqlDatabase, Procedure.User_SelectAll, User.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get User record by ID
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public User GetUserById(int idUser)
        {
            if (IsCached)
            {
                Predicate<User> h = h2 => h2.UserID == idUser;
                return GetAllUsers().Find(h) ?? new User();
            }
            return Query(SqlDatabase, Procedure.User_SelectById, User.Build, idUser);
        }

        /// <summary>
        /// Get User records by OrganizationId
        /// </summary>
        /// <param name="idOrganization"></param>
        /// <returns></returns>
        public List<User> GetUsersByOrganizationId(int idOrganization)
        {
            if (IsCached)
            {
                Predicate<User> h = h2 => h2.OrganizationID == idOrganization;
                return GetAllUsers().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.User_SelectByOrganizationId, User.Build, idOrganization);
        }

        /// <summary>
        /// Get User records by OrganizationId and IsActive
        /// </summary>
        /// <param name="idOrganization"></param>
        /// <param name="idStatus"></param>
        /// <returns></returns>
        public List<User> GetUsersByOrganizationIdAndIsActive(int idOrganization, int idStatus)
        {
            if (IsCached)
            {
                Predicate<User> h = h2 => h2.OrganizationID == idOrganization && h2.StatusID == idStatus;
                return GetAllUsers().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.User_SelectByOrganizationIdAndStatusId, User.Build, idOrganization, idStatus);
        }

    }
}
