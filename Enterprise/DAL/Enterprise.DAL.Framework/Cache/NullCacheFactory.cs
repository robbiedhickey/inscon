namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// Single implementation of a CacheFactory for NullCache instances.
	/// Useful in tests, or when implementing default behaviors.
	/// </summary>
	/// <author>Michael Roof</author>
	public class NullCacheFactory : AbstractCacheFactory 
	{
	    protected override ICache CreateNewCache(string name) 
		{
			return new NullCache();
		}
	}
}
