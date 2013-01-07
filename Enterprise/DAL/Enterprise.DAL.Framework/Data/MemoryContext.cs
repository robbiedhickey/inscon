using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Implementation of a data context that uses in-memory objects and tracks
    /// commands sent to it.
    /// </summary>
    public class MemoryContext : IDataContext
    {
        private ITypeReader _reader;
        private DataSet _dataset;

        public ITypeReader Reader
        {
            get { return _reader; }
            set { _reader = value; }
        }

        public DataSet Dataset
        {
            get { return _dataset; }
            set { _dataset = value; }
        }

    	public IDbCommand CreateQuery( string query )
    	{
    		return new MemoryCommand();
    	}

    	public IDbCommand CreateCommand(string sproc)
        {
            return new MemoryCommand();
        }

        public IDbCommand CreateCommand(string sproc, params object[] args)
        {
            return new MemoryCommand();
        }

        public void AddInParameter(IDbCommand command, string name, DbType dbType, object value)
        {
        }

        public void AddOutParameter(IDbCommand command, string name, DbType dbType, int size)
        {
        }

        public IDataReader ExecuteReader(IDbCommand command)
        {
            return _reader;
        }

        public DataSet ExecuteDataSet(IDbCommand command)
        {
            return _dataset;
        }

        public object ExecuteScalar(IDbCommand command)
        {
            return null;
        }

        public int ExecuteNonQuery(IDbCommand command)
        {
            return 0;
        }

        public void ExecuteNonQuery(List<IDbCommand> commands)
        {
        }
    }
}