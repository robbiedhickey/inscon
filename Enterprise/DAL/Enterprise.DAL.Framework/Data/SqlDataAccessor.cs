// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-27-2013
// ***********************************************************************
// <copyright file="SqlDataAccessor.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Caching;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Class SqlDataAccessor
    /// </summary>
	public class SqlDataAccessor : DataAccessor
	{

        /// <summary>
        /// Queries the reader.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="args">The args.</param>
        /// <returns>ITypeReader.</returns>
		public ITypeReader QueryReader(String database, String procedure, params Object[] args)
		{
			var command = GetCommand(database, procedure, args);
			return FindReader(command);
		}

        /// <summary>
        /// Queries the data set.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="args">The args.</param>
        /// <returns>DataSet.</returns>
	    public DataSet QueryDataSet(string database, string procedure, params object[] args)
        {
            var command = GetCommand(database, procedure, args);
            return FindDataSet(command);

        }

        /// <summary>
        /// Queries the data table.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="args">The args.</param>
        /// <returns>DataTable.</returns>
	    public DataTable QueryDataTable( string database, string procedure, params object[] args)
        {
            var command = GetCommand(database, procedure, args);
            return Find(command);
        }
        /// <summary>
        /// Queries the specified database.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="builder">The builder.</param>
        /// <param name="args">The args.</param>
        /// <returns>``0.</returns>
		protected T Query<T>( string database, string procedure, Build<T> builder, params object[] args )
		{
			var command = GetCommand( database, procedure, args );

			return Find( command, builder);
		}

        /// <summary>
        /// Queries all.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="builder">The builder.</param>
        /// <param name="args">The args.</param>
        /// <returns>List{``0}.</returns>
		protected List<T> QueryAll<T>( string database, string procedure, Build<T> builder, params object[] args )
		{
            var command = args.Length == 0 ? GetCommand(database, procedure) : GetCommand(database, procedure, args);
			return FindAll( command, builder );
		}

        /// <summary>
        /// Queries all.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="builder">The builder.</param>
        /// <param name="cacheMinutesToExpire">The cache minutes to expire.</param>
        /// <param name="isCached">The is cached.</param>
        /// <param name="args">The args.</param>
        /// <returns>List{``0}.</returns>
        protected List<T> QueryAll<T>(string database, string procedure, Build<T> builder, Int32 cacheMinutesToExpire, Boolean isCached, params object[] args)
        {
            var cache = MemoryCache.Default;
            var retval = new List<T>();
            var dataObjectName = typeof(T).Name;

            // Look for object in Cache
            if (isCached)
            {
                if (cache.GetCacheItem(dataObjectName) == null)
                {
                    var policy = new CacheItemPolicy
                    {
                        AbsoluteExpiration = DateTime.Now.AddMinutes(cacheMinutesToExpire)
                    };

                    // Add to cache
                    cache.Add(dataObjectName, QueryAll(database, procedure, builder, args), policy);
                }

                // Read from Cache
                var cacheItem = cache.GetCacheItem(dataObjectName);
                if (cacheItem != null)
                {
                    retval = (List<T>) cacheItem.Value;
                }
            }
            else
            {
                retval = QueryAll(database, procedure, builder, args);
            }

            return retval;
         }

        /// <summary>
        /// Queries all.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="builders">The builders.</param>
        /// <param name="args">The args.</param>
        /// <returns>IList.</returns>
		public IList QueryAll( string database, string procedure, List<Build> builders, params object[] args )
		{
			var command = GetCommand( database, procedure, args );

			return FindAll( command, builders );
		}


        /// <summary>
        /// Queries all.
        /// </summary>
        /// <typeparam name="TK">The type of the TK.</typeparam>
        /// <typeparam name="TV">The type of the TV.</typeparam>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="builder">The builder.</param>
        /// <param name="keyBuilder">The key builder.</param>
        /// <param name="args">The args.</param>
        /// <returns>Dictionary{``0``1}.</returns>
		public Dictionary<TK,TV> QueryAll<TK,TV>( string database, string procedure, Build<TV> builder, Build<TK> keyBuilder, params object[] args )
		{
			var command = GetCommand( database, procedure, args );

			return FindAll( command, builder, keyBuilder );
		}

        /// <summary>
        /// SQLs the context.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <returns>SqlDataContext.</returns>
		public SqlDataContext SqlContext( string database )
		{
			var context = Context as SqlDataContext;

			if( context == null || context.DbName != database )
			{
				Context = context = new SqlDataContext( database );
			}

			return context;
		}

        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="sql">The SQL.</param>
        /// <returns>IDbCommand.</returns>
		public IDbCommand GetCommand( string database, string sql )
		{
			return TimedCommand( SqlContext(database).CreateQuery( sql ) );
		}

        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        /// <param name="args">The args.</param>
        /// <returns>IDbCommand.</returns>
		public IDbCommand GetCommand( string database, string procedure, params object[] args )
		{
			return TimedCommand( SqlContext(database).CreateCommand( procedure, args ) );
		}

        /// <summary>
        /// Times the command.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>IDbCommand.</returns>
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
