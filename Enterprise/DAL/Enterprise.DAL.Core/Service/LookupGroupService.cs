using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class LookupGroupService : ServiceBase<LookupGroup>
    {
       

        public LookupGroupService()
        {
            IsCached = true;
        }

        /// <summary>
        /// Get All LookupGroups
        /// </summary>
        /// <returns></returns>
        public List<LookupGroup> GetAllLookupGroups()
        {
            return QueryAll(SqlDatabase, Procedure.LookupGroup_SelectAll, LookupGroup.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get LookupGroup record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LookupGroup GetLookupGroupById(int id)
        {
            if (IsCached)
            {
                Predicate<LookupGroup> h = h2 => h2.LookupGroupID == id;
                return GetAllLookupGroups().Find(h) ?? new LookupGroup();
            }

            return Query(SqlDatabase, Procedure.LookupGroup_SelectById, LookupGroup.Build, id);
        }
    }
}