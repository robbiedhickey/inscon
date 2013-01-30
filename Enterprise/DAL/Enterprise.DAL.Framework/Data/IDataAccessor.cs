// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="IDataAccessor.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Delegate Build
    /// </summary>
    /// <param name="reader">The reader.</param>
    /// <returns>System.Object.</returns>
	public delegate object Build( ITypeReader reader );
    /// <summary>
    /// Delegate Build
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="reader">The reader.</param>
    /// <returns>``0.</returns>
	public delegate T Build<out T>( ITypeReader reader );

    /// <summary>
    /// Interface IDataAccessor
    /// </summary>
    public interface IDataAccessor
    {
        /// <summary>
        /// Finds the specified finder.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="finder">The finder.</param>
        /// <param name="builder">The builder.</param>
        /// <returns>``0.</returns>
    	T Find<T>( IDbCommand finder, Build<T> builder );
        /// <summary>
        /// Finds all.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="finder">The finder.</param>
        /// <param name="builder">The builder.</param>
        /// <returns>List{``0}.</returns>
    	List<T> FindAll<T>( IDbCommand finder, Build<T> builder );
        /// <summary>
        /// Finds all.
        /// </summary>
        /// <typeparam name="TK">The type of the TK.</typeparam>
        /// <typeparam name="TV">The type of the TV.</typeparam>
        /// <param name="finder">The finder.</param>
        /// <param name="builder">The builder.</param>
        /// <param name="keyBuilder">The key builder.</param>
        /// <returns>Dictionary{``0``1}.</returns>
    	Dictionary<TK, TV> FindAll<TK, TV>( IDbCommand finder, Build<TV> builder, Build<TK> keyBuilder );
    }
}