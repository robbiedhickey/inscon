using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    public static class DataHelper
    {
        private static readonly Dictionary<string, ConstructorInfo> ConstructorCache = new Dictionary<string, ConstructorInfo>();
        private static readonly Dictionary<string, PropertyInfo[]> PropertyInfoCache = new Dictionary<string, PropertyInfo[]>();
        private static readonly Dictionary<string, Func<IDataReader, object>> MappingCache = new Dictionary<string, Func<IDataReader, object>>();

        private static ConstructorInfo GetDefaultConstructor<T>()
        {
            var type = typeof (T);

            string fullName = type.FullName;
            if (!ConstructorCache.ContainsKey(fullName))
            {
                ConstructorCache.Add(fullName, type.GetConstructor(Type.EmptyTypes));
            }
            return ConstructorCache[fullName];
        }

        private static T CreateInstance<T>()
        {
            var constructor = GetDefaultConstructor<T>();
            return (T) constructor.Invoke(new object[0]);
        }

        private static string GetMappingSignature(this IDataReader dr, Type type)
        {
            var table = dr.GetSchemaTable();
            var builder = new StringBuilder();

            if (table != null)
            {
                foreach (DataColumn dc in table.Columns)
                {
                    builder.Append(dc.ColumnName);
                }
            }

            builder.Append(type.FullName);

            return builder.ToString();
        }

        private static Action<IDataReader, object> CreateSetValueAction(PropertyInfo info, Type columnType, string columnName)
        {
            var propType = info.PropertyType;

            Action<IDataReader, object> setValueAction;

            if (propType.BaseType == typeof (Enum))
            {
                setValueAction = (dr, obj) => info.SetValue(obj, IsNumeric(dr[columnName]) ? Enum.ToObject(propType, Convert.ToInt32(dr[columnName])) : Enum.ToObject(propType, dr[columnName]), null);
            }
            else if (propType == columnType)
            {
                setValueAction = (dr, obj) => info.SetValue(obj, dr[columnName], null);
            }
            else
            {
                //different types
                setValueAction = (dr, obj) => info.SetValue(obj, Convert.ChangeType(dr[columnName], propType), null);
            }

            return (dr, obj) =>
                       {
                           if (Convert.IsDBNull(dr[columnName]))
                           {
                               info.SetValue(obj, NullHandler.GetNull(info), null);
                           }
                           else
                           {
                               setValueAction.Invoke(dr, obj);
                           }
                       };
        }

        private static IEnumerable<Action<IDataReader, object>> CreatePropertyMapping<T>(IDataReader dr)
        {
            var properties = GetPropertyInfo<T>();
            var mapping = new List<Action<IDataReader, object>>();

            int i;
            for (i = 0; i < dr.FieldCount; i++)
            {
                string columnName = dr.GetName(i);
                //now find matching property
                var propMatch = (from p in properties
                                 where p.Name.ToLower() == columnName.ToLower()
                                 select p).FirstOrDefault();
                if (propMatch != null)
                {
                    var columnType = dr.GetFieldType(i);
                    var action = CreateSetValueAction(propMatch, columnType, columnName);
                    mapping.Add(action);
                }
            }
            return mapping;
        }

        private static Func<IDataReader, object> CreateObjectMapping<T>(IDataReader dataReader)
        {
            var mapping = CreatePropertyMapping<T>(dataReader);

            return dr =>
                       {
                           var obj = CreateInstance<T>();

                           foreach (var action in mapping)
                           {
                               action.Invoke(dr, obj);
                           }
                           return obj;
                       };
        }

        public static T CreateObject<T>(IDataReader dr)
        {
            var mappingSignature = dr.GetMappingSignature(typeof (T));

            if (!MappingCache.ContainsKey(mappingSignature))
            {
                MappingCache.Add(mappingSignature, CreateObjectMapping<T>(dr));
            }

            return (T) MappingCache[mappingSignature].Invoke(dr);
        }

        public static bool IsNumeric(object expression)
        {
            double retNum;
            var isNum = Double.TryParse(Convert.ToString(expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static List<PropertyInfo> GetPropertyInfo<T>()
        {
            var type = typeof (T);

            if (!PropertyInfoCache.ContainsKey(type.FullName))
            {
                PropertyInfoCache.Add(type.FullName, type.GetProperties());
            }

            var infoLIst = new List<PropertyInfo>(PropertyInfoCache[type.FullName]);
            return infoLIst;
        }

        public static int ExecuteNonQuery<T>(IDbCommand command, T item)
        {
            FillParameters<T>(item, command);
            return command.ExecuteNonQuery();
        }

        public static void FillParameters<T>(object obj, IDbCommand command)
        {
            var properties = GetPropertyInfo<T>();

            foreach (IDbDataParameter param in command.Parameters)
            {
                //find the right property
                var property = properties.Find(p => p.Name.ToLower() == param.SourceColumn.ToLower());

                var value = property.GetValue(obj, null);

                param.Value = NullHandler.IsNull(value) ? DBNull.Value : value;
            }
        }
    }
}