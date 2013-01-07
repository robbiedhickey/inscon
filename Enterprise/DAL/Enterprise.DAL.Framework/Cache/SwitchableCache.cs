using System.Collections;

namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// A decorator for caches, to implement runtime enabling and disabling of 
	/// caches.
	/// </summary>
	/// <author>Michael Roof</author>
	public class SwitchableCache : ICacheDecorator 
	{
		private readonly ICache _underlyingCache;
		private readonly ICache _nullCache = new NullCache();
		private bool _enabled;
	
		/// <summary>
		/// Construct an instance that enables and disables an implementation cache.
		/// </summary>
		///<param name="cache">the "enabled state" cache</param>
		public SwitchableCache(ICache cache) 
		{
			_underlyingCache = cache;
			_enabled = (cache != null);
		}
	
		public ICache GetCache() 
		{
			return UnderlyingCache();
		}
	
		private ICache CurrentCache() 
		{
			return IsEnabled() ? _underlyingCache : _nullCache;
		}
	
		private ICache UnderlyingCache() 
		{
			return _underlyingCache ?? _nullCache;
		}
	
		public object Get(object key) 
		{
			return CurrentCache().Get(key);
		}

		public bool Put(object key, object value) 
		{
			return CurrentCache().Put(key, value);
		}

		public object Peek(object key) 
		{
			return CurrentCache().Peek(key);
		}

		public object Remove(object key) 
		{
			// Always remove from underlying cache, but pretend this
			// instance is always empty.
			object result = UnderlyingCache().Remove(key);
			return IsEnabled() ? result : null;
		}

		public IDictionary Entries() 
		{
			return UnderlyingCache().Entries();
		}

		public int Size() 
		{
			return UnderlyingCache().Size();
		}

		public void Invalidate() 
		{
			// Always invalidate the underlying cache
			UnderlyingCache().Invalidate();
		}

		public ICacheConfiguration Configuration
		{
			get { return UnderlyingCache().Configuration; }
		}

		public bool IsEnabled() 
		{
			lock(this) 
			{
				return _enabled;
			}
		}

		public void SetEnabled(bool value) 
		{
			lock(this)
			{
				if (_enabled && !value) 
				{
					UnderlyingCache().Invalidate();
				}

				_enabled = value;				
			}
		}
	}
}
