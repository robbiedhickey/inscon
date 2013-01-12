using System;

namespace Enterprise.DAL.Framework
{
	public class StandardTypeConverter : ITypeConverter
	{
		public static bool IsNull(Object source)
		{
			return source == null || source == DBNull.Value;
		}

		public static bool IsEmpty(Object source)
		{
			return IsNull(source) || source.ToString().Trim() == "";
		}

	    public Guid ToGuid(Object source)
		{
		    return ToGuid(source, Guid.Empty);
		}

        public Guid ToGuid(Object source, Guid defaultValue)
        {

            if (source is Guid)
            {
                return (Guid)source;
            }

            return defaultValue;
        }

        public Guid? ToNullGuid(Object source)
        {
            return ToNullGuid(source, null);
        }

        public Guid? ToNullGuid(Object source, Guid? defaultValue)
        {

            if (source is Guid)
            {
                return (Guid)source;
            }

            return defaultValue;
        }

        public Int64 ToInt64(Object source)
        {
            return ToInt64(source, Int64.MinValue);
        }

        public Int64 ToInt64(Object source, Int64 defaultValue)
        {
            if (source is Int64)
            {
                return (Int64)source;
            }

            return defaultValue;
        }

		public Int32 ToInt32(Object source)
		{
			return ToInt32(source, Int32.MinValue);
		}

		public Int32 ToInt32(Object source, Int32 defaultValue)
		{
			if( source is Int32 )
			{
				return (Int32) source;
			}
			
			return defaultValue;
		}

        public Int16 ToInt16(Object source)
        {
            return ToInt16(source, Int16.MinValue);
        }

        public Int16 ToInt16(Object source, Int16 defaultValue)
        {
            if (source is Int16)
            {
                return (Int16)source;
            }

            return defaultValue;
        }

        public Int64? ToNullInt64(Object source)
        {
            return ToNullInt64(source, null);
        }

        public Int64? ToNullInt64(Object source, Int64? defaultValue)
        {
            var l = source as long?;
            return l ?? defaultValue;
        }

        public int? ToNullInt32(object source)
        {
            return ToNullInt32(source, null);
        }

        public Int32? ToNullInt32(Object source, Int32? defaultValue)
        {
            var i = source as int?;
            return i ?? defaultValue;
        }

        public Int16? ToNullInt16(Object source)
        {
            return ToNullInt16(source, null);
        }

        public Int16? ToNullInt16(Object source, Int16? defaultValue)
        {
            var s = source as short?;
            return s ?? defaultValue;
        }

		public DateTime? ToNullDate(Object source)
		{   
			return ToNullDate( source, null );
		}

		public DateTime? ToNullDate(Object source, DateTime? defaultValue)
		{
			if( source is DateTime )
			{
				return (DateTime) source;
			}

			return defaultValue;
		}

        public DateTime ToDate(Object source)
        {
            return ToDate(source, DateTime.MinValue);
        }

        public DateTime ToDate(Object source, DateTime defaultValue)
        {
            if (source is DateTime)
            {
                return (DateTime)source;
            }

            return defaultValue;
        }

        public Double ToDouble(Object source)
		{
			return ToDouble(source, 0.0);
		}

        public Double ToDouble(Object source, Double defaultValue)
		{
            if (source is Double)
			{
                return (Double)source;
			}

			return defaultValue;
		}

        public Double? ToNullDouble(Object source)
        {
            return ToNullDouble(source, null);
        }

        public Double? ToNullDouble(Object source, Double? defaultValue)
        {
            var d = source as double?;
            return d ?? defaultValue;
        }

		public Decimal ToDecimal(Object source)
		{
			return ToDecimal(source, 0);
		}

        public Decimal ToDecimal(Object source, Decimal defaultValue)
		{
            if (source is Decimal)
			{
                return (Decimal)source;
			}
			
			return defaultValue;
		}

        public Decimal? ToNullDecimal(Object source)
        {
            return ToNullDecimal(source, null);
        }

        public Decimal? ToNullDecimal(Object source, Decimal? defaultValue)
        {
            var @decimal = source as decimal?;
            return @decimal ?? defaultValue;
        }

		public Boolean ToBool(Object source)
		{
			return ToBool(source, false);
		}

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

        public bool? ToNullBool(Object source)
        {
            return ToNullBool(source, null);
        }

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

		public string ToString(Object source)
		{
			return ToString(source, String.Empty);
		}

		public string ToString(Object source, string defaultValue)
		{
		    var s = source as string;
		    return s ?? defaultValue;
		}

		public Char ToChar(Object source)
		{
			return ToChar(source, ' ');
		}

	    public Char ToChar(Object source, Char defaultValue)
		{

            if (source is Char)
            {
                return (Char) source;
            }

	        return defaultValue;
		}

	    public T ToEnum<T>(object source)
	    {
	        throw new NotImplementedException();
	    }
        public T ToEnum<T>(object source, T defaultValue)
        {
            throw new NotImplementedException();
        }

	    public Char? ToNullChar(Object source)
        {
            return ToNullChar(source, null);
        }

        public Char? ToNullChar(Object source, Char? defaultValue)
        {
            var c = source as char?;
            return c ?? defaultValue;
        }

        public float ToFloat(Object source)
        {
            return ToFloat(source, float.MinValue);
        }

        public float ToFloat(Object source, float defaultValue)
        {
            if (source is float)
            {
                return (float)source;
            }

            return defaultValue;
        }

        public float? ToNullFloat(Object source)
        {
            return ToNullFloat(source, null);
        }

        public float? ToNullFloat(Object source, float? defaultValue)
        {
            var f = source as float?;
            return f ?? defaultValue;
        }
        
	}
}