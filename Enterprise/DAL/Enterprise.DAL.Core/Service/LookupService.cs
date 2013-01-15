using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class LookupService : ServiceBase
    {
        private readonly int _cacheMinutesToExpire;
        private readonly string _sqlDatabase;
        private readonly bool _isCached;

        public LookupService()
        {
            _cacheMinutesToExpire = 15;
            _sqlDatabase = Database.EnterpriseDb;
            _isCached = true;
        }

        /// <summary>
        /// Get All Lookup Values
        /// </summary>
        /// <returns></returns>
        public List<Lookup> GetAllLookups()
        {
            return QueryAll(_sqlDatabase, Procedure.Lookup_SelectAll, Lookup.Build, _cacheMinutesToExpire, _isCached);
        }

        /// <summary>
        /// Get Lookup record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Lookup GetLookupById(Int32 id)
        {
            if (_isCached)
            {
                Predicate<Lookup> h = h2 => h2.LookupID == id;
                return GetAllLookups().Find(h) ?? new Lookup();
            }
            return Query(_sqlDatabase, Procedure.Lookup_SelectById, Lookup.Build, _cacheMinutesToExpire, _isCached, id);
        }

        /// <summary>
        /// Get All Lookup values by GroupID
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public List<Lookup> GetLookupValuesByGroupId(Int16 groupID)
        {
            if (_isCached)
            {
                Predicate<Lookup> l = l2 => l2.LookupGroupID == groupID;
                return GetAllLookups().FindAll(l);
            }

            return QueryAll(_sqlDatabase, Procedure.Lookup_SelectByGroupId, Lookup.Build, _cacheMinutesToExpire, _isCached, groupID);
        }
    }
}