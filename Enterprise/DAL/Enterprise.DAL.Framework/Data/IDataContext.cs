using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    public interface IDataContext
    {
    	IDbCommand CreateQuery( string query );
        IDbCommand CreateCommand(string sproc);
        IDbCommand CreateCommand(string sproc, params object[] args);
        void AddInParameter(IDbCommand command, string name, DbType dbType, object value);
        void AddOutParameter(IDbCommand command, string name, DbType dbType, int size);

        DataSet ExecuteDataSet(IDbCommand command);
        IDataReader ExecuteReader(IDbCommand command);
        object ExecuteScalar(IDbCommand command);
        int ExecuteNonQuery(IDbCommand command);
        void ExecuteNonQuery(List<IDbCommand> commands);
    }
}