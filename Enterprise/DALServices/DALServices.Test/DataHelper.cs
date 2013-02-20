using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Microsoft.SqlServer.Management.Common;
//using Microsoft.SqlServer.Management.Smo;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using SmoLiteApi;

namespace Enterprise.ApiServices.DALServices.Test
{
    public static class DataHelper
    {
        public static void LoadData(string dataFileName)
        {
            var sqlConnectionString = ConfigurationManager.ConnectionStrings["EnterpriseDb"].ConnectionString;
            //var file = new FileInfo("TestScripts\\" + dataFileName);
            var file = new FileInfo(dataFileName);
            var script = file.OpenText().ReadToEnd();
            var conn = new SqlConnection(sqlConnectionString);
            var server = new Server();
            server.ConnectionContext.ServerInstance = "INSCON1";
            Database database = new Database(server, "EnterpriseDbTest");
            server.ConnectionContext.Connect();
            database.ExecuteNonQuery(script);
        }
    }
}
