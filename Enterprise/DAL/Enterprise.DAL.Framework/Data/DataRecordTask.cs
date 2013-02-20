using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.Caching;
using System.Text.RegularExpressions;
using CacheItem = Enterprise.DAL.Framework.Cache.CacheItem;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Class DataRecordTask
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataRecordTask<T> : SqlDataExecutor
    {
        /// <summary>
        /// The _commit
        /// </summary>
        private MethodInfo _commit;

        /// <summary>
        /// The _DB connection string
        /// </summary>
        private string _dbConnectionString;

        /// <summary>
        /// The _is changed
        /// </summary>
        private bool _isChanged;

        /// <summary>
        /// The _model
        /// </summary>
        private object _model;

        /// <summary>
        /// The _model name
        /// </summary>
        private string _modelName;

        /// <summary>
        /// The _record id
        /// </summary>
        private int _recordId;

        /// <summary>
        /// The _stored procedure
        /// </summary>
        private string _storedProcedure;


        /// <summary>
        /// Gets or sets the commit.
        /// </summary>
        /// <value>The commit.</value>
        public MethodInfo Commit
        {
            get { return _commit; }
            set { _commit = value; }
        }

        /// <summary>
        /// Gets or sets the is changed.
        /// </summary>
        /// <value>The is changed.</value>
        public Boolean IsChanged
        {
            get { return _isChanged; }
            set { _isChanged = value; }
        }

        /// <summary>
        /// Gets or sets the name of the model.
        /// </summary>
        /// <value>The name of the model.</value>
        public String ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }

        /// <summary>
        /// Gets or sets the record id.
        /// </summary>
        /// <value>The record id.</value>
        public Int32 RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        /// <summary>
        /// Gets or sets the db connection string.
        /// </summary>
        /// <value>The db connection string.</value>
        public String DbConnectionString
        {
            get { return _dbConnectionString; }
            set { _dbConnectionString = value; }
        }

        /// <summary>
        /// Gets or sets the stored procedure.
        /// </summary>
        /// <value>The stored procedure.</value>
        public String StoredProcedure
        {
            get { return _storedProcedure; }
            set { _storedProcedure = value; }
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        public Object Model
        {
            get { return _model; }
            set { _model = value; }
        }


        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
            Type type = _model.GetType();
            _modelName = _model.GetType().Name;
            _isChanged = (bool) type.GetMethod("IsChanged").Invoke(_model, null);
            _dbConnectionString = (string) type.GetProperty("SqlDatabase").GetValue(_model);
            _commit = type.GetMethod("CommitChanges");
            _recordId = Convert.ToInt32(type.GetProperty(_modelName + @"ID").GetValue(_model));
        }

        /// <summary>
        /// Saves the record.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int SaveRecord()
        {
            LoadData();

            if (_recordId != 0)
            {
                if (_isChanged)
                {
                    // Update
                    _storedProcedure = @"[crud]." + _modelName + @"_Update";
                    Execute(GetCommand(_dbConnectionString, _storedProcedure, GetArgs()));
                    CacheItem.Clear<T>();
                    _commit.Invoke(_model, null);
                }

                return _recordId;
            }

            // Insert
            _storedProcedure = @"[crud]." + _modelName + @"_Insert";
            _recordId = Execute(GetCommand(_dbConnectionString, _storedProcedure, GetArgs()), Convert.ToInt32);
            CacheItem.Clear<T>();

            return _recordId;
        }

        /// <summary>
        /// Deletes the record.
        /// </summary>
        public bool DeleteRecord()
        {
            LoadData();

            _storedProcedure = @"[crud]." + _modelName + @"_Delete";
            var args = GetArgs();
            Execute(GetCommand(_dbConnectionString, _storedProcedure, args));
            CacheItem.Clear<T>();

            string _checkProcedure = @"[crud]." + _modelName + @"_SelectById";
            int retValue = Execute(GetCommand(_dbConnectionString, _checkProcedure, args), Convert.ToInt32);

            return retValue == 0;
        }

        /// <summary>
        /// Gets the args.
        /// </summary>
        /// <returns>System.Object[][].</returns>
        private object[] GetArgs()
        {
            var args = new List<object>();
            SqlParameterCollection commandParams = GetProcParams();

            foreach (SqlParameter param in commandParams)
            {
                PropertyInfo column = _model.GetType().GetRuntimeProperty(Regex.Replace(param.ParameterName, @"@", ""));
                if (column != null)
                {
                    args.Add(column.GetValue(_model) ?? DBNull.Value);
                }
            }

            return args.ToArray();
        }

        /// <summary>
        /// Gets the proc params.
        /// </summary>
        /// <returns>SqlParameterCollection.</returns>
        private SqlParameterCollection GetProcParams()
        {

            
            var procNameToStore = _storedProcedure + @"_params";

            var cache = MemoryCache.Default;
            if (cache.GetCacheItem(procNameToStore) == null)
            {
                var policy = new CacheItemPolicy
                    {
                        AbsoluteExpiration = DateTime.Now.AddMinutes(60)
                    };

                var sqlConnection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings[_dbConnectionString].ConnectionString);

                var cmd = new SqlCommand
                    {
                        Connection = sqlConnection,
                        CommandText = _storedProcedure,
                        CommandType = CommandType.StoredProcedure
                    };

                sqlConnection.Open();
                SqlCommandBuilder.DeriveParameters(cmd);
                sqlConnection.Close();

                // Add to cache
                cache.Add(procNameToStore, cmd.Parameters, policy);
            }

            // Read from Cache
            var cacheItem = cache.GetCacheItem(procNameToStore);
            if (cacheItem != null)
            {
                return (SqlParameterCollection) cacheItem.Value;
            }

            return null;
        }
    }
}
