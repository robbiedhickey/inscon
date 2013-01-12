using System;
using System.Runtime.Caching;

namespace Enterprise.DAL.Framework.Cache
{
    public static class CacheItem
    {
        public static void Clear<T>()
        {
            Type type = typeof (T);
            string dataObjectName = type.Name;
            MemoryCache cache = MemoryCache.Default;
            System.Runtime.Caching.CacheItem cacheItem = cache.GetCacheItem(dataObjectName);

            // Reset cache if requested and cache exists
            if (cacheItem != null)
            {
                cache.Remove(dataObjectName);
            }
        }
    }
}