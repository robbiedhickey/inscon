using System;

namespace Enterprise.DAL.Framework
{
    public interface ITypeConverter
    {

        float? ToNullFloat(Object source);
        float? ToNullFloat(Object source, float? defaultValue);

        float ToFloat(Object source);
        float ToFloat(Object source, float defaultValue);

        Double ToDouble(Object source);
        Double ToDouble(Object source, Double defaultValue);

        Double? ToNullDouble(Object source);
        Double? ToNullDouble(Object source, Double? defaultValue);

        Int16 ToInt16(Object source);
        Int16 ToInt16(Object source, Int16 defaultValue);

        Int16? ToNullInt16(Object source);
        Int16? ToNullInt16(Object source, Int16? defaultValue);

        Int32 ToInt32(Object source);
        Int32 ToInt32(Object source, Int32 defaultValue);

        Int32? ToNullInt32(object source);
        Int32? ToNullInt32(Object source, Int32? defaultValue);

        Int64 ToInt64(Object source);
        Int64 ToInt64(Object source, Int64 defaultValue);

        Int64? ToNullInt64(Object source);
        Int64? ToNullInt64(Object source, Int64? defaultValue);

        Boolean ToBool(Object source);
        Boolean ToBool(Object source, Boolean defaultValue);

        Boolean? ToNullBool(Object source);
        Boolean? ToNullBool(Object source, Boolean? defaultValue);

        DateTime? ToNullDate(Object source);
        DateTime? ToNullDate(Object source, DateTime? defaultValue);

        DateTime ToDate(Object source);
        DateTime ToDate(Object source, DateTime defaultValue);

        String ToString(Object source);
        String ToString(Object source, String defaultValue);

        Char ToChar(Object source);
        Char ToChar(Object source, Char defaultValue);

        T ToEnum<T>(Object source);
        T ToEnum<T>(Object source, T defaultValue);

        Guid ToGuid(Object source);
        Guid ToGuid(Object source, Guid defaultValue);

        Guid? ToNullGuid(Object source);
        Guid? ToNullGuid(Object source, Guid? defaultValue);

        Decimal ToDecimal(Object source, Decimal defaultValue);
        Decimal ToDecimal(Object source);

        Decimal? ToNullDecimal(Object source, Decimal? defaultValue);
        Decimal? ToNullDecimal(Object source);


    }
}