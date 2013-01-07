namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// Defines the producer interface for caches and their managers.
	/// Cache factories are responsible for lifecycle management of
	/// their constituent caches.
	/// 
	/// TODO: Extend a configurable interface
	/// </summary>
	/// <author>Michael Roof</author>
	public interface ICacheFactory
	{
		/// <summary>
		/// Determines whether this factory supports the cache associated
		/// with the given identifier.
		/// </summary>
		/// <param name="name">The identifier of the cache to check</param>
		/// <returns></returns>
		bool HasCache(string name);

		/// <summary>
		/// Retrieves the cache associated with the given identifier.
		/// </summary>
		/// <param name="name">The identifier of the cache to retrieve</param>
		/// <returns>An initialized and perhaps populated cache</returns>
		ICache GetCache(string name);
    
		/// <summary>
		/// Retrieves the metrics associated with the cache with the given name. 
		/// </summary>
		/// <param name="name">The identifier of the cache</param>
		/// <returns>Current metrics for the named cache</returns>
		ICacheMetrics GetCacheMetrics(string name);
    
		/// <summary>
		/// Retrieves the list of caches maintained by this factory.
		/// Implementations may provide a complete list, or a snapshot
		/// if new caches may be added dynamically.
		/// </summary>
		/// <returns>The current list of caches</returns>
		string[] GetCacheNames();		
	}
}