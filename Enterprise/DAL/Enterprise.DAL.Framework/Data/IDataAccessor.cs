using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
	public delegate object Build( ITypeReader reader );
	public delegate T Build<T>( ITypeReader reader );

    public interface IDataAccessor
    {
    	T Find<T>( IDbCommand finder, Build<T> builder );
    	T Find<T>( IDbCommand finder, Build<T> builder, CacheAccessor cacher );
    	List<T> FindAll<T>( IDbCommand finder, Build<T> builder );
    	List<T> FindAll<T>( IDbCommand finder, Build<T> builder, CacheAccessor cacher );
    	Dictionary<K, V> FindAll<K, V>( IDbCommand finder, Build<V> builder, Build<K> keyBuilder );
		Dictionary<K, V> FindAll<K, V>( IDbCommand finder, Build<V> builder, Build<K> keyBuilder, CacheAccessor cacher );
    }
}