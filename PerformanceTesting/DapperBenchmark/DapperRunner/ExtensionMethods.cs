using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DapperRunner
{
    public static class ExtensionMethods
    {
        public static int CommandProc(this IDbConnection connection, string storedProcedureName, DynamicParameters parameters, IDbTransaction tran )
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            var retVal = connection.Execute(storedProcedureName, parameters, commandType: CommandType.StoredProcedure, transaction: tran);
            return retVal;
        }

        public static IEnumerable<T> QueryProc<T>(this IDbConnection connection, string storedProcedureName, DynamicParameters paramaters)
            where T: new()
        {
            return connection.Query<T>(storedProcedureName, paramaters, commandType: CommandType.StoredProcedure);
        }

        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            if (enumeration == null) return;

            foreach (T item in enumeration)
            {
                action(item);
            }
        }
    }
}