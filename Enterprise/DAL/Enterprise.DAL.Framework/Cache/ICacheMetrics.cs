namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// A means to expose statistics relevant to generic cache implementations.
	/// Perfect accuracy cannot be guaranteed unless the underlying cache supports
	/// global locking.
	/// </summary>
	/// <author>Michael Roof</author>
	public interface ICacheMetrics
	{
		/// <summary>
		/// Returns the total number of hits and misses, plus retrieval
		/// requests that may have resulted in an exception.  This figure
		/// should not include peeks.
		/// </summary>
		int GetRetrieves();
    
		/// <summary>
		/// Returns the number of successful retrievals from the cache.
		/// Includes peek requests.
		/// </summary>
		int GetHits();
    
		/// <summary>
		/// Returns the number of unsuccessful retrievals from the cache.  In other
		/// words, the number of times a requested key did not have an associated
		/// value in the cache.  Includes peek requests.
		/// </summary>
		int GetMisses();
    
		/// <summary>
		/// Returns the number of peek requests made against the cache.
		/// </summary>
		int GetPeeks();
    
		/// <summary>
		/// Returns the number of insertions into the cache.
		/// </summary>
		int GetPuts();
    
		/// <summary>
		/// Returns the number of explicit removals from the cache.  This
		/// figure will not include elements that are automatically evicted.
		/// </summary>	 
		int GetRemoves();

		/// <summary>
		/// Resets all statistics maintained for the cache, with the exception
		/// of current entry size.		 
		/// </summary>
		void Reset();		
	}
}
