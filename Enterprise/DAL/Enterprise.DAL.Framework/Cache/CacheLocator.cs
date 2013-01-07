namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// Registry of caches produced by a configured set of factories.
	/// </summary>
	/// <author>Michael Roof</author>
	public class CacheLocator
	{   
		private static CacheLocator __instance = new CacheLocator();

		private ICacheFactory _registry;
    
		private CacheLocator()
		{
		    var registry = new AggregateCacheFactory {DefaultFactory = new SimpleCacheFactory()};


		    _registry = registry;
		}

		/// <summary>
		/// Default singleton instance of a CacheLocator.
		/// Implementations can create other instances, but this is the "official"
		/// instance, used in static methods of this class.
		/// </summary>
		/// <returns></returns>
		public static CacheLocator Instance 
		{
			get { return __instance; }
		}

		/// <summary>
		/// Get a named cache from the root CacheFactory of the singleton instance.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static ICache GetCache(string name) 
		{
			/*
			* IMPORTANT!!!  DO NOT ADD CODE TO THIS METHOD.
			* This method should always be a convenience wrapper for a VERY FEW
			* method calls on the singleton instance of CacheLocator.
			* [Ideally: (get instance).(get root factory).(get cache by name)]
			* If you must extend the default behavior of CacheLocator, do it
			* in an instance method.
			*/
			return Instance.Registry.GetCache(name);
		}

		public ICacheFactory Registry
		{
			get { return _registry; }
		}
	}
}
