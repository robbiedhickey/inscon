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
        private IDataContext _context;
    	private int _timeout;

        protected DataAccessor()
        {
        }

        public DataAccessor( IDataContext context )
        {
            _context = context;
        }

        protected IDataContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

		/// <summary>
		/// The data access timeout to use, in seconds
		/// </summary>
		protected int Timeout
    	{
    		get { return _timeout; }
    		set { _timeout = value; }
    	}

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

        protected ITypeReader FindReader(IDbCommand finder)
		{
			ITypeReader reader = new TypeConvertingReader(_context.ExecuteReader(finder), Converter.ConverterInstance);

			return reader;
		}

        protected DataSet FindDataSet(IDbCommand finder)
        {
            var results = _context.ExecuteDataSet(finder);
            return results;
        }

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
		/// <param name="finder"></param>
		/// <param name="builders"></param>
		/// <returns></returns>
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
		/// <typeparam name="TK"></typeparam>
		/// <typeparam name="TV"></typeparam>
		/// <param name="finder"></param>
		/// <param name="builder"></param>
		/// <param name="keyBuilder"></param>
		/// <returns></returns>
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
		/// <param name="reader"></param>
		/// <returns></returns>
		protected static int FirstInt( ITypeReader reader )
		{
			return Converter.ConverterInstance.ToInt32( reader[0] );
		}

		/// <summary>
		/// Pulls the first value from the read as a string.
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		protected static string FirstString( ITypeReader reader )
		{
			return Converter.ConverterInstance.ToString( reader[0] );			
		}
    }
}
