// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="DataAccessor.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// A data accessor provides plumbing to retrieve information in a consistent
    /// way from a data source.
    /// </summary>
    public class DataAccessor : IDataAccessor
    {
        /// <summary>
        /// The _context
        /// </summary>
        private IDataContext _context;
        /// <summary>
        /// The _timeout
        /// </summary>
    	private int _timeout;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccessor"/> class.
        /// </summary>
        protected DataAccessor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccessor"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public DataAccessor( IDataContext context )
        {
            _context = context;
        }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>The context.</value>
        protected IDataContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        /// <summary>
        /// The data access timeout to use, in seconds
        /// </summary>
        /// <value>The timeout.</value>
		protected int Timeout
    	{
    		get { return _timeout; }
    		set { _timeout = value; }
    	}

        /// <summary>
        /// Finds the specified finder.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="finder">The finder.</param>
        /// <param name="builder">The builder.</param>
        /// <returns>``0.</returns>
    	public T Find<T>( IDbCommand finder, Build<T> builder )
        {
            using (ITypeReader reader = new TypeConvertingReader(_context.ExecuteReader(finder), Converter.ConverterInstance))
            {
                T item = default(T);

                if (reader.Read())
                {
                    item = builder(reader);

                    var commit = item.GetType().GetMethod("CommitChanges");
                    if (commit != null)
                    {
                        commit.Invoke(item, null);
                    }
                }

                return item;
            }
        }

        /// <summary>
        /// Finds the reader.
        /// </summary>
        /// <param name="finder">The finder.</param>
        /// <returns>ITypeReader.</returns>
        protected ITypeReader FindReader(IDbCommand finder)
		{
			ITypeReader reader = new TypeConvertingReader(_context.ExecuteReader(finder), Converter.ConverterInstance);

			return reader;
		}

        /// <summary>
        /// Finds the data set.
        /// </summary>
        /// <param name="finder">The finder.</param>
        /// <returns>DataSet.</returns>
        protected DataSet FindDataSet(IDbCommand finder)
        {
            var results = _context.ExecuteDataSet(finder);
            return results;
        }

        /// <summary>
        /// Finds the specified finder.
        /// </summary>
        /// <param name="finder">The finder.</param>
        /// <returns>DataTable.</returns>
        protected DataTable Find(IDbCommand finder)
        {
            var results = new DataTable();

            using (ITypeReader reader = new TypeConvertingReader(
                _context.ExecuteReader(finder), Converter.ConverterInstance))
            {
                results.Load(reader);
                return results;
            }     
        }

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="finder">The finder.</param>
        /// <param name="builder">The builder.</param>
        /// <returns>List{``0}.</returns>
		public List<T> FindAll<T>( IDbCommand finder, Build<T> builder )
		{
		
            using (ITypeReader reader = new TypeConvertingReader(
                _context.ExecuteReader(finder), Converter.ConverterInstance))
            {
                var results = new List<T>();

                while (reader.Read())
                {
                    var item = builder(reader);
                    var commit = item.GetType().GetMethod("CommitChanges");

                    if (commit != null)
                    {
                        commit.Invoke(item, null);
                    }

                    results.Add(item);
                }

                return results;
            }   
		}

        /// <summary>
        /// Finds all records from a given multi-set query and applies a
        /// build transformer to each one.
        /// </summary>
        /// <param name="finder">The finder.</param>
        /// <param name="builders">The builders.</param>
        /// <returns>IList.</returns>
		protected IList FindAll( IDbCommand finder, List<Build> builders )
		{
            using (ITypeReader reader = new TypeConvertingReader(
                _context.ExecuteReader(finder), Converter.ConverterInstance))
            {
                IList results = new ArrayList();

                for (var i = 0; i < builders.Count; i++)
                {
                    var rowList = new ArrayList();

                    while (reader.Read())
                    {
                        var item = builders[i](reader);
                        
                        
                        var commit = item.GetType().GetMethod("CommitChanges");
                        if (commit != null)
                        {
                            commit.Invoke(item, null);
                        }

                        rowList.Add(item);
                    }

                    results.Add(rowList);

                    if (i < (builders.Count - 1))
                    {
                        reader.NextResult();
                    }
                }

                return results;
            }    
		}

        /// <summary>
        /// Creates a dictionary of given key and value type from a command, using
        /// builders for both.  Will return an empty dictionary if there are no results.
        /// </summary>
        /// <typeparam name="TK">The type of the TK.</typeparam>
        /// <typeparam name="TV">The type of the TV.</typeparam>
        /// <param name="finder">The finder.</param>
        /// <param name="builder">The builder.</param>
        /// <param name="keyBuilder">The key builder.</param>
        /// <returns>Dictionary{``0``1}.</returns>
		public Dictionary<TK, TV> FindAll<TK, TV>( IDbCommand finder, Build<TV> builder, Build<TK> keyBuilder )
		{
            using (ITypeReader reader = new TypeConvertingReader(
                _context.ExecuteReader(finder), Converter.ConverterInstance))
            {
                var results = new Dictionary<TK, TV>();

                while (reader.Read())
                {
                    TV item = builder(reader);
                    TK key = keyBuilder(reader);

                    var commit = item.GetType().GetMethod("CommitChanges");
                    if (commit != null)
                    {
                        commit.Invoke(item, null);
                    }

                    results.Add(key, item);
                }

                return results;
            }			
		}

        /// <summary>
        /// Pulls the first value from the reader as an integer.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>System.Int32.</returns>
		protected static int FirstInt( ITypeReader reader )
		{
			return Converter.ConverterInstance.ToInt32( reader[0] );
		}

        /// <summary>
        /// Pulls the first value from the read as a string.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>System.String.</returns>
		protected static string FirstString( ITypeReader reader )
		{
			return Converter.ConverterInstance.ToString( reader[0] );			
		}
    }
}
