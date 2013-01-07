using System;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
	/// <summary>
	/// A data reader capable of intelligently converting named
	/// values to specific types.
	/// </summary>
    public interface ITypeReader : IDataReader
    {
        int GetInt(string name);
        int GetInt(string name, int defaultValue);
        int? GetNullInt(string name);
        int? GetNullInt(string name, int? defaultValue);
		double GetDouble( string name );
		double GetDouble( string name, double defaultValue );
        double? GetNullDouble(string name);
        double? GetNullDouble(string name, double? defaultValue);
        bool GetBool(string name);
        bool GetBool(string name, bool defaultValue);
        bool? GetNullBool(string name);
        bool? GetNullBool(string name, bool? defaultValue);
        DateTime? GetDate(string name);
        DateTime? GetDate(string name, DateTime defaultValue);
        string GetString(string name);
        string GetString(string name, string defaultValue);
    	char GetChar( string name );
    	char GetChar( string name, char defaultValue );
		T GetEnum<T>( string name );
		T GetEnum<T>( string name, T defaultValue );
        Guid GetGuid(string name, Guid defaultValue);
        Guid GetGuid(string name);
        Decimal GetDecimal(string name, Decimal defaultValue);
        Decimal GetDecimal(string name);
        Decimal? GetNullDecimal(string name, Decimal? defaultValue);
        Decimal? GetNullDecimal(string name);
    }
}