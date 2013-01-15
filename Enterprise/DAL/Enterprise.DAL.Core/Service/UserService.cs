using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class UserService : ServiceBase
    {

        private readonly int _cacheMinutesToExpire;
        private readonly string _sqlDatabase;
        private readonly bool _isCached;

        public UserService()
        {
            _cacheMinutesToExpire = 0;
            _sqlDatabase = Database.EnterpriseDb;
            _isCached = false;
        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return QueryAll(_sqlDatabase, Procedure.User_SelectAll, User.Build, _cacheMinutesToExpire, _isCached);
        }

        /// <summary>
        /// Get User record by ID
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public User GetUserById(int idUser)
        {
            if (_isCached)
            {
                Predicate<User> h = h2 => h2.UserID == idUser;
                return GetAllUsers().Find(h) ?? new User();
            }
            return Query(_sqlDatabase, Procedure.User_SelectById, User.Build, _cacheMinutesToExpire, _isCached, idUser);
        }

        /// <summary>
        /// Get User records by OrganizationId
        /// </summary>
        /// <param name="idOrganization"></param>
        /// <returns></returns>
        public List<User> GetUsersByOrganizationId(int idOrganization)
        {
            if (_isCached)
            {
                Predicate<User> h = h2 => h2.OrganizationID == idOrganization;
                return GetAllUsers().FindAll(h);
            }

            return QueryAll(_sqlDatabase, Procedure.User_SelectByOrganizationId, User.Build, _cacheMinutesToExpire, _isCached, idOrganization);
        }

        /// <summary>
        /// Get User records by OrganizationId and IsActive
        /// </summary>
        /// <param name="idOrganization"></param>
        /// <param name="idStatus"></param>
        /// <returns></returns>
        public List<User> GetUsersByOrganizationIdAndIsActive(int idOrganization, int idStatus)
        {
            if (_isCached)
            {
                Predicate<User> h = h2 => h2.OrganizationID == idOrganization && h2.StatusID == idStatus;
                return GetAllUsers().FindAll(h);
            }

            return QueryAll(_sqlDatabase, Procedure.User_SelectByOrganizationIdAndStatusId, User.Build, _cacheMinutesToExpire, _isCached, idOrganization, idStatus);
        }

    }
}
