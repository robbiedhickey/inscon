using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Class SqlDataExecutor
    /// </summary>
	public class SqlDataExecutor : SqlDataAccessor, IDataModifier
	{
        /// <summary>
        /// Executes the specified executor.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="executor">The executor.</param>
        /// <param name="converter">The converter.</param>
        /// <returns>``0.</returns>
		public T Execute<T>( IDbCommand executor, Convert<T> converter )
		{
			return converter( Context.ExecuteScalar( executor ) );
		}

        /// <summary>
        /// Executes the specified db.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="db">The db.</param>
        /// <param name="sproc">The sproc.</param>
        /// <param name="converter">The converter.</param>
        /// <param name="args">The args.</param>
        /// <returns>``0.</returns>
		public T Execute<T>( string db, string sproc, Convert<T> converter, params object[] args )
		{
			return Execute( GetCommand( db, sproc, args ), converter );
		}

        /// <summary>
        /// Executes the specified db.
        /// </summary>
        /// <param name="db">The db.</param>
        /// <param name="sproc">The sproc.</param>
        /// <param name="args">The args.</param>
		public void Execute( string db, string sproc, params object[] args )
		{
			SqlContext(db).ExecuteNonQuery( GetCommand( db, sproc, args ) );
		}

        /// <summary>
        /// Executes the specified executor.
        /// </summary>
        /// <param name="executor">The executor.</param>
		public void Execute( IDbCommand executor )
		{
			Context.ExecuteNonQuery( executor );
		}

        /// <summary>
        /// Executes the specified commands.
        /// </summary>
        /// <param name="commands">The commands.</param>
		public void Execute( List<IDbCommand> commands )
		{
			if( commands != null && commands.Count > 0 )
			{
				Context.ExecuteNonQuery( commands );
			}
		}
	}
}
