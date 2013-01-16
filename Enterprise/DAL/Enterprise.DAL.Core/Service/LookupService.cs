using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class LookupService : ServiceBase<Lookup>
    {
      
        public LookupService()
        {
            IsCached = true;
        }

        /// <summary>
        /// Get All Lookup Values
        /// </summary>
        /// <returns></returns>
        public List<Lookup> GetAllLookups()
        {
            return QueryAll(SqlDatabase, Procedure.Lookup_SelectAll, Lookup.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get Lookup record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Lookup GetLookupById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<Lookup> h = h2 => h2.LookupID == id;
                return GetAllLookups().Find(h) ?? new Lookup();
            }
            return Query(SqlDatabase, Procedure.Lookup_SelectById, Lookup.Build, CacheMinutesToExpire, IsCached, id);
        }

        /// <summary>
        /// Get All Lookup values by GroupID
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public List<Lookup> GetLookupValuesByGroupId(Int16 groupID)
        {
            if (IsCached)
            {
                Predicate<Lookup> l = l2 => l2.LookupGroupID == groupID;
                return GetAllLookups().FindAll(l);
            }

            return QueryAll(SqlDatabase, Procedure.Lookup_SelectByGroupId, Lookup.Build, CacheMinutesToExpire, IsCached, groupID);
        }
    }
}