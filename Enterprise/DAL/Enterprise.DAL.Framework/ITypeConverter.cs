// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ITypeConverter.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Enterprise.DAL.Framework
{
    /// <summary>
    /// Interface ITypeConverter
    /// </summary>
    public interface ITypeConverter
    {

        /// <summary>
        /// To the null float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        float? ToNullFloat(Object source);
        /// <summary>
        /// To the null float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        float? ToNullFloat(Object source, float? defaultValue);

        /// <summary>
        /// To the float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Single.</returns>
        float ToFloat(Object source);
        /// <summary>
        /// To the float.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Single.</returns>
        float ToFloat(Object source, float defaultValue);

        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Double.</returns>
        Double ToDouble(Object source);
        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Double.</returns>
        Double ToDouble(Object source, Double defaultValue);

        /// <summary>
        /// To the null double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Double}.</returns>
        Double? ToNullDouble(Object source);
        /// <summary>
        /// To the null double.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Double}.</returns>
        Double? ToNullDouble(Object source, Double? defaultValue);

        /// <summary>
        /// To the int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int16.</returns>
        Int16 ToInt16(Object source);
        /// <summary>
        /// To the int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int16.</returns>
        Int16 ToInt16(Object source, Int16 defaultValue);

        /// <summary>
        /// To the null int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        Int16? ToNullInt16(Object source);
        /// <summary>
        /// To the null int16.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        Int16? ToNullInt16(Object source, Int16? defaultValue);

        /// <summary>
        /// To the int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int32.</returns>
        Int32 ToInt32(Object source);
        /// <summary>
        /// To the int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int32.</returns>
        Int32 ToInt32(Object source, Int32 defaultValue);

        /// <summary>
        /// To the null int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        Int32? ToNullInt32(object source);
        /// <summary>
        /// To the null int32.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        Int32? ToNullInt32(Object source, Int32? defaultValue);

        /// <summary>
        /// To the int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Int64.</returns>
        Int64 ToInt64(Object source);
        /// <summary>
        /// To the int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int64.</returns>
        Int64 ToInt64(Object source, Int64 defaultValue);

        /// <summary>
        /// To the null int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        Int64? ToNullInt64(Object source);
        /// <summary>
        /// To the null int64.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        Int64? ToNullInt64(Object source, Int64? defaultValue);

        /// <summary>
        /// To the bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Boolean.</returns>
        Boolean ToBool(Object source);
        /// <summary>
        /// To the bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Boolean.</returns>
        Boolean ToBool(Object source, Boolean defaultValue);

        /// <summary>
        /// To the null bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Boolean}.</returns>
        Boolean? ToNullBool(Object source);
        /// <summary>
        /// To the null bool.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Boolean}.</returns>
        Boolean? ToNullBool(Object source, Boolean? defaultValue);

        /// <summary>
        /// To the null date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        DateTime? ToNullDate(Object source);
        /// <summary>
        /// To the null date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        DateTime? ToNullDate(Object source, DateTime? defaultValue);

        /// <summary>
        /// To the date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>DateTime.</returns>
        DateTime ToDate(Object source);
        /// <summary>
        /// To the date.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>DateTime.</returns>
        DateTime ToDate(Object source, DateTime defaultValue);

        /// <summary>
        /// To the string.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>String.</returns>
        String ToString(Object source);
        /// <summary>
        /// To the string.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>String.</returns>
        String ToString(Object source, String defaultValue);

        /// <summary>
        /// To the char.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Char.</returns>
        Char ToChar(Object source);
        /// <summary>
        /// To the char.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Char.</returns>
        Char ToChar(Object source, Char defaultValue);

        /// <summary>
        /// To the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>``0.</returns>
        T ToEnum<T>(Object source);
        /// <summary>
        /// To the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>``0.</returns>
        T ToEnum<T>(Object source, T defaultValue);

        /// <summary>
        /// To the GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Guid.</returns>
        Guid ToGuid(Object source);
        /// <summary>
        /// To the GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Guid.</returns>
        Guid ToGuid(Object source, Guid defaultValue);

        /// <summary>
        /// To the null GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        Guid? ToNullGuid(Object source);
        /// <summary>
        /// To the null GUID.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        Guid? ToNullGuid(Object source, Guid? defaultValue);

        /// <summary>
        /// To the decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Decimal.</returns>
        Decimal ToDecimal(Object source, Decimal defaultValue);
        /// <summary>
        /// To the decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Decimal.</returns>
        Decimal ToDecimal(Object source);

        /// <summary>
        /// To the null decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        Decimal? ToNullDecimal(Object source, Decimal? defaultValue);
        /// <summary>
        /// To the null decimal.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        Decimal? ToNullDecimal(Object source);


    }
}