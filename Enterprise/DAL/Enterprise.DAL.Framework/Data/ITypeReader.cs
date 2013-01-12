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

        float? GetNullFloat(String name);
        float? GetNullFloat(String name, float? defaultValue);

        float GetFloat(String name);
        float GetFloat(String name, float defaultValue);

        Double GetDouble(String name);
        Double GetDouble(String name, Double defaultValue);

        Double? GetNullDouble(String name);
        Double? GetNullDouble(String name, Double? defaultValue);

        Int16 GetInt16(String name);
        Int16 GetInt16(String name, Int16 defaultValue);

        Int16? GetNullInt16(String name);
        Int16? GetNullInt16(String name, Int16? defaultValue);

        Int32 GetInt32(String name);
        Int32 GetInt32(String name, Int32 defaultValue);

        Int32? GetNullInt32(String name);
        Int32? GetNullInt32(String name, Int32? defaultValue);

        Int64 GetInt64(String name);
        Int64 GetInt64(String name, Int64 defaultValue);

        Int64? GetNullInt64(String name);
        Int64? GetNullInt64(String name, Int64? defaultValue);

        Boolean GetBool(String name);
        Boolean GetBool(String name, Boolean defaultValue);

        Boolean? GetNullBool(String name);
        Boolean? GetNullBool(String name, Boolean? defaultValue);

        DateTime? GetNullDate(String name);
        DateTime? GetNullDate(String name, DateTime? defaultValue);

        DateTime GetDate(String name);
        DateTime GetDate(String name, DateTime defaultValue);

        String GetString(String name);
        String GetString(String name, String defaultValue);

        Char GetChar(String name);
        Char GetChar(String name, Char defaultValue);

        T GetEnum<T>(String name);
        T GetEnum<T>(String name, T defaultValue);

        Guid GetGuid(String name);
        Guid GetGuid(String name, Guid defaultValue);

        Guid? GetNullGuid(String name);
        Guid? GetNullGuid(String name, Guid? defaultValue);

        Decimal GetDecimal(String name, Decimal defaultValue);
        Decimal GetDecimal(String name);

        Decimal? GetNullDecimal(String name, Decimal? defaultValue);
        Decimal? GetNullDecimal(String name);
    }
}