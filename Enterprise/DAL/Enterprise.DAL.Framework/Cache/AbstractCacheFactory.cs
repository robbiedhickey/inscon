using System.Collections.Generic;

namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// An abstract implementation of the most common behaviors of an ICacheFactory.
	/// This class configures new ICache instances, wraps them in an InstrumentedCache
	/// to collect CacheMetrics, wraps that in a SwitchableCache to allow 
	/// run-time disabling of caches, and associates it with a name it for subsequent 
	/// requests.
	/// Subclasses need only implement a method that allocates a new Cache
	/// instance of the desired class.
	/// <para>
	/// This class IS thread-safe.
	/// </para>
	/// </summary>
	/// <author>Michael Roof</author>
	public abstract class AbstractCacheFactory : ICacheFactory 
	{
		private Dictionary<string, ICache> _caches  = new Dictionary<string, ICache>();
		private Dictionary<string, ICacheMetrics> _metrics = new Dictionary<string, ICacheMetrics>();
		private Dictionary<string, ICacheConfiguration> _configs = new Dictionary<string, ICacheConfiguration>();
	
		public bool HasCache(string name)
		{
			lock(this)
			{
				return _caches.ContainsKey(name);
			}
		}

		public ICache GetCache(string name) 
		{
			lock(this) 
			{
				ICache result = _caches.ContainsKey( name ) ? _caches[name] :  null;

				if( result == null ) 
				{
					ICache rawcache = CreateNewCache(name);
					ICacheConfiguration config = rawcache.Configuration;
					
					if( config.IsInstrumented )
					{
						var metric = new InstrumentedCache(rawcache);

						result = metric;
						_metrics[name] = metric;
					}
					else
					{
						result = rawcache;
						_metrics[name] = new NullCacheMetrics();
					}
					
					if( config.IsSwitchable )
					{
						result = new SwitchableCache( result );
					}
					
					_caches[name] = result;
					_configs[name] = config;
				}

				return result;
			}
		}
	
		/// <summary>
		/// Construct a new instance of an ICache.  It will be entered into the 
		/// map from cache names to cache instances, and wrapped with an 
		/// InstrumentedCache to provide CacheMetrics.
		/// </summary>
		protected abstract ICache CreateNewCache(string name);

		public ICacheConfiguration GetCacheConfiguration( string name )
		{
			lock(this)
			{
				return _configs[name];
			}
		}
		
		public ICacheMetrics GetCacheMetrics(string name)
		{
			lock(this)
			{
				return _metrics[name];
			}
		}

		public string[] GetCacheNames() 
		{
			lock(this) 
			{
				var names = new string[_caches.Count];
				_caches.Keys.CopyTo(names, 0);

				return names;
			}
		}
	}
}
