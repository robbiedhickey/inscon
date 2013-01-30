// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="DataFormat.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Text.RegularExpressions;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Class DataFormat
    /// </summary>
    public static class DataFormat
    {
        #region Public Methods

        /// <summary>
        /// Formats the us phone.
        /// </summary>
        /// <param name="num">The num.</param>
        /// <returns>System.String.</returns>
        public static string FormatUsPhone(string num)
        {
            if (num != null)
            {
                //first we must remove all non numeric characters
                num = num.Replace("(", "").Replace(")", "").Replace("-", "");
                const string formatPattern = @"(\d{3})(\d{3})(\d{4})";
                string results = Regex.Replace(num, formatPattern, "($1) $2-$3");
                //now return the formatted phone number
                return results;
            }

            return String.Empty;
        }

        /// <summary>
        /// Strips the non numeric.
        /// </summary>
        /// <param name="num">The num.</param>
        /// <returns>System.String.</returns>
        public static string StripNonNumeric(string num)
        {
            if (num != null)
            {
                var regEx = new Regex(@"\D");
                return regEx.Replace(num, "");
            }

            return String.Empty;
        }

        #endregion
    }
}