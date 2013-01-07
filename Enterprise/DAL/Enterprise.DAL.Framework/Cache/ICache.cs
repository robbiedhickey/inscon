using System.Collections;

namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// A cache is a general-purpose data structure, usually implemented as
	/// an elaborate Map, that holds a collection of elements in a key/value
	/// fashion.
	/// 
	/// TODO: This should extend a configurable-type interface to allow change notification
	/// </summary>
	/// <author>Michael Roof</author>
	public interface ICache
	{
		/// <summary>
		/// Retrieves the object referenced by the given key.  If not
		/// available, should return null.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		object Get(object key);
    
		/// <summary>
		/// Stores the given object under the given key.  This operation
		/// may fail if the key does not conform to rules specified in
		/// the underlying imlementation.  It should certainly fail if
		/// the key is null, and will likely fail if the value is null.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns>
		/// The status of the operation, if failure does not result
		/// in an exception.
		/// </returns>
		bool Put(object key, object value);

		/// <summary>
		/// Retrieves an object from this cache without recording the
		/// act of retrieval.  Useful to prevent monitored entries from
		/// escaping eviction.  By and large, if the key does not 
		/// exist, a null value should be returned. 
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		object Peek(object key);

		/// <summary>
		/// Removes an entry from this cache.  In the event the entry does
		/// not exist, no action will occur.
		/// </summary>
		/// <param name="key">The key of the entry to remove</param>
		/// <returns>The value of the entry removed (if successful)</returns>
		object Remove(object key); 

		/// <summary>
		/// Retrieves a snapshot of all entries in this cache.  Useful for
		/// debugging purposes but may not be implemented by all caches, especially
		/// those that maintain large amounts of data.
		/// </summary>
		/// <returns>The cached collection of data.</returns>
		IDictionary Entries();
    
		/// <summary>
		/// Returns the current size of the cache, as a reflection of the number
		/// of entries.
		/// </summary>
		/// <returns>The number of elements in the cache</returns>
		int Size();

		/// <summary>
		/// Marks all elements in this cache as invalid, with the effect of
		/// clearing its contents.  Clients may assume that gets for elements
		/// previously in the cache will fail immediately after this call.
		/// Whether the entries are physically removed at the time of the operation
		/// is at the discretion of the implementation.
		/// </summary>
		void Invalidate();
		
		ICacheConfiguration Configuration { get; }
	}
}
