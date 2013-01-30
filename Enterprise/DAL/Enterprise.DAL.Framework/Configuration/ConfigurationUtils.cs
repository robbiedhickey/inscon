// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ConfigurationUtils.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Enterprise.DAL.Framework.Configuration
{
    /// <summary>
    /// Convenience helpers to pull strongly typed data elements from AppSettings
    /// configuration.  Relies on the Converter implementation to manage type conversion/coercion.
    /// </summary>
    public static class ConfigurationUtils
    {
        /// <summary>
        /// Gets the password expiry in days.
        /// </summary>
        /// <value>The password expiry in days.</value>
        public static int PasswordExpiryInDays
        {
            get
            {
                var expiry = ConfigurationManager.AppSettings["PasswordExpiryInDays"];

                return expiry == String.Empty ? 60 : Int32.Parse(expiry);
            }
        }

        /// <summary>
        /// Gets the config bool.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public static bool GetConfigBool(string key)
        {
            return GetConfigBool(key, false);
        }

        /// <summary>
        /// Gets the config bool.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public static bool GetConfigBool(string key, bool defaultValue)
        {
            return Converter.ToBool(ConfigurationManager.AppSettings[key], defaultValue);
        }

        /// <summary>
        /// Gets the config string.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        public static string GetConfigString(string key)
        {
            return GetConfigString(key, string.Empty);
        }

        /// <summary>
        /// Gets the config string.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string GetConfigString(string key, string defaultValue)
        {
            return Converter.ToString(ConfigurationManager.AppSettings[key], defaultValue);
        }

        /// <summary>
        /// Gets the config int.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.Int32.</returns>
        public static int GetConfigInt(string key)
        {
            return GetConfigInt(key, 0);
        }

        /// <summary>
        /// Gets the config int.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Int32.</returns>
        public static int GetConfigInt(string key, int defaultValue)
        {
            return Converter.ToInt32(ConfigurationManager.AppSettings[key], defaultValue);
        }

        /// <summary>
        /// Gets the config double.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.Double.</returns>
        public static double GetConfigDouble(string key)
        {
            return GetConfigDouble(key, 0.0);
        }

        /// <summary>
        /// Gets the config double.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Double.</returns>
        public static double GetConfigDouble(string key, double defaultValue)
        {
            return Converter.ToDouble(ConfigurationManager.AppSettings[key], defaultValue);
        }

        /// <summary>
        /// Retrieves a slash-terminated path named in configuration, or ".\" if
        /// the key does not exist.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        public static string GetConfigPath(string key)
        {
            return GetConfigPath(key, true);
        }

        /// <summary>
        /// Gets the config path.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="includeTerminator">if set to <c>true</c> [include terminator].</param>
        /// <returns>System.String.</returns>
        public static string GetConfigPath(string key, bool includeTerminator)
        {
            string path = GetConfigString(key, ".");

            if (includeTerminator && ! path.EndsWith(@"\"))
            {
                return path + @"\\";
            }
            if (! includeTerminator && path.EndsWith(@"\"))
            {
                return Regex.Replace(path, @"\\+$", "");
            }

            return path;
        }
    }
}