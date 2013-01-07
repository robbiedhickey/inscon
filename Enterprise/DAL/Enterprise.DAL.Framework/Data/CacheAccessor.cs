using System.Collections.Generic;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Cache;

namespace Enterprise.DAL.Framework.Data
{
	/// <summary>
	/// Acts as a bridge for elements cached in a data query; maintains information
	/// about the cache and the key for the element.
	/// </summary>
	/// <author>Fred Fulcher</author>
	public class CacheAccessor
	{
		private string _prefix;
		private string _key;
		private string _name;
		private ICache _cache;

		public CacheAccessor() {}

		/// <summary>
		/// Creates a new accessor for the given cache and element key.
		/// </summary>
		/// <param name="cacheName"></param>
		/// <param name="prefix"></param>
		public CacheAccessor( string cacheName, string prefix ) : this( cacheName, prefix, null ) {}

		public CacheAccessor( string cacheName, string prefix, string key )
		{
			_name = cacheName;
			_prefix = prefix;
			_key = key;

			_cache = CacheLocator.GetCache( cacheName );
		}

		/// <summary>
		/// Invalidates the item in cache referred to by this accessor.
		/// </summary>
		public void Invalidate()
		{
			Invalidate( _prefix );
		}

		/// <summary>
		/// Invalidates a specific item in the cache referred to by this accessor.
		/// </summary>
		/// <param name="key"></param>
		public void Invalidate( string key )
		{
			_cache.Remove( key );
		}

		public bool HasCacheResult()
		{
			return _cache.Get( _prefix ) != null;
		}

		public bool HasCacheResult( string key )
		{
			return _cache.Get( _prefix + key ) != null;
		}

		public T GetCacheResult<T>()
		{
			return (T)_cache.Get( _prefix );
		}

		public void PutCacheResult<T>( string key, T result )
		{
			_cache.Put( key, result );
		}

		public void PutCacheResult<T>( T result )
		{
			_cache.Put( _prefix, result );
		}

		public Dictionary<K, V> GetCacheDictionaryResult<K, V>()
		{
			return _cache.Get( _prefix ) as Dictionary<K, V>;
		}

		public List<T> GetCacheListResult<T>()
		{
			return _cache.Get( _prefix ) as List<T>;
		}

		public void PutCacheListResult<T>( List<T> result )
		{
			_cache.Put( _prefix, result );
		}

		public bool IsValidCacheResult<T>( T result ) where T : class
		{
			return result != null;
		}

		public bool IsValidCacheListResult<T>( List<T> result ) where T : class
		{
			if( result == null )
			{
				return false;
			}

			foreach( T element in result )
			{
				if( element == null )
				{
					return false;
				}
			}

			return true;
		}

		public bool IsGroupCache
		{
			get { return string.IsNullOrEmpty( _key ); }
		}

		/// <summary>
		/// The prefix of the key used to store items in the cache.  Unless
		/// this is a group cache, the prefix is the cache key.
		/// </summary>
		public string Prefix
		{
			get { return _prefix; }
			set { _prefix = value; }
		}

		public string Key
		{
			get { return _key; }
			set { _key = value; }
		}

		/// <summary>
		/// The name of the cache this accessor references
		/// </summary>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public ICache Cache
		{
			get { return _cache; }
			set { _cache = value; }
		}
	}
}