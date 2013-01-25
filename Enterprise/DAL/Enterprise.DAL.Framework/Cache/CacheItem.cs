using System.Runtime.Caching;

namespace Enterprise.DAL.Framework.Cache
{
    public static class CacheItem
    {
        public static void Clear<T>()
        {
            var type = typeof (T);
            var dataObjectName = type.Name;
            var cache = MemoryCache.Default;
            var cacheItem = cache.GetCacheItem(dataObjectName);

            // Reset cache if requested and cache exists
            if (cacheItem != null)
            {
                cache.Remove(dataObjectName);
            }
        }
    }
}