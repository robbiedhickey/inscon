// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="IDataModifier.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Delegate Convert
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="scalar">The scalar.</param>
    /// <returns>``0.</returns>
	public delegate T Convert<out T>( object scalar );

    /// <summary>
    /// Interface IDataModifier
    /// </summary>
	public interface IDataModifier
	{
        /// <summary>
        /// Executes the specified executor.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="executor">The executor.</param>
        /// <param name="converter">The converter.</param>
        /// <returns>``0.</returns>
		T Execute<T>( IDbCommand executor, Convert<T> converter );
	}
}
