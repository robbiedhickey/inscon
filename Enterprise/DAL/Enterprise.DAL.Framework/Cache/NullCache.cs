using System.Collections;

namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// A "null object" implementation of Cache, that stores nothing.
	/// </summary> 
	/// <author>Michael Roof</author>
	public class NullCache : ICache
	{
		public object Get(object arg0) 
		{
			return null;
		}

		public bool Put(object arg0, object arg1) 
		{
			return true;
		}

		public object Peek(object arg0) 
		{
			return null;
		}

		public object Remove(object arg0) 
		{
			return null;
		}

		/// <summary>
		/// Unlike the other methods here, this will return an empty 
		/// collection rather than a null value.
		/// </summary>
		/// <returns></returns>
		public IDictionary Entries() 
		{
			return new Hashtable();
		}

		public int Size() 
		{
			return 0;
		}

		public void Invalidate() 
		{
		}
		
		public ICacheConfiguration Configuration
		{
			get { return new CacheConfiguration(); }
		}		
	}
}
