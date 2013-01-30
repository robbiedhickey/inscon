// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="IDataContext.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Interface IDataContext
    /// </summary>
    public interface IDataContext
    {
        /// <summary>
        /// Creates the query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>IDbCommand.</returns>
    	IDbCommand CreateQuery( string query );
        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="sproc">The sproc.</param>
        /// <returns>IDbCommand.</returns>
        IDbCommand CreateCommand(string sproc);
        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="sproc">The sproc.</param>
        /// <param name="args">The args.</param>
        /// <returns>IDbCommand.</returns>
        IDbCommand CreateCommand(string sproc, params object[] args);
        /// <summary>
        /// Adds the in parameter.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="name">The name.</param>
        /// <param name="dbType">Type of the db.</param>
        /// <param name="value">The value.</param>
        void AddInParameter(IDbCommand command, string name, DbType dbType, object value);
        /// <summary>
        /// Adds the out parameter.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="name">The name.</param>
        /// <param name="dbType">Type of the db.</param>
        /// <param name="size">The size.</param>
        void AddOutParameter(IDbCommand command, string name, DbType dbType, int size);

        /// <summary>
        /// Executes the data set.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>DataSet.</returns>
        DataSet ExecuteDataSet(IDbCommand command);
        /// <summary>
        /// Executes the reader.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>IDataReader.</returns>
        IDataReader ExecuteReader(IDbCommand command);
        /// <summary>
        /// Executes the scalar.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>System.Object.</returns>
        object ExecuteScalar(IDbCommand command);
        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>System.Int32.</returns>
        int ExecuteNonQuery(IDbCommand command);
        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <param name="commands">The commands.</param>
        void ExecuteNonQuery(List<IDbCommand> commands);
    }
}