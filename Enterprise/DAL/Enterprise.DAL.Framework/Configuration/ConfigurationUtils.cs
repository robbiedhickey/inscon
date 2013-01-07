using System;
using System.Configuration;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Enterprise.DAL.Framework.Configuration
{
    /// <summary>
    ///     Convenience helpers to pull strongly typed data elements from AppSettings
    ///     configuration.  Relies on the Converter implementation to manage type conversion/coercion.
    /// </summary>
    public static class ConfigurationUtils
    {
        public static int PasswordExpiryInDays
        {
            get
            {
                string expiry = ConfigurationManager.AppSettings["PasswordExpiryInDays"];

                if (expiry == String.Empty)
                {
                    return 60;
                }
                return Int32.Parse(expiry);
            }
        }

        public static bool GetConfigBool(string key)
        {
            return GetConfigBool(key, false);
        }

        public static bool GetConfigBool(string key, bool defaultValue)
        {
            return Converter.ToBool(ConfigurationManager.AppSettings[key], defaultValue);
        }

        public static string GetConfigString(string key)
        {
            return GetConfigString(key, string.Empty);
        }

        public static string GetConfigString(string key, string defaultValue)
        {
            return Converter.ToString(ConfigurationManager.AppSettings[key], defaultValue);
        }

        public static int GetConfigInt(string key)
        {
            return GetConfigInt(key, 0);
        }

        public static int GetConfigInt(string key, int defaultValue)
        {
            return Converter.ToInt(ConfigurationManager.AppSettings[key], defaultValue);
        }

        public static double GetConfigDouble(string key)
        {
            return GetConfigDouble(key, 0.0);
        }

        public static double GetConfigDouble(string key, double defaultValue)
        {
            return Converter.ToDouble(ConfigurationManager.AppSettings[key], defaultValue);
        }

        /// <summary>
        ///     Retrieves a slash-terminated path named in configuration, or ".\" if
        ///     the key does not exist.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfigPath(string key)
        {
            return GetConfigPath(key, true);
        }

        public static string GetConfigPath(string key, bool includeTerminator)
        {
            string path = GetConfigString(key, ".");

            if (includeTerminator && ! path.EndsWith(@"\"))
            {
                return path + "\\";
            }
            if (! includeTerminator && path.EndsWith(@"\"))
            {
                return Regex.Replace(path, @"\\+$", "");
            }

            return path;
        }

        // Antonio Gonzalez - 12.28.2009
        public static String GetFullPacketUrl(String receiveddate, String clientcode, String invoicenumber)
        {
            var pdfpath = new StringBuilder(GetConfigString("pdfpath"));
            //pdfpath.Append("\\{0}", );
            pdfpath.Append(DateTime.Parse(receiveddate).Year.ToString(CultureInfo.InvariantCulture));
            pdfpath.AppendFormat("/{0}", clientcode);
            pdfpath.AppendFormat("/packets/{0}-packet.pdf", invoicenumber);

            return pdfpath.ToString();
        }

        public static String GetPreservationDetailPageUrl(string invoiceNumber)
        {
            string retval = "/default.aspx?tab=240&ti=-1&pid=" + invoiceNumber;
            return retval;
        }
    }
}