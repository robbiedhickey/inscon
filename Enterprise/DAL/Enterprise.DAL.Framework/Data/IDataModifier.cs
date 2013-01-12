using System.Data;

namespace Enterprise.DAL.Framework.Data
{
	public delegate T Convert<out T>( object scalar );

	public interface IDataModifier
	{
		T Execute<T>( IDbCommand executor, Convert<T> converter );
	}
}
