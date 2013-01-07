using System.Collections.Generic;
using log4net;

namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// The AggregateCacheFactory serves as a clearinghouse of registered factories
	/// in the runtime system.  It maps individual cache names to factory types,
	/// which themselves hold references to extant caches.  Note that this implies
	/// cache names are unique among all factories.
	/// </summary>
	/// <author>Michael Roof</author>
	public class AggregateCacheFactory : ICacheFactory 
	{
		private static readonly ILog Log = LogManager.GetLogger(typeof(AggregateCacheFactory));

		private readonly Dictionary<string, ICacheFactory> _factories = new Dictionary<string, ICacheFactory>();
		private ICacheFactory _defaultFactory;

		public ICacheFactory DefaultFactory
		{
			get { return _defaultFactory; }
			set { _defaultFactory = value; }
		}

		public ICache GetCache(string name) 
		{
			lock(this)
			{
				ICacheFactory factory = FactoryForCacheName(name);

				return factory.GetCache(name);
			}
		}

		private ICacheFactory FactoryForCacheName(string name)
		{
			return _factories.ContainsKey( name ) ? _factories[name] : AttemptFactoryCreation( name );
		}

		private ICacheFactory AttemptFactoryCreation(string name)
		{
			ICacheFactory factory = CacheFactoryCreator.Create( name );

			_factories[name] = factory ?? DefaultFactory;

			if( factory == null )
			{
				Log.InfoFormat( "Using DefaultFactory of type {0} for cache {1}", DefaultFactory.GetType().FullName, name );
			}

			return _factories[name];
		}

		/// <summary>
		/// Because this factory loads caches in real-time, it is not possible to
		/// know in advance if a given cache exists.  Rather than produce a "maybe"
		/// value, this method always returns true.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool HasCache(string name)
		{
			return true;
		}

		public ICacheMetrics GetCacheMetrics(string name)
		{
			lock(this)
			{
				return FactoryForCacheName(name).GetCacheMetrics(name);	
			}
		}

		/// <summary>
		/// Returns the names of all caches managed by all factories stored
		/// in this aggregation.
		/// </summary>
		/// <returns></returns>
		public string[] GetCacheNames()
		{
			lock(this) 
			{
				string[] defaults = DefaultFactory.GetCacheNames();
				var names = new string[_factories.Count + defaults.Length];

				defaults.CopyTo(names, 0);
			
				if (_factories.Count > 0)
				{
					_factories.Keys.CopyTo(names, defaults.Length);
				}

				return names;
			}
		}
	}
}
