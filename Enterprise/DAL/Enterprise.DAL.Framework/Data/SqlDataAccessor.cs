using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
	/// <summary>
	/// Implementation of a data accessor for MSSQL, with conveniences for the
	/// client database structure.
	/// </summary>
	/// <author>Fred Fulcher</author>
	public class SqlDataAccessor : DataAccessor
	{
		public ITypeReader QueryReader(String database, String procedure, params Object[] args)
		{
			var command = GetCommand(database, procedure, args);
			return FindReader(command);
		}

	    public DataSet QueryDataSet(string database, string procedure, params object[] args)
        {
            var command = GetCommand(database, procedure, args);
            return FindDataSet(command);

        }

	    public DataTable QueryDataTable( string database, string procedure, params object[] args)
        {
            var command = GetCommand(database, procedure, args);
            return Find(command);
        }
		/// <summary>
		/// Returns a single item of a given type as a result of the invocation of a
		/// stored procedure on the specified database.  Accepts 0 or more parameters.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="database"></param>
		/// <param name="procedure"></param>
		/// <param name="builder"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		protected T Query<T>( string database, string procedure, Build<T> builder, params object[] args )
		{
			var command = GetCommand( database, procedure, args );

			return Find( command, builder);
		}

		/// <summary>
		/// Same as Query, but caches the result.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="database"></param>
		/// <param name="procedure"></param>
		/// <param name="builder"></param>
		/// <param name="cacher"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public T CachedQuery<T>( string database, string procedure, Build<T> builder, CacheAccessor cacher, params object[] args )
		{
			if( cacher.HasCacheResult() )
			{
				return cacher.GetCacheResult<T>();
			}

			var command = GetCommand( database, procedure, args );

			return Find( command, builder, cacher );
		}

		/// <summary>
		/// Returns a list of items of the given type as a result of the invocation
		/// of a stored procedure on the specified database.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="database"></param>
		/// <param name="procedure"></param>
		/// <param name="builder"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		protected List<T> QueryAll<T>( string database, string procedure, Build<T> builder, params object[] args )
		{
            var command = args.Length == 0 ? GetCommand(database, procedure) : GetCommand(database, procedure, args);
			return FindAll( command, builder );
		}

		/// <summary>
		/// Same as QueryAll but cached.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="database"></param>
		/// <param name="procedure"></param>
		/// <param name="builder"></param>
		/// <param name="cacher"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		protected List<T> CachedQueryAll<T>( string database, string procedure, Build<T> builder, CacheAccessor cacher, params object[] args )
		{
			if( cacher.HasCacheResult() )
			{
				return cacher.GetCacheListResult<T>();
			}

			var command = GetCommand( database, procedure, args );

			return FindAll( command, builder, cacher );
		}

		/// <summary>
		/// Executes a stored procedure that returns multiple result sets, applying 
		/// the builders positionally (one builder per result set).
		/// </summary>
		/// <param name="database"></param>
		/// <param name="procedure"></param>
		/// <param name="builders"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public IList QueryAll( string database, string procedure, List<Build> builders, params object[] args )
		{
			var command = GetCommand( database, procedure, args );

			return FindAll( command, builders );
		}

		public IList CachedQueryAll( string database, string procedure, List<Build> builders, CacheAccessor cacher, params object[] args )
		{
			if( cacher.HasCacheResult() )
			{
				return cacher.GetCacheResult<IList>();
			}

			var command = GetCommand( database, procedure, args );

			return FindAll( command, builders, cacher );
		}

		/// <summary>
		/// Returns a dictionary based on the invocation of a stored procedure.
		/// </summary>
		/// <typeparam name="TK"></typeparam>
		/// <typeparam name="TV"></typeparam>
		/// <param name="database"></param>
		/// <param name="procedure"></param>
		/// <param name="builder"></param>
		/// <param name="keyBuilder"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public Dictionary<TK,TV> QueryAll<TK,TV>( string database, string procedure, Build<TV> builder, Build<TK> keyBuilder, params object[] args )
		{
			var command = GetCommand( database, procedure, args );

			return FindAll( command, builder, keyBuilder );
		}

		public Dictionary<TK,TV> CachedQueryAll<TK,TV>( string database, string procedure, Build<TV> builder, Build<TK> keyBuilder, CacheAccessor cacher, params object[] args )
		{
			if( cacher.HasCacheResult() )
			{
				return cacher.GetCacheDictionaryResult<TK,TV>();
			}

			var command = GetCommand( database, procedure, args );

			return FindAll( command, builder, keyBuilder, cacher );
		}

		/// <summary>
		/// Retrieves the appropriate SQL data context for the given database.
		/// </summary>
		/// <param name="database"></param>
		/// <returns></returns>
		protected SqlDataContext SqlContext( string database )
		{
			var context = Context as SqlDataContext;

			if( context == null || context.DbName != database )
			{
				Context = context = new SqlDataContext( database );
			}

			return context;
		}

		/// <summary>
		/// Initializes a new dynamic SQL command against the given database.
		/// </summary>
		/// <param name="database"></param>
		/// <param name="sql"></param>
		/// <returns></returns>
		protected IDbCommand GetCommand( string database, string sql )
		{
			return TimedCommand( SqlContext(database).CreateQuery( sql ) );
		}

		/// <summary>
		/// Initializes a new stored procedure command against the given database.
		/// </summary>
		/// <param name="database"></param>
		/// <param name="procedure"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		protected IDbCommand GetCommand( string database, string procedure, params object[] args )
		{
			return TimedCommand( SqlContext(database).CreateCommand( procedure, args ) );
		}

		protected IDbCommand TimedCommand( IDbCommand command )
		{
			if( Timeout > 0 )
			{
				command.CommandTimeout = Timeout;
			}

			return command;
		}
	}
}
