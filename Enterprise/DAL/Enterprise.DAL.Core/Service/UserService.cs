using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data.Service;

namespace Enterprise.DAL.Core.Service
{
    public class UserService : IDataService
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
            return DataService.GetDataObjectList<User>(_sqlDatabase, Procedure.UserSelect, _cacheMinutesToExpire, _isCached);
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
                Predicate<User> h = h2 => h2.idUser == idUser;
                return GetAllUsers().Find(h) ?? new User();
            }
            return DataService.GetDataObject<User>(_sqlDatabase, Procedure.UserSelectById, idUser);
        }

        /// <summary>
        /// Get User records by OrganizationId
        /// </summary>
        /// <param name="idOrganization"></param>
        /// <returns></returns>
        public List<User> GetUserByOrganizationId(int idOrganization)
        {
            if (_isCached)
            {
                Predicate<User> h = h2 => h2.idOrganization == idOrganization;
                return GetAllUsers().FindAll(h);
            }
            return DataService.GetDataObjectList<User>(_sqlDatabase, Procedure.UserSelectByOrganizationId, _cacheMinutesToExpire, _isCached, idOrganization);
        }

        /// <summary>
        /// Get User records by OrganizationId and IsActive
        /// </summary>
        /// <param name="idOrganization"></param>
        /// <param name="idStatus"></param>
        /// <returns></returns>
        public List<User> GetUserByOrganizationIdAndIsActive(int idOrganization, int idStatus)
        {
            if (_isCached)
            {
                Predicate<User> h = h2 => h2.idOrganization == idOrganization && h2.idStatus == idStatus;
                return GetAllUsers().FindAll(h);
            }
            return DataService.GetDataObjectList<User>(_sqlDatabase, Procedure.UserSelectByOrganizationIdAndIsActive, _cacheMinutesToExpire, _isCached, idOrganization, idStatus);
        }

    }
}
