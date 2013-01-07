namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// A decorator for other Cache instances.  Caches which simply add behavior to an
	/// underlying Cache representation should implement this interface.
	/// </summary>
	/// <author>Michael Roof</author>
	public interface ICacheDecorator : ICache
	{
		/// <summary>
		/// Gets the underlying cache instance
		/// </summary>
		/// <returns></returns>
		ICache GetCache();
	}
}
