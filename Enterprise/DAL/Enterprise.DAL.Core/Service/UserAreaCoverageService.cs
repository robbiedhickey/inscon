using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class UserAreaCoverageService : ServiceBase<UserAreaCoverage>
    {
        /// <summary>
        /// Get all UserAreaCoverage records
        /// </summary>
        /// <returns></returns>
        public List<UserAreaCoverage> GetAllUserAreaCoverages()
        {
            return QueryAll(SqlDatabase, Procedure.UserAreaCoverage_SelectAll, UserAreaCoverage.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get UserAreaCoverage record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserAreaCoverage GetAddressByParentId(int id)
        {
            if (IsCached)
            {
                Predicate<UserAreaCoverage> h = h2 => h2.UserAreaCoverageId == id;
                return GetAllUserAreaCoverages().Find(h) ?? new UserAreaCoverage();
            }

            return Query(SqlDatabase, Procedure.UserAreaCoverage_SelectById, UserAreaCoverage.Build, id);
        }

        /// <summary>
        /// Get UserAreaCoverage records by UserID and ServiceID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="serviceId"></param>
        /// <returns></returns>
        public List<UserAreaCoverage> GetUserAreaCoverageByUserIdandServiceId(Int32 userId, Int32 serviceId)
        {
            if (IsCached)
            {
                Predicate<UserAreaCoverage> h = h2 => h2.UserId == userId && h2.ServiceId == serviceId;
                return GetAllUserAreaCoverages().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.UserAreaCoverage_SelectByUserIdAndServiceId, UserAreaCoverage.Build, userId, serviceId);
        }
    }
}
