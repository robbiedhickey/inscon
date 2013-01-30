// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="MemoryCommand.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Dummy implementation of a command used in conjunction with the MemoryContext
    /// </summary>
    public class MemoryCommand : IDbCommand
    {
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a prepared (or compiled) version of the command on the data source.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Prepare()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to cancels the execution of an <see cref="T:System.Data.IDbCommand" />.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new instance of an <see cref="T:System.Data.IDbDataParameter" /> object.
        /// </summary>
        /// <returns>An IDbDataParameter object.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IDbDataParameter CreateParameter()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes an SQL statement against the Connection object of a .NET Framework data provider, and returns the number of rows affected.
        /// </summary>
        /// <returns>The number of rows affected.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes the <see cref="P:System.Data.IDbCommand.CommandText" /> against the <see cref="P:System.Data.IDbCommand.Connection" /> and builds an <see cref="T:System.Data.IDataReader" />.
        /// </summary>
        /// <returns>An <see cref="T:System.Data.IDataReader" /> object.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes the <see cref="P:System.Data.IDbCommand.CommandText" /> against the <see cref="P:System.Data.IDbCommand.Connection" />, and builds an <see cref="T:System.Data.IDataReader" /> using one of the <see cref="T:System.Data.CommandBehavior" /> values.
        /// </summary>
        /// <param name="behavior">One of the <see cref="T:System.Data.CommandBehavior" /> values.</param>
        /// <returns>An <see cref="T:System.Data.IDataReader" /> object.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IDataReader ExecuteReader(CommandBehavior behavior)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes the query, and returns the first column of the first row in the resultset returned by the query. Extra columns or rows are ignored.
        /// </summary>
        /// <returns>The first column of the first row in the resultset.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the <see cref="T:System.Data.IDbConnection" /> used by this instance of the <see cref="T:System.Data.IDbCommand" />.
        /// </summary>
        /// <value>The connection.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        /// <returns>The connection to the data source.</returns>
        public IDbConnection Connection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the transaction within which the Command object of a .NET Framework data provider executes.
        /// </summary>
        /// <value>The transaction.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        /// <returns>the Command object of a .NET Framework data provider executes. The default value is null.</returns>
        public IDbTransaction Transaction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the text command to run against the data source.
        /// </summary>
        /// <value>The command text.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        /// <returns>The text command to execute. The default value is an empty string ("").</returns>
        public string CommandText
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the wait time before terminating the attempt to execute a command and generating an error.
        /// </summary>
        /// <value>The command timeout.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        /// <returns>The time (in seconds) to wait for the command to execute. The default value is 30 seconds.</returns>
        public int CommandTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Indicates or specifies how the <see cref="P:System.Data.IDbCommand.CommandText" /> property is interpreted.
        /// </summary>
        /// <value>The type of the command.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        /// <returns>One of the <see cref="T:System.Data.CommandType" /> values. The default is Text.</returns>
        public CommandType CommandType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the <see cref="T:System.Data.IDataParameterCollection" />.
        /// </summary>
        /// <value>The parameters.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        /// <returns>The parameters of the SQL statement or stored procedure.</returns>
        public IDataParameterCollection Parameters
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets how command results are applied to the <see cref="T:System.Data.DataRow" /> when used by the <see cref="M:System.Data.IDataAdapter.Update(System.Data.DataSet)" /> method of a <see cref="T:System.Data.Common.DbDataAdapter" />.
        /// </summary>
        /// <value>The updated row source.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        /// <returns>One of the <see cref="T:System.Data.UpdateRowSource" /> values. The default is Both unless the command is automatically generated. Then the default is None.</returns>
        public UpdateRowSource UpdatedRowSource
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
