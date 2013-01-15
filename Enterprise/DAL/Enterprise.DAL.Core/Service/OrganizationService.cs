using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class OrganizationService : ServiceBase
    {
        private readonly int _cacheMinutesToExpire;
        private readonly string _sqlDatabase;
        private readonly bool _isCached;

        public OrganizationService()
        {
            _cacheMinutesToExpire = 15;
            _sqlDatabase = Database.EnterpriseDb;
            _isCached = true;
        }

        /// <summary>
        /// Get all Organization records
        /// </summary>
        /// <returns></returns>
        public List<Organization> GetAllOrganizations()
        {
            return QueryAll(_sqlDatabase, Procedure.Organization_SelectAll, Organization.Build, _cacheMinutesToExpire, _isCached);
        }

        /// <summary>
        /// Get Organization record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Organization GetOrganizationById(int id)
        {
            if (_isCached)
            {
                Predicate<Organization> h = h2 => h2.OrganizationID == id;
                return GetAllOrganizations().Find(h) ?? new Organization();
            }

            return Query(_sqlDatabase, Procedure.Organization_SelectById, Organization.Build, _cacheMinutesToExpire, _isCached, id);
        }

        /// <summary>
        /// Get all Organization reocrds by TypeID
        /// </summary>
        /// <param name="typeID"></param>
        /// <returns></returns>
        public List<Organization> GetOrganizationsByTypeId(int? typeID)
        {
            if (typeID == null)
            {
                return GetAllOrganizations();
            }
            if (_isCached)
            {
                Predicate<Organization> d = d2 => d2.TypeID == typeID;
                return GetAllOrganizations().FindAll(d);
            }

            return QueryAll(_sqlDatabase, Procedure.Organization_SelectByTypeId, Organization.Build, _cacheMinutesToExpire, _isCached);
        }
    }
}