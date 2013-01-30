// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Converter.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Enterprise.DAL.Framework
{
    /// <summary>
    /// Static delegate for standard object to type conversions.  The default conversion
    /// strategy is the StandardTypeConverter.
    /// </summary>
	public static class Converter
	{
        /// <summary>
        /// The _converter
        /// </summary>
		private static ITypeConverter _converter = new StandardTypeConverter();

        /// <summary>
        /// Gets or sets the converter instance.
        /// </summary>
        /// <value>The converter instance.</value>
		public static ITypeConverter ConverterInstance
		{
			set { _converter = value; }
			get { return _converter; }
		}

        /// <summary>
        /// To the float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Single.</returns>
        public static float ToFloat(object source)
        {
            return _converter.ToFloat(source);
        }
        /// <summary>
        /// To the float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Single.</returns>
        public static float ToFloat(object source, float defaultValue)
        {
            return _converter.ToFloat(source, defaultValue);
        }



        /// <summary>
        /// To the null float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        public static float? ToNullFloat(object source)
        {
            return _converter.ToNullFloat(source);
        }

        /// <summary>
        /// To the null float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        public static float? ToNullFloat(object source, float? defaultValue)
        {
            return _converter.ToNullFloat(source, defaultValue);
        }


        /// <summary>
        /// To the int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int64.</returns>
        public static Int64 ToInt64(object source)
        {
            return _converter.ToInt64(source);
        }

        /// <summary>
        /// To the int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int64.</returns>
        public static Int64 ToInt64(object source, Int64 defaultValue)
        {
            return _converter.ToInt64(source, defaultValue);
        }

        /// <summary>
        /// To the null int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        public static Int64? ToNullInt64(object source)
        {
            return _converter.ToNullInt64(source);
        }

        /// <summary>
        /// To the null int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        public static Int64? ToNullInt64(object source, Int64? defaultValue)
        {
            return _converter.ToNullInt64(source, defaultValue);
        }

        /// <summary>
        /// To the int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int16.</returns>
        public static Int16 ToInt16(object source)
        {
            return _converter.ToInt16(source);
        }

        /// <summary>
        /// To the int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int16.</returns>
        public static Int16 ToInt16(object source, Int16 defaultValue)
        {
            return _converter.ToInt16(source, defaultValue);
        }

        /// <summary>
        /// To the null int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        public static Int16? ToNullInt16(object source)
        {
            return _converter.ToNullInt16(source);
        }

        /// <summary>
        /// To the null int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        public static Int16? ToNullInt16(object source, Int16? defaultValue)
        {
            return _converter.ToNullInt16(source, defaultValue);
        }

        /// <summary>
        /// To the int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int32.</returns>
        public static Int32 ToInt32(object source)
		{
            return _converter.ToInt32(source);
		}

        /// <summary>
        /// To the int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int32.</returns>
        public static Int32 ToInt32(object source, Int32 defaultValue)
		{
            return _converter.ToInt32(source, defaultValue);
		}

        /// <summary>
        /// To the null int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        public static Int32? ToNullInt32(object source)
        {
            return _converter.ToNullInt32(source);
        }

        /// <summary>
        /// To the null int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        public static Int32? ToNullInt32(object source, Int32? defaultValue)
        {
            return _converter.ToNullInt32(source, defaultValue);
        }

        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Double.</returns>
		public static double ToDouble(object source)
		{
			return _converter.ToDouble( source );
		}

        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Double.</returns>
		public static double ToDouble(object source, double defaultValue)
		{
			return _converter.ToDouble( source, defaultValue );
		}

        /// <summary>
        /// To the null double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{System.Double}.</returns>
        public static double? ToNullDouble(object source)
        {
            return _converter.ToNullDouble(source);
        }

        /// <summary>
        /// To the null double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{System.Double}.</returns>
        public static double? ToNullDouble(object source, double? defaultValue)
        {
            return _converter.ToNullDouble(source, defaultValue);
        }

        /// <summary>
        /// To the date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>DateTime.</returns>
		public static DateTime ToDate(object source)
		{
			return _converter.ToDate(source);
		}

        /// <summary>
        /// To the date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>DateTime.</returns>
		public static DateTime ToDate(object source, DateTime defaultValue)
		{
			return _converter.ToDate(source, defaultValue);
		}

        /// <summary>
        /// To the null date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        public static DateTime? ToNullDate(object source)
        {
            return _converter.ToNullDate(source);
        }

        /// <summary>
        /// To the null date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        public static DateTime? ToNullDate(object source, DateTime? defaultValue)
        {
            return _converter.ToNullDate(source, defaultValue);
        }

        /// <summary>
        /// To the bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
		public static bool ToBool(object source)
		{
			return _converter.ToBool(source);
		}

        /// <summary>
        /// To the bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
		public static bool ToBool(object source, bool defaultValue)
		{
			return _converter.ToBool(source, defaultValue);
		}

        /// <summary>
        /// To the null bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public static bool? ToNullBool(object source)
        {
            return _converter.ToNullBool(source);
        }

        /// <summary>
        /// To the null bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public static bool? ToNullBool(object source, bool? defaultValue)
        {
            return _converter.ToNullBool(source, defaultValue);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public static string ToString(object source)
		{
			return _converter.ToString(source);
		}

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public static string ToString(object source, string defaultValue)
		{
			return _converter.ToString(source, defaultValue);
		}

        /// <summary>
        /// To the char.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Char.</returns>
		public static char ToChar( object source )
		{
			return _converter.ToChar( source );
		}

        /// <summary>
        /// To the char.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Char.</returns>
		public static char ToChar( object source, char defaultValue )
		{
			return _converter.ToChar( source, defaultValue );
		}

        /// <summary>
        /// To the GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Guid.</returns>
        public static Guid ToGuid( object source)
        {
            return _converter.ToGuid(source);
        }

        /// <summary>
        /// To the GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Guid.</returns>
        public static Guid ToGuid( object source, Guid defaultValue)
        {
            return _converter.ToGuid(source, defaultValue);
        }

        /// <summary>
        /// To the null GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        public static Guid? ToNullGuid(object source)
        {
            return _converter.ToGuid(source);
        }

        /// <summary>
        /// To the null GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        public static Guid? ToNullGuid(object source, Guid? defaultValue)
        {
            return _converter.ToNullGuid(source, defaultValue);
        }

        /// <summary>
        /// To the decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Decimal.</returns>
        public static Decimal ToDecimal(object source)
        {
            return _converter.ToDecimal(source);
        }

        /// <summary>
        /// To the decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Decimal.</returns>
        public static Decimal ToDecimal(object source, decimal defaultValue)
        {
            return _converter.ToDecimal(source, defaultValue);
        }

        /// <summary>
        /// To the null decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        public static Decimal? ToNullDecimal(object source)
        {
            return _converter.ToNullDecimal(source);
        }

        /// <summary>
        /// To the null decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        public static Decimal? ToNullDecimal(object source, decimal? defaultValue)
        {
            return _converter.ToNullDecimal(source, defaultValue);
        }
	}
}