using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data.Service;

namespace Enterprise.DAL.Core.Service
{
    public class LookupGroupService
    {
        private readonly int _cacheMinutesToExpire;
        private readonly string _sqlDatabase;
        private readonly bool _isCached;

        public LookupGroupService()
        {
            _cacheMinutesToExpire = 15;
            _sqlDatabase = Database.EnterpriseDb;
            _isCached = true;
        }

        /// <summary>
        /// Get All LookupGroups
        /// </summary>
        /// <returns></returns>
        public List<LookupGroup> GetAllLookupGroups()
        {
            return DataService.GetDataObjectList<LookupGroup>(_sqlDatabase, Procedure.LookupGroupSelect, _cacheMinutesToExpire, _isCached);
        }

        /// <summary>
        /// Get LookupGroup record by ID
        /// </summary>
        /// <param name="idLookupGroup"></param>
        /// <returns></returns>
        public LookupGroup GetLookupGroupById(int idLookupGroup)
        {
            if (_isCached)
            {
                Predicate<LookupGroup> h = h2 => h2.idLookupGroup == idLookupGroup;
                return GetAllLookupGroups().Find(h) ?? new LookupGroup();
            }
            return DataService.GetDataObject<LookupGroup>(_sqlDatabase, Procedure.LookupGroupSelectById, idLookupGroup);
        }
    }
}