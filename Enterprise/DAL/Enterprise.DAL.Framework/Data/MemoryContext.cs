// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="MemoryContext.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        /// <summary>
        /// The _reader
        /// </summary>
        private ITypeReader _reader;
        /// <summary>
        /// The _dataset
        /// </summary>
        private DataSet _dataset;

        /// <summary>
        /// Gets or sets the reader.
        /// </summary>
        /// <value>The reader.</value>
        public ITypeReader Reader
        {
            get { return _reader; }
            set { _reader = value; }
        }

        /// <summary>
        /// Gets or sets the dataset.
        /// </summary>
        /// <value>The dataset.</value>
        public DataSet Dataset
        {
            get { return _dataset; }
            set { _dataset = value; }
        }

        /// <summary>
        /// Creates the query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>IDbCommand.</returns>
    	public IDbCommand CreateQuery( string query )
    	{
    		return new MemoryCommand();
    	}

        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="sproc">The sproc.</param>
        /// <returns>IDbCommand.</returns>
    	public IDbCommand CreateCommand(string sproc)
        {
            return new MemoryCommand();
        }

        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="sproc">The sproc.</param>
        /// <param name="args">The args.</param>
        /// <returns>IDbCommand.</returns>
        public IDbCommand CreateCommand(string sproc, params object[] args)
        {
            return new MemoryCommand();
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
        }

        /// <summary>
        /// Executes the reader.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>IDataReader.</returns>
        public IDataReader ExecuteReader(IDbCommand command)
        {
            return _reader;
        }

        /// <summary>
        /// Executes the data set.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>DataSet.</returns>
        public DataSet ExecuteDataSet(IDbCommand command)
        {
            return _dataset;
        }

        /// <summary>
        /// Executes the scalar.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>System.Object.</returns>
        public object ExecuteScalar(IDbCommand command)
        {
            return null;
        }

        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>System.Int32.</returns>
        public int ExecuteNonQuery(IDbCommand command)
        {
            return 0;
        }

        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <param name="commands">The commands.</param>
        public void ExecuteNonQuery(List<IDbCommand> commands)
        {
        }
    }
}