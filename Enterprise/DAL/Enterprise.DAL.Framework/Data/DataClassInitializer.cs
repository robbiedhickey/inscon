using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Caching;


namespace Enterprise.DAL.Framework.Data
{
    public static class DataClassInitializer
    {
        public static List<T> MapDataObjectCollection<T>(IDataReader reader, int minutesToExpire, bool isCached = false)
        {
            var type = typeof (T);
            var dataObjectName = type.Name;
            var cache = MemoryCache.Default;
            var list = new List<T>();

            while (reader.Read())
            {
                var obj = DataHelper.CreateObject<T>(reader);
                var commit = obj.GetType().GetMethod("CommitChanges");

                if (commit != null)
                {
                    commit.Invoke(obj, null);
                }

                list.Add(obj);
            }

            reader.Close();

            // Write object to cache
            if (isCached)
            {
                var policy = new CacheItemPolicy {AbsoluteExpiration = DateTime.Now.AddMinutes(minutesToExpire)};
                cache.Add(dataObjectName, list, policy);
            }

            return list;
        }

        public static T MapDataObject<T>(IDataReader reader) where T : new()
        {
            var myObject = new T();
            while (reader.Read())
            {
                myObject = DataHelper.CreateObject<T>(reader);   
            }

            reader.Close();

            return myObject;
        }
    }
}