
using System;
using Enterprise.DAL.Framework.Configuration;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    public class ServiceBase<T> : SqlDataAccessor
    {

        public Int16 CacheMinutesToExpire { get; set; }
        public String SqlDatabase { get; set; }
        public Boolean IsCached { get; set; }
        public String EntityName { get; set; } 


        public ServiceBase()
        {
            var type = typeof(T);

            EntityName = type.Name;
            CacheMinutesToExpire = 15;
            SqlDatabase = Types.Database.EnterpriseDb;
            IsCached = false;
        }

    }
}
