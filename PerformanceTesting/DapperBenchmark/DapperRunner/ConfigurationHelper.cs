using System;
using System.Configuration;

namespace DapperRunner
{
    public static class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
            return GetConnectionString(Constants.ConnectionString);
        }

        public static string GetConnectionString(string name)
        {
            if(ConfigurationManager.ConnectionStrings[name] == null)
                throw new Exception(String.Format("Connection string name {0} not found in app.config", name));
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string GetAppSetting(string key)
        {
            if (ConfigurationManager.AppSettings[key] == null)
                throw new Exception(String.Format("Appsetting key {0} not found.", key));
            return ConfigurationManager.AppSettings[key];
        }
    }
}
