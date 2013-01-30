// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ITypeReader.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// A data reader capable of intelligently converting sourced
    /// values to specific types.
    /// </summary>
    public interface ITypeReader : IDataReader
	{

        /// <summary>
        /// Gets the null float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        float? GetNullFloat(String name);
        /// <summary>
        /// Gets the null float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        float? GetNullFloat(String name, float? defaultValue);

        /// <summary>
        /// Gets the float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Single.</returns>
        float GetFloat(String name);
        /// <summary>
        /// Gets the float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Single.</returns>
        float GetFloat(String name, float defaultValue);

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Double.</returns>
        Double GetDouble(String name);
        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Double.</returns>
        Double GetDouble(String name, Double defaultValue);

        /// <summary>
        /// Gets the null double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Double}.</returns>
        Double? GetNullDouble(String name);
        /// <summary>
        /// Gets the null double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Double}.</returns>
        Double? GetNullDouble(String name, Double? defaultValue);

        /// <summary>
        /// Gets the int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int16.</returns>
        Int16 GetInt16(String name);
        /// <summary>
        /// Gets the int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int16.</returns>
        Int16 GetInt16(String name, Int16 defaultValue);

        /// <summary>
        /// Gets the null int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        Int16? GetNullInt16(String name);
        /// <summary>
        /// Gets the null int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        Int16? GetNullInt16(String name, Int16? defaultValue);

        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int32.</returns>
        Int32 GetInt32(String name);
        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int32.</returns>
        Int32 GetInt32(String name, Int32 defaultValue);

        /// <summary>
        /// Gets the null int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        Int32? GetNullInt32(String name);
        /// <summary>
        /// Gets the null int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        Int32? GetNullInt32(String name, Int32? defaultValue);

        /// <summary>
        /// Gets the int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int64.</returns>
        Int64 GetInt64(String name);
        /// <summary>
        /// Gets the int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int64.</returns>
        Int64 GetInt64(String name, Int64 defaultValue);

        /// <summary>
        /// Gets the null int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        Int64? GetNullInt64(String name);
        /// <summary>
        /// Gets the null int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        Int64? GetNullInt64(String name, Int64? defaultValue);

        /// <summary>
        /// Gets the bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        Boolean GetBool(String name);
        /// <summary>
        /// Gets the bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Boolean.</returns>
        Boolean GetBool(String name, Boolean defaultValue);

        /// <summary>
        /// Gets the null bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Boolean}.</returns>
        Boolean? GetNullBool(String name);
        /// <summary>
        /// Gets the null bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Boolean}.</returns>
        Boolean? GetNullBool(String name, Boolean? defaultValue);

        /// <summary>
        /// Gets the null date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        DateTime? GetNullDate(String name);
        /// <summary>
        /// Gets the null date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        DateTime? GetNullDate(String name, DateTime? defaultValue);

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>DateTime.</returns>
        DateTime GetDate(String name);
        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>DateTime.</returns>
        DateTime GetDate(String name, DateTime defaultValue);

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>String.</returns>
        String GetString(String name);
        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>String.</returns>
        String GetString(String name, String defaultValue);

        /// <summary>
        /// Gets the char.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Char.</returns>
        Char GetChar(String name);
        /// <summary>
        /// Gets the char.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Char.</returns>
        Char GetChar(String name, Char defaultValue);

        /// <summary>
        /// Gets the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns>``0.</returns>
        T GetEnum<T>(String name);
        /// <summary>
        /// Gets the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>``0.</returns>
        T GetEnum<T>(String name, T defaultValue);

        /// <summary>
        /// Gets the GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Guid.</returns>
        Guid GetGuid(String name);
        /// <summary>
        /// Gets the GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Guid.</returns>
        Guid GetGuid(String name, Guid defaultValue);

        /// <summary>
        /// Gets the null GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        Guid? GetNullGuid(String name);
        /// <summary>
        /// Gets the null GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        Guid? GetNullGuid(String name, Guid? defaultValue);

        /// <summary>
        /// Gets the decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Decimal.</returns>
        Decimal GetDecimal(String name, Decimal defaultValue);
        /// <summary>
        /// Gets the decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Decimal.</returns>
        Decimal GetDecimal(String name);

        /// <summary>
        /// Gets the null decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        Decimal? GetNullDecimal(String name, Decimal? defaultValue);
        /// <summary>
        /// Gets the null decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        Decimal? GetNullDecimal(String name);
    }
}