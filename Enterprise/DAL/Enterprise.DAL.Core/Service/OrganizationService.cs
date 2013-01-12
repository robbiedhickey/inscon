using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data.Service;

namespace Enterprise.DAL.Core.Service
{
    public class OrganizationService : IDataService
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
            return DataService.GetDataObjectList<Organization>(_sqlDatabase, Procedure.OrganizationSelect, _cacheMinutesToExpire, _isCached);
        }

        /// <summary>
        /// Get Organization record by ID
        /// </summary>
        /// <param name="idOrganization"></param>
        /// <returns></returns>
        public Organization GetOrganizationById(int idOrganization)
        {
            if (_isCached)
            {
                Predicate<Organization> h = h2 => h2.idOrganization == idOrganization;
                return GetAllOrganizations().Find(h) ?? new Organization();
            }

            return DataService.GetDataObject<Organization>(_sqlDatabase, Procedure.OrganizationSelectById, idOrganization);
        }

        /// <summary>
        /// Get all Organization reocrds by TypeID
        /// </summary>
        /// <param name="idType"></param>
        /// <returns></returns>
        public List<Organization> GetOrganizationsByTypeId(int? idType)
        {
            if (idType == null)
            {
                return GetAllOrganizations();
            }
            if (_isCached)
            {
                Predicate<Organization> d = d2 => d2.idType == idType;
                return GetAllOrganizations().FindAll(d);
            }

            return DataService.GetDataObjectList<Organization>(_sqlDatabase, Procedure.OrganizationSelectByTypeId, _cacheMinutesToExpire, _isCached, idType);
        }
    }
}