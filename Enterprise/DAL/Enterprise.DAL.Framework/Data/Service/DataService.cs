using System.Collections.Generic;
using System.Data;
using System.Runtime.Caching;


namespace Enterprise.DAL.Framework.Data.Service
{
    public static class DataService
    {
        // Get ITypeReader 
        public static IDataReader GetITypeReader(string database, string storedProcedure, params object[] parameters)
        {
            return new SqlDataAccessor().QueryReader(database, storedProcedure, parameters);
        }

        public static ITypeReader GetITypeReader(string database, string storedProcedure)
        {
            return new SqlDataAccessor().QueryReader(database, storedProcedure);
        }

        // Get Datatable 
        public static DataTable GetDataTable(string database, string storedProcedure, params object[] parameters)
        {
            return new SqlDataAccessor().QueryDataTable(database, storedProcedure, parameters);
        }

        public static DataTable GetDataTable(string database, string storedProcedure)
        {
            return new SqlDataAccessor().QueryDataTable(database, storedProcedure);
        }

        // Get DataSet
        public static DataSet GetDataSet(string database, string storedProcedure, params object[] parameters)
        {
            return new SqlDataAccessor().QueryDataSet(database, storedProcedure, parameters);
        }

        public static DataSet GetDataSet(string database, string storedProcedure)
        {
            return new SqlDataAccessor().QueryDataSet(database, storedProcedure);
        }

        // get DataObject List
        public static List<T> GetDataObjectList<T>(string database, string procedure, int cacheMinutesToExpire, bool isCached, params object[] parameters) where T : new()
        {
            var retval = new List<T>();
            var dataObjectName = typeof(T).Name;
            var cache = MemoryCache.Default;

            // Look for object in Cache
            if (cache.GetCacheItem(dataObjectName) == null)
            {
                retval = DataClassInitializer.MapDataObjectCollection<T>(new SqlDataAccessor().QueryReader(database, procedure, parameters), cacheMinutesToExpire, isCached);
            }
            else
            {
                var cacheItem = cache.GetCacheItem(dataObjectName);
                if (cacheItem != null)
                {
                    retval = (List<T>)cacheItem.Value;
                }
            }
            return retval;
        }

        // Get DataObject
        public static T GetDataObject<T>(string database, string procedure, params object[] parameters) where T : new()
        {
            return DataClassInitializer.MapDataObject<T>(new SqlDataAccessor().QueryReader(database, procedure, parameters));
        }
    }
}