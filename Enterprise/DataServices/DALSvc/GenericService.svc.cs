using System;
using System.Data;
using dbSvc = Enterprise.DAL.Core.Service.GenericService;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Provides generic access to the stored procs.
    /// </summary>
    public class GenericService : IGenericService
    {
        /// <summary>
        /// Runs the proc.
        /// </summary>
        /// <param name="database">The database to query.</param>
        /// <param name="procedure">The procedure to execute.</param>
        public void RunProc(string database, string procedure)
        {
            try
            {
                new dbSvc().RunProc(database, procedure);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <param name="Database">The database to query.</param>
        /// <param name="StoredProcedure">The stored procedure to execute.</param>
        /// <param name="parameters">The parameters required for the stored procedure.</param>
        /// <returns></returns>
        public DataTable GetDataTable(string Database, string StoredProcedure, params object[] parameters)
        {
            try
            {
                return new dbSvc().GetDataTable(Database, StoredProcedure, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <param name="Database">The database to query.</param>
        /// <param name="StoredProcedure">The stored procedure to execute.</param>
        /// <param name="parameters">The parameters required for the stored procedure.</param>
        /// <returns></returns>
        public DataSet GetDataSet(string Database, string StoredProcedure, params object[] parameters)
        {
            try
            {
                return new dbSvc().GetDataSet(Database, StoredProcedure, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the data reader.
        /// </summary>
        /// <param name="Database">The database to query.</param>
        /// <param name="StoredProcedure">The stored procedure to execute.</param>
        /// <param name="parameters">The parameters required for the stored procedure.</param>
        /// <returns></returns>
        public IDataReader GetDataReader(string Database, string StoredProcedure, params object[] parameters)
        {
            try
            {
                return new dbSvc().GetDataReader(Database, StoredProcedure, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
