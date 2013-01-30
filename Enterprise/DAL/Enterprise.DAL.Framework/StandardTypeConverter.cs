// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="StandardTypeConverter.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Text.RegularExpressions;

namespace Enterprise.DAL.Framework
{
    /// <summary>
    /// Class StandardTypeConverter
    /// </summary>
	public class StandardTypeConverter : ITypeConverter
	{
        /// <summary>
        /// Determines whether the specified source is null.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source is null; otherwise, <c>false</c>.</returns>
		public static bool IsNull(Object source)
		{
			return source == null || source == DBNull.Value;
		}

        /// <summary>
        /// Determines whether the specified source is empty.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source is empty; otherwise, <c>false</c>.</returns>
		public static bool IsEmpty(Object source)
		{
			return IsNull(source) || source.ToString().Trim() == "";
		}

        /// <summary>
        /// To the GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Guid.</returns>
	    public Guid ToGuid(Object source)
		{
		    return ToGuid(source, Guid.Empty);
		}

        /// <summary>
        /// To the GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Guid.</returns>
        public Guid ToGuid(Object source, Guid defaultValue)
        {

            if (source is Guid)
            {
                return (Guid)source;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the null GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        public Guid? ToNullGuid(Object source)
        {
            return ToNullGuid(source, null);
        }

        /// <summary>
        /// To the null GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        public Guid? ToNullGuid(Object source, Guid? defaultValue)
        {

            if (source is Guid)
            {
                return (Guid)source;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int64.</returns>
        public Int64 ToInt64(Object source)
        {
            return ToInt64(source, Int64.MinValue);
        }

        /// <summary>
        /// To the int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int64.</returns>
        public Int64 ToInt64(Object source, Int64 defaultValue)
        {
            if (source is Int64)
            {
                return (Int64)source;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int32.</returns>
		public Int32 ToInt32(Object source)
		{
			return ToInt32(source, Int32.MinValue);
		}

        /// <summary>
        /// To the int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int32.</returns>
		public Int32 ToInt32(Object source, Int32 defaultValue)
		{
			if( source is Int32 )
			{
				return (Int32) source;
			}
			
			return defaultValue;
		}

        /// <summary>
        /// To the int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int16.</returns>
        public Int16 ToInt16(Object source)
        {
            return ToInt16(source, Int16.MinValue);
        }

        /// <summary>
        /// To the int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int16.</returns>
        public Int16 ToInt16(Object source, Int16 defaultValue)
        {
            if (source is Int16)
            {
                return (Int16)source;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the null int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        public Int64? ToNullInt64(Object source)
        {
            return ToNullInt64(source, null);
        }

        /// <summary>
        /// To the null int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        public Int64? ToNullInt64(Object source, Int64? defaultValue)
        {
            var l = source as long?;
            return l ?? defaultValue;
        }

        /// <summary>
        /// To the null int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{System.Int32}.</returns>
        public int? ToNullInt32(object source)
        {
            return ToNullInt32(source, null);
        }

        /// <summary>
        /// To the null int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        public Int32? ToNullInt32(Object source, Int32? defaultValue)
        {
            var i = source as int?;
            return i ?? defaultValue;
        }

        /// <summary>
        /// To the null int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        public Int16? ToNullInt16(Object source)
        {
            return ToNullInt16(source, null);
        }

        /// <summary>
        /// To the null int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        public Int16? ToNullInt16(Object source, Int16? defaultValue)
        {
            var s = source as short?;
            return s ?? defaultValue;
        }

        /// <summary>
        /// To the null date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
		public DateTime? ToNullDate(Object source)
		{   
			return ToNullDate( source, null );
		}

        /// <summary>
        /// To the null date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
		public DateTime? ToNullDate(Object source, DateTime? defaultValue)
		{
			if( source is DateTime )
			{
				return (DateTime) source;
			}

			return defaultValue;
		}

        /// <summary>
        /// To the date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>DateTime.</returns>
        public DateTime ToDate(Object source)
        {
            return ToDate(source, DateTime.MinValue);
        }

        /// <summary>
        /// To the date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>DateTime.</returns>
        public DateTime ToDate(Object source, DateTime defaultValue)
        {
            if (source is DateTime)
            {
                return (DateTime)source;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Double.</returns>
        public Double ToDouble(Object source)
		{
			return ToDouble(source, 0.0);
		}

        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Double.</returns>
        public Double ToDouble(Object source, Double defaultValue)
		{
            if (source is Double)
			{
                return (Double)source;
			}

			return defaultValue;
		}

        /// <summary>
        /// To the null double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Double}.</returns>
        public Double? ToNullDouble(Object source)
        {
            return ToNullDouble(source, null);
        }

        /// <summary>
        /// To the null double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Double}.</returns>
        public Double? ToNullDouble(Object source, Double? defaultValue)
        {
            var d = source as double?;
            return d ?? defaultValue;
        }

        /// <summary>
        /// To the decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Decimal.</returns>
		public Decimal ToDecimal(Object source)
		{
			return ToDecimal(source, 0);
		}

        /// <summary>
        /// To the decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Decimal.</returns>
        public Decimal ToDecimal(Object source, Decimal defaultValue)
		{
            if (source is Decimal)
			{
                return (Decimal)source;
			}
			
			return defaultValue;
		}

        /// <summary>
        /// To the null decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        public Decimal? ToNullDecimal(Object source)
        {
            return ToNullDecimal(source, null);
        }

        /// <summary>
        /// To the null decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        public Decimal? ToNullDecimal(Object source, Decimal? defaultValue)
        {
            var @decimal = source as decimal?;
            return @decimal ?? defaultValue;
        }

        /// <summary>
        /// To the bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Boolean.</returns>
		public Boolean ToBool(Object source)
		{
			return ToBool(source, false);
		}

        /// <summary>
        /// To the bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Boolean.</returns>
        public Boolean ToBool(Object source, Boolean defaultValue)
		{
            if (source is Boolean)
			{
                return (Boolean)source;
			}
			
            if( ! IsEmpty(source) )
			{
				switch( Char.ToUpper(source.ToString().Trim()[0]) )
				{
						// Yes, yes, 1, True, true, enabled (unfortunately also Yahoo and Tom)
					case 'Y' :
					case 'T' :
					case '1' :
					case 'E' :
						return true;
						// No, no, 0, False, false, disabled (unfortunately also Next and Frog)
					case '0' :
					case 'N' :
					case 'F' :
					case 'D' :
						return false;
					default:
                        return defaultValue;
				}
			}

			return defaultValue;
		}

        /// <summary>
        /// To the null bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool? ToNullBool(Object source)
        {
            return ToNullBool(source, null);
        }

        /// <summary>
        /// To the null bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool? ToNullBool(Object source, bool? defaultValue)
        {
            var b = source as bool?;
            if (b != null)
            {
                return b;
            }
            
            if (!IsEmpty(source))
            {
                switch (Char.ToUpper(source.ToString().Trim()[0]))
                {
                    // Yes, yes, 1, True, true, enabled (unfortunately also Yahoo and Tom)
                    case 'Y':
                    case 'T':
                    case '1':
                    case 'E':
                        return true;
                    // No, no, 0, False, false, disabled (unfortunately also Next and Frog)
                    case '0':
                    case 'N':
                    case 'F':
                    case 'D':
                        return false;
                    default:
                        return defaultValue;
                }
            }

            return defaultValue;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public string ToString(Object source)
		{
			return ToString(source, String.Empty);
		}

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
		public string ToString(Object source, string defaultValue)
		{
		    var s = source.ToString().Trim() as string;
		    return s ?? defaultValue;
		}

        /// <summary>
        /// To the char.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Char.</returns>
		public Char ToChar(Object source)
		{
			return ToChar(source, ' ');
		}

        /// <summary>
        /// To the char.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Char.</returns>
	    public Char ToChar(Object source, Char defaultValue)
		{

            if (source is Char)
            {
                return (Char) source;
            }

	        return defaultValue;
		}

        /// <summary>
        /// To the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>``0.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
	    public T ToEnum<T>(object source)
	    {
	        throw new NotImplementedException();
	    }
        /// <summary>
        /// To the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>``0.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T ToEnum<T>(object source, T defaultValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// To the null char.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Char}.</returns>
	    public Char? ToNullChar(Object source)
        {
            return ToNullChar(source, null);
        }

        /// <summary>
        /// To the null char.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Char}.</returns>
        public Char? ToNullChar(Object source, Char? defaultValue)
        {
            var c = source as char?;
            return c ?? defaultValue;
        }

        /// <summary>
        /// To the float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Single.</returns>
        public float ToFloat(Object source)
        {
            return ToFloat(source, float.MinValue);
        }

        /// <summary>
        /// To the float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Single.</returns>
        public float ToFloat(Object source, float defaultValue)
        {
            if (source is float)
            {
                return (float)source;
            }

            return defaultValue;
        }

        /// <summary>
        /// To the null float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        public float? ToNullFloat(Object source)
        {
            return ToNullFloat(source, null);
        }

        /// <summary>
        /// To the null float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        public float? ToNullFloat(Object source, float? defaultValue)
        {
            var f = source as float?;
            return f ?? defaultValue;
        }
        
	}
}