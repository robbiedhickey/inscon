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
    	private readonly string _dbName;
        private readonly Database _db;
        private readonly int _queryLimit;
        private bool _useQueryLimit;
        private int _sqlTimeout;

        public SqlDataContext( string database )
        {
        	_dbName = database;
            _db = DatabaseFactory.CreateDatabase( database );

            _sqlTimeout = ConfigurationUtils.GetConfigInt("framework.sql.timeout", 30);
            _queryLimit = ConfigurationUtils.GetConfigInt("framework.sql.queryLimit");
        }

    	public string DbName
    	{
    		get { return _dbName; }
    	}

        public bool UseQueryLimit
        {
            get { return _useQueryLimit; }
            set { _useQueryLimit = value; }
        }

    	public int SqlTimeout
    	{
    		get { return _sqlTimeout; }
    		set { _sqlTimeout = value; }
    	}

		/// <summary>
		/// Executes a reader, optionally applying a query limit if the context
		/// has one defined.
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
    	public IDataReader ExecuteReader(IDbCommand command)
        {
            if( _useQueryLimit )
            {
                _db.AddInParameter((DbCommand)command, "@queryLimit", DbType.Int32, _queryLimit );
            }

            return _db.ExecuteReader((DbCommand)command);
        }

		public IDbCommand CreateQuery( string query )
		{
			IDbCommand command = _db.GetSqlStringCommand( query );
			command.CommandTimeout = _sqlTimeout;

			return command;
		}

        public IDbCommand CreateCommand( string sproc )
        {
            IDbCommand command = _db.GetStoredProcCommand(sproc);
            command.CommandTimeout = _sqlTimeout;

            return command;
        }

        public IDbCommand CreateCommand(string sproc, params object[] args)
        {
            IDbCommand command = _db.GetStoredProcCommand(sproc, args);
            command.CommandTimeout = _sqlTimeout;

            return command;
        }

        public void AddInParameter(IDbCommand command, string name, DbType dbType, object value)
        {
            _db.AddInParameter((DbCommand)command, name, dbType, value);
        }

        public void AddOutParameter(IDbCommand command, string name, DbType dbType, int size)
        {
            _db.AddOutParameter((DbCommand)command, name, dbType, size);
        }

		public object GetParameter( IDbCommand command, string name )
		{
			return _db.GetParameterValue( (DbCommand) command, name );
		}

        public DataSet ExecuteDataSet(IDbCommand command)
        {
            return _db.ExecuteDataSet((DbCommand) command);
        }

        public object ExecuteScalar(IDbCommand command)
        {
            return _db.ExecuteScalar((DbCommand) command);
        }

        public int ExecuteNonQuery(IDbCommand command)
        {
            return _db.ExecuteNonQuery((DbCommand) command);
        }

		/// <summary>
		/// Executes all the given commands in a single connection-scoped transaction.
		/// </summary>
		/// <param name="commands"></param>
        public void ExecuteNonQuery(List<IDbCommand> commands)
        {
            using( var scope = new TransactionScope(TransactionScopeOption.RequiresNew) )
            {
                foreach( IDbCommand command in commands )
                {
                    _db.ExecuteNonQuery((DbCommand) command);
                }

                scope.Complete();
            }
        }
    }
}
