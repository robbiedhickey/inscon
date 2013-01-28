// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="GenericService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class GenericService
    /// </summary>
    public class GenericService : SqlDataRecord
    {
        /// <summary>
        /// Runs the proc.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="procedure">The procedure.</param>
        public void RunProc(string database, string procedure)
        {
            Execute(GetCommand(database, procedure));
        }


        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <param name="Database">The database.</param>
        /// <param name="StoredProcedure">The stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>DataTable.</returns>
        public DataTable GetDataTable(string Database, string StoredProcedure, params object[] parameters)
        {
            return QueryDataTable(Database, StoredProcedure, parameters);
        }

        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <param name="Database">The database.</param>
        /// <param name="StoredProcedure">The stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>DataSet.</returns>
        public DataSet GetDataSet(string Database, string StoredProcedure, params object[] parameters)
        {
            return QueryDataSet(Database, StoredProcedure, parameters);
        }

        /// <summary>
        /// Gets the data reader.
        /// </summary>
        /// <param name="Database">The database.</param>
        /// <param name="StoredProcedure">The stored procedure.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>IDataReader.</returns>
        public IDataReader GetDataReader(string Database, string StoredProcedure, params object[] parameters)
        {
            return QueryReader(Database, StoredProcedure, parameters);
        }
    }
}