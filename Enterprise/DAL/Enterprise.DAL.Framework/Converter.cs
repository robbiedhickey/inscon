using System;

namespace Enterprise.DAL.Framework
{
	/// <summary>
	/// Static delegate for standard object to type conversions.  The default conversion
	/// strategy is the StandardTypeConverter.
	/// </summary>
	public static class Converter
	{
		private static ITypeConverter _converter = new StandardTypeConverter();

		public static ITypeConverter ConverterInstance
		{
			set { _converter = value; }
			get { return _converter; }
		}

		public static int ToInt(object source)
		{
			return _converter.ToInt(source);
		}

		public static int ToInt(object source, int defaultValue)
		{
			return _converter.ToInt(source, defaultValue);
		}

        public static int? ToNullInt(object source)
        {
            return _converter.ToNullInt(source);
        }

        public static int? ToNullInt(object source, int? defaultValue)
        {
            return _converter.ToNullInt(source, defaultValue);
        }

		public static double ToDouble(object source)
		{
			return _converter.ToDouble( source );
		}

		public static double ToDouble(object source, double defaultValue)
		{
			return _converter.ToDouble( source, defaultValue );
		}

        public static double? ToNullDouble(object source)
        {
            return _converter.ToNullDouble(source);
        }

        public static double? ToNullDouble(object source, double? defaultValue)
        {
            return _converter.ToNullDouble(source, defaultValue);
        }

		public static DateTime? ToDate(object source)
		{
			return _converter.ToDate(source);
		}

		public static DateTime? ToDate(object source, DateTime defaultValue)
		{
			return _converter.ToDate(source, defaultValue);
		}

		public static bool ToBool(object source)
		{
			return _converter.ToBool(source);
		}

		public static bool ToBool(object source, bool defaultValue)
		{
			return _converter.ToBool(source, defaultValue);
		}

        public static bool? ToNullBool(object source)
        {
            return _converter.ToNullBool(source);
        }

        public static bool? ToNullBool(object source, bool? defaultValue)
        {
            return _converter.ToNullBool(source, defaultValue);
        }

		public static string ToString(object source)
		{
			return _converter.ToString(source);
		}

		public static string ToString(object source, string defaultValue)
		{
			return _converter.ToString(source, defaultValue);
		}
        
		public static char ToChar( object source )
		{
			return _converter.ToChar( source );
		}

		public static char ToChar( object source, char defaultValue )
		{
			return _converter.ToChar( source, defaultValue );
		}

        public static Guid ToGuid( object source)
        {
            return _converter.ToGuid(source);
        }

        public static Guid ToGuid( object source, Guid defaultValue)
        {
            return _converter.ToGuid(source, defaultValue);
        }

        public static Decimal ToDecimal(object source)
        {
            return _converter.ToDecimal(source);
        }

        public static Decimal ToDecimal(object source, decimal defaultValue)
        {
            return _converter.ToDecimal(source, defaultValue);
        }

        public static Decimal? ToNullDecimal(object source)
        {
            return _converter.ToNullDecimal(source);
        }

        public static Decimal? ToNullDecimal(object source, decimal? defaultValue)
        {
            return _converter.ToNullDecimal(source, defaultValue);
        }
	}
}