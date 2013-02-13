using System.Data;
using dbSvc = Enterprise.DAL.Core.Service.GenericService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class GenericRepository : IGenericRepository
    {
        public void RunProc(string database, string procedure)
        {
            new dbSvc().RunProc(database, procedure);
        }

        public DataTable GetDataTable(string database, string storedProcedure, params object[] parameters)
        {
            return new dbSvc().GetDataTable(database, storedProcedure, parameters);
        }

        public DataSet GetDataSet(string database, string storedProcedure, params object[] parameters)
        {
            return new dbSvc().GetDataSet(database, storedProcedure, parameters);
        }

        public IDataReader GetDataReader(string database, string storedProcedure, params object[] parameters)
        {
            return new dbSvc().GetDataReader(database, storedProcedure, parameters);
        }
    }
}