using System;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;

namespace Enterprise.DAL.Framework.Cache
{
    /// <summary>
    ///     Holds expiration policy information for types stored in an enterprise
    ///     cache.  Keys in App.config or Web.config are of the form:
    ///     cacheName.expiration._default
    ///     cacheName.expiration.TypeName1
    ///     cacheName.expiration.TypeName2
    ///     With values that represent the time, in hours, that elements of the
    ///     given type (or default for the cache) should live.  If there is no
    ///     default, this class is configured for a TTL of 8 hours.
    /// </summary>
    /// <author>Michael Roof</author>
    public class EnterpriseCacheConfiguration : CacheConfiguration
    {
        public static readonly TimeSpan DefaultTime = new TimeSpan(8, 0, 0);

        private readonly Dictionary<string, TimeSpan> _expiries;
        private TimeSpan _defaultExpiration = DefaultTime;

        public EnterpriseCacheConfiguration(string name) : base(name)
        {
            _expiries = new Dictionary<string, TimeSpan>();

            SetConfiguration();
        }

        private void SetConfiguration()
        {
            const string prefix = "expiration.";

            foreach (var kvp in Config)
            {
                if (kvp.Key.StartsWith(prefix))
                {
                    var type = kvp.Key.Substring(prefix.Length);
                    var expireTime = GetInt(kvp.Key, 8);

                    if (type == "_default")
                    {
                        _defaultExpiration = new TimeSpan(expireTime, 0, 0);
                    }
                    else
                    {
                        _expiries[type] = new TimeSpan(expireTime, 0, 0);
                    }
                }
            }
        }

        /// <summary>
        ///     Retrieves an expiration policy configured for the given type name,
        ///     or a sliding time represented by this class's default TTL.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ICacheItemExpiration GetExpirationByType(Type type)
        {
            if (type == null || ! _expiries.ContainsKey(type.Name))
            {
                return new AbsoluteTime(_defaultExpiration);
            }

            return new AbsoluteTime(_expiries[type.Name]);
        }
    }
}