// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="SqlDataContext.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Transactions;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Enterprise.DAL.Framework.Configuration;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Implementation of a data context for MSSQL.  This class relies on the Microsoft
    /// Enterprise Data Application Block.
    /// </summary>
    public class SqlDataContext : IDataContext
    {
        /// <summary>
        /// The _DB name
        /// </summary>
    	private readonly string _dbName;
        /// <summary>
        /// The _DB
        /// </summary>
        private readonly Database _db;
        /// <summary>
        /// The _query limit
        /// </summary>
        private readonly int _queryLimit;
        /// <summary>
        /// The _use query limit
        /// </summary>
        private bool _useQueryLimit;
        /// <summary>
        /// The _SQL timeout
        /// </summary>
        private int _sqlTimeout;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDataContext"/> class.
        /// </summary>
        /// <param name="database">The database.</param>
        public SqlDataContext( string database )
        {
        	_dbName = database;
            _db = DatabaseFactory.CreateDatabase( database );

            _sqlTimeout = ConfigurationUtils.GetConfigInt("framework.sql.timeout", 30);
            _queryLimit = ConfigurationUtils.GetConfigInt("framework.sql.queryLimit");
        }

        /// <summary>
        /// Gets the name of the db.
        /// </summary>
        /// <value>The name of the db.</value>
    	public string DbName
    	{
    		get { return _dbName; }
    	}

        /// <summary>
        /// Gets or sets a value indicating whether [use query limit].
        /// </summary>
        /// <value><c>true</c> if [use query limit]; otherwise, <c>false</c>.</value>
        public bool UseQueryLimit
        {
            get { return _useQueryLimit; }
            set { _useQueryLimit = value; }
        }

        /// <summary>
        /// Gets or sets the SQL timeout.
        /// </summary>
        /// <value>The SQL timeout.</value>
    	public int SqlTimeout
    	{
    		get { return _sqlTimeout; }
    		set { _sqlTimeout = value; }
    	}

        /// <summary>
        /// Executes a reader, optionally applying a query limit if the context
        /// has one defined.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>IDataReader.</returns>
    	public IDataReader ExecuteReader(IDbCommand command)
        {
            if( _useQueryLimit )
            {
                _db.AddInParameter((DbCommand)command, "@queryLimit", DbType.Int32, _queryLimit );
            }

            return _db.ExecuteReader((DbCommand)command);
        }

        /// <summary>
        /// Creates the query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>IDbCommand.</returns>
		public IDbCommand CreateQuery( string query )
		{
			IDbCommand command = _db.GetSqlStringCommand( query );
			command.CommandTimeout = _sqlTimeout;

			return command;
		}

        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="sproc">The sproc.</param>
        /// <returns>IDbCommand.</returns>
        public IDbCommand CreateCommand( string sproc )
        {
            IDbCommand command = _db.GetStoredProcCommand(sproc);
            command.CommandTimeout = _sqlTimeout;

            return command;
        }

        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="sproc">The sproc.</param>
        /// <param name="args">The args.</param>
        /// <returns>IDbCommand.</returns>
        public IDbCommand CreateCommand(string sproc, params object[] args)
        {
            IDbCommand command = _db.GetStoredProcCommand(sproc, args);
            command.CommandTimeout = _sqlTimeout;

            return command;
        }

        /// <summary>
        /// Adds the in parameter.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="name">The name.</param>
        /// <param name="dbType">Type of the db.</param>
        /// <param name="value">The value.</param>
        public void AddInParameter(IDbCommand command, string name, DbType dbType, object value)
        {
            _db.AddInParameter((DbCommand)command, name, dbType, value);
        }

        /// <summary>
        /// Adds the out parameter.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="name">The name.</param>
        /// <param name="dbType">Type of the db.</param>
        /// <param name="size">The size.</param>
        public void AddOutParameter(IDbCommand command, string name, DbType dbType, int size)
        {
            _db.AddOutParameter((DbCommand)command, name, dbType, size);
        }

        /// <summary>
        /// Gets the parameter.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="name">The name.</param>
        /// <returns>System.Object.</returns>
		public object GetParameter( IDbCommand command, string name )
		{
			return _db.GetParameterValue( (DbCommand) command, name );
		}

        /// <summary>
        /// Executes the data set.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>DataSet.</returns>
        public DataSet ExecuteDataSet(IDbCommand command)
        {
            return _db.ExecuteDataSet((DbCommand) command);
        }

        /// <summary>
        /// Executes the scalar.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>System.Object.</returns>
        public object ExecuteScalar(IDbCommand command)
        {
            return _db.ExecuteScalar((DbCommand) command);
        }

        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>System.Int32.</returns>
        public int ExecuteNonQuery(IDbCommand command)
        {
            return _db.ExecuteNonQuery((DbCommand) command);
        }

        /// <summary>
        /// Executes all the given commands in a single connection-scoped transaction.
        /// </summary>
        /// <param name="commands">The commands.</param>
        public void ExecuteNonQuery(List<IDbCommand> commands)
        {
            using( var scope = new TransactionScope(TransactionScopeOption.RequiresNew) )
            {
                foreach( var command in commands )
                {
                    _db.ExecuteNonQuery((DbCommand) command);
                }

                scope.Complete();
            }
        }
    }
}
