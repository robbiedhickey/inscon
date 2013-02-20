using System.Data;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IGenericRepository
    {
        void RunProc(string database, string procedure);
        DataTable GetDataTable(string database, string storedProcedure, params object[] parameters);
        DataSet GetDataSet(string database, string storedProcedure, params object[] parameters);
        IDataReader GetDataReader(string database, string storedProcedure, params object[] parameters);
    }
}
