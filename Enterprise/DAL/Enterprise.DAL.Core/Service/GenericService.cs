using System.Data;
using Enterprise.DAL.Framework.Data;


namespace Enterprise.DAL.Core.Service
{
    public class GenericService: SqlDataRecord
    {
        public void RunProc(string database, string proc)
        {
            Execute(GetCommand(database, proc));
        }


        public DataTable GetDataTable(string Database, string StoredProcedure, params object[] parameters)
        {
            return QueryDataTable(Database, StoredProcedure, parameters);
        }

        public DataSet GetDataSet(string Database, string StoredProcedure, params object[] parameters)
        {
            return QueryDataSet(Database, StoredProcedure, parameters);
        }

        public IDataReader GetDataReader(string Database, string StoredProcedure, params object[] parameters)
        {
            return QueryReader(Database, StoredProcedure, parameters);
        }
    }
}
