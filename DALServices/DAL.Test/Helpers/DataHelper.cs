using SmoLiteApi;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enterprise.DALServices.DAL.Test
{
    using System;

    public static class DataHelper
    {
        public static void LoadData(string dataFileName)
        {
            var sqlConnectionString = ConfigurationManager.ConnectionStrings["EnterpriseDbContext"];
            var builder = new SqlConnectionStringBuilder(sqlConnectionString.ConnectionString);
            var file = new FileInfo(dataFileName);
            var script = file.OpenText().ReadToEnd();
            var server = new Server();
            server.ConnectionContext.ServerInstance = builder.DataSource;
            Database database = new Database(server, builder.InitialCatalog);
            server.ConnectionContext.Connect();
            database.ExecuteNonQuery(script);
        }

    }
}
