namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// An implementation of a factory for simple data caches.  This factory
	/// is not pre-configured; the caches it produces are created on demand.
	/// </summary>
	/// <author>Michael Roof</author>
	public class SimpleCacheFactory : AbstractCacheFactory 
	{
		public static readonly int FactoryDefaultCacheSize = 1000;

	    protected override ICache CreateNewCache(string name) 
		{
			var config = new CacheConfiguration(name);
	        var cache = new SimpleCache(config.GetInt("maxSize", FactoryDefaultCacheSize)) {Configuration = config};


	        return cache;
		}
	}
}
