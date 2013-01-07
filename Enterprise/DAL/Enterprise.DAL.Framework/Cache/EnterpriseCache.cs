using System;
using System.Collections;
using Microsoft.Practices.EnterpriseLibrary.Caching;

namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// Adapter for the CacheManager implementation in the Microsoft Enterprise
	/// Application Block.  For the most part, all contractual terms in the
	/// framework are honored, with the exception of a mechanism to retrieve a 
	/// full cache content listing.
	/// </summary>
	/// <author>Michael Roof</author>
	public class EnterpriseCache : ICache
	{
		private CacheManager _manager;
		private EnterpriseCacheConfiguration config;

		public EnterpriseCache( string name )
		{
			config = new EnterpriseCacheConfiguration( name );
		}
		
		/// <summary>
		/// Represents the underlying cache data source in the enterprise
		/// block.  This must be set externally.
		/// </summary>
		public CacheManager CacheManager
		{
			get { return _manager; }
			set { _manager = value; }
		}

		public object Get(object key)
		{
			return _manager.GetData(key.ToString());
		}

		public bool Put(object key, object value)
		{
			Type valueType = null;
			
			if( value is Array )
			{
				var list = (Array) value;
				
				if( list.GetLength(0) > 0 && list.GetValue( 0 ) != null )
				{
					valueType = list.GetValue( 0 ).GetType();
				}
			}
			else if( value is ArrayList )
			{
				var list = (ArrayList) value;

				if( list.Count > 0 && list[0] != null )
				{
					valueType = list[0].GetType();
				}
			}
			else
			{
				valueType = value.GetType();
			}
			
			_manager.Add(key.ToString(), value, CacheItemPriority.Normal, null, config.GetExpirationByType( valueType ) );

			return true;
		}

		public object Peek(object key)
		{
			return Get(key);
		}

		public object Remove(object key)
		{
			object value = Get(key);
			
			_manager.Remove(key.ToString());

			return value;
		}

		/// <summary>
		/// Returns an empty set.  The underlying Microsoft implementation does
		/// not allow the retrieval of all elements in the cache.
		/// </summary>
		/// <returns></returns>
		public IDictionary Entries()
		{
			return new Hashtable();
		}

		public int Size()
		{
			return _manager.Count;
		}

		public void Invalidate()
		{
			_manager.Flush();
		}

		public ICacheConfiguration Configuration
		{
			get { return config; }
		}
	}
}
