using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class RequestService: ServiceBase<Request>
    {

        /// <summary>
        /// Get all Request records
        /// </summary>
        /// <returns></returns>
        public List<Request> GetAllRequests()
        {
            return QueryAll(SqlDatabase, Procedure.Request_SelectAll, Request.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get Request record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Request GetRequestById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<Request> h = h2 => h2.RequestId == id;
                return GetAllRequests().Find(h) ?? new Request();
            }

            return Query(SqlDatabase, Procedure.Request_SelectById, Request.Build, id);
        }
    }
}
