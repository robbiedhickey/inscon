using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
	public delegate object Build( ITypeReader reader );
	public delegate T Build<out T>( ITypeReader reader );

    public interface IDataAccessor
    {
    	T Find<T>( IDbCommand finder, Build<T> builder );
    	List<T> FindAll<T>( IDbCommand finder, Build<T> builder );
    	Dictionary<TK, TV> FindAll<TK, TV>( IDbCommand finder, Build<TV> builder, Build<TK> keyBuilder );
    }
}