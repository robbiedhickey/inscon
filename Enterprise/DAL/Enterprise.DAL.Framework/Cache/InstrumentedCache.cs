using System.Collections;
using System.Threading;

namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// This class is a decorator for caches, which facilitates the capture
	/// of statistical information.
	/// </summary>
	/// <author>Michael Roof</author>
	public class InstrumentedCache : ICacheDecorator, ICacheMetrics
	{
		private ICache _cache;
    
		private Statistic _retrieve = new Statistic();
		private Statistic _get      = new Statistic();
		private Statistic _hit      = new Statistic();
		private Statistic _miss     = new Statistic();
		private Statistic _peek     = new Statistic();
		private Statistic _put      = new Statistic();
		private Statistic _remove   = new Statistic();
    
		/// <summary>
		/// Creates a new instrumented cache from the provided cache. 
		/// </summary>
		/// <param name="cache">The cache to decorate</param>
		public InstrumentedCache(ICache cache) 
		{
			_cache = cache;
			Reset();
		}
        
		public IDictionary Entries() 
		{
			_retrieve.Increment();
			_hit.Increment();
			
			return _cache.Entries();
		}
    
		public int Size() 
		{
			return _cache.Size();
		}
    
		public object Get(object key) 
		{
			_retrieve.Increment();

			object value = _cache.Get(key);
        
			if (null == value)
			{
				_miss.Increment();
			} 
			else 
			{
				_hit.Increment();
			}

			return value;
		}

		public void Invalidate() 
		{
			_cache.Invalidate();
		}

		public object Peek(object key) 
		{
			_peek.Increment();
        
			return _cache.Peek(key);
		}

		public bool Put(object key, object value) 
		{
			_put.Increment();
        
			return _cache.Put(key, value);
		}

		public object Remove(object key) 
		{
			_remove.Increment();
        
			return _cache.Remove(key);
		}

		/// <summary>
		/// Returns the total number of retrieval requests made against
		/// this cache, excluding peeks.
		/// </summary>
		public int GetRetrieves() 
		{
			return _retrieve.GetValue();
		}

		/// <summary>
		/// Returns the number of successful retrievals from this cache.
		/// Does not include objects retrieved via the peek operation.
		/// </summary>
		public int GetHits() 
		{
			return _hit.GetValue(); 
		}

		/// <summary>
		/// Returns the number of retrieval attempts that did not result
		/// in a hit against this cache.  Does not include misses from
		/// the peek operation.
		/// </summary>
		public int GetMisses() 
		{
			return _miss.GetValue();
		}

		/// <summary>
		/// Returns the number of peeks requested of this cache.
		/// The total value is independent of whether the peeks
		/// succeeded or failed.
		/// </summary>
		public int GetPeeks() 
		{
			return _peek.GetValue();
		}

		/// <summary>
		/// Returns the number of stores requested of this cache.
		/// The total value is independent of whether the stores 
		/// succeeded or failed.
		/// </summary>
		public int GetPuts() 
		{
			return _put.GetValue();
		}

		/// <summary>
		/// Returns the number of removals requested of this cache.
		/// </summary>
		public int GetRemoves() 
		{
			return _remove.GetValue();
		}

		/// <summary>
		/// Resets statistical counts for this cache.  To better promote
		/// concurrency, neither the cache nor the metrics are globally locked 
		/// during this operation.  While each count will be internally consistent,
		/// it is possible for a client to see one value in a reset state
		/// and another that has not yet been reset.
		/// </summary>
		public void Reset() 
		{
			_retrieve.Reset();
			_get.Reset();
			_hit.Reset();
			_miss.Reset();
			_put.Reset();
			_peek.Reset();
			_remove.Reset();
		}
    
		/// <summary>
		/// Returns a handle to the decorated cache.  Use of this method
		/// is discouraged, however, as operating upon the underlying cache 
		/// will compromise the statistics captured by the decorator.
		/// </summary>
		public ICache GetCache() 
		{
			return _cache;
		}

		public ICacheConfiguration Configuration
		{
			get { return _cache.Configuration; }
		}
	}

	/// <summary>
	/// Represents a simple, thread-safe counter. 
	/// </summary>
	internal class Statistic 
	{
		private int _value;
        
		public Statistic() 
		{
			_value = 0;
		}
        
		public void Increment() 
		{
			Interlocked.Increment(ref _value);
		}
        
		public void Reset() 
		{
			Interlocked.Exchange(ref _value, 0);
		}
        
		public int GetValue() 
		{
			return Interlocked.Exchange(ref _value, _value);
		}
	}
}
