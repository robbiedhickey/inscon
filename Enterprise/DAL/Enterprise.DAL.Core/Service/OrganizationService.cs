using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class OrganizationService : ServiceBase<Organization>
    {
        

        public OrganizationService()
        {
            IsCached = true;

        }

        /// <summary>
        /// Get all Organization records
        /// </summary>
        /// <returns></returns>
        public List<Organization> GetAllOrganizations()
        {
            return QueryAll(SqlDatabase, Procedure.Organization_SelectAll, Organization.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get Organization record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Organization GetOrganizationById(int id)
        {
            if (IsCached)
            {
                Predicate<Organization> h = h2 => h2.OrganizationID == id;
                return GetAllOrganizations().Find(h) ?? new Organization();
            }

            return Query(SqlDatabase, Procedure.Organization_SelectById, Organization.Build, id);
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
            if (IsCached)
            {
                Predicate<Organization> d = d2 => d2.TypeID == typeID;
                return GetAllOrganizations().FindAll(d);
            }

            return QueryAll(SqlDatabase, Procedure.Organization_SelectByTypeId, Organization.Build, typeID);
        }
    }
}