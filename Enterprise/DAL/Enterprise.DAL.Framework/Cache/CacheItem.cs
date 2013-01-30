// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="CacheItem.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.Caching;

namespace Enterprise.DAL.Framework.Cache
{
    /// <summary>
    /// Class CacheItem
    /// </summary>
    public static class CacheItem
    {
        /// <summary>
        /// Clears this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
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