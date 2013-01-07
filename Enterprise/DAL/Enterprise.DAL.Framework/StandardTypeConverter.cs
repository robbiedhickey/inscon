using System;
using System.Globalization;

namespace Enterprise.DAL.Framework
{
	public class StandardTypeConverter : ITypeConverter
	{
		public static bool IsNull(object source)
		{
			return source == null || source == DBNull.Value;
		}

		public static bool IsEmpty(object source)
		{
			return IsNull(source) || source.ToString().Trim() == "";
		}

		public Guid ToGuid(object source)
		{
			if ( source is Guid )
			{
				return (Guid) source;
			}
			
            if( ! IsEmpty(source) )
			{
				try
				{
					return new Guid(source.ToString());
				}
				catch {}
			}

			return Guid.Empty;
		}

        public Guid ToGuid(object source, Guid defaultValue)
        {
            return ToGuid(source, defaultValue);
        }

		public int ToInt(object source)
		{
			return ToInt(source, 0);
		}

		public int ToInt(object source, int defaultValue)
		{
			if( source is int )
			{
				return (int) source;
			}
			
			return defaultValue;
		}

        public int? ToNullInt(object source)
        {
            return ToNullInt(source, null);
        }

        public int? ToNullInt(object source, int? defaultValue)
        {
            if (source is int?)
            {
                return (int?)source;
            }
            
            if (!IsEmpty(source))
            {
                try
                {
                    return Convert.ToInt32(source);
                }
                catch
                {
                }
            }

            return defaultValue;
        }

		public long ToLong(object source)
		{
			return ToLong(source, 0);
		}

		public long ToLong(object source, long defaultValue)
		{
			if( source is long )
			{
				return (long) source;
			}
			
            if( ! IsEmpty(source) )
			{
				try
				{
					return long.Parse(source.ToString());
				}
				catch
				{
				}
			}

			return defaultValue;
		}

        public long? ToNullLong(object source)
        {
            return ToNullLong(source, null);
        }

        public long? ToNullLong(object source, long? defaultValue)
        {
            if (source is long?)
            {
                return (long?)source;
            }
            
            if (!IsEmpty(source))
            {
                try
                {
                    return long.Parse(source.ToString());
                }
                catch
                {
                }
            }

            return defaultValue;
        }

		public DateTime? ToDate(object source)
		{   
			return ToDate( source, null );
		}

		public DateTime? ToDate(object source, DateTime? defaultValue)
		{
			if( source is DateTime )
			{
				return (DateTime) source;
			}
			
            if( ! IsEmpty( source ) )
			{
				try
				{
					//return DateTime.Parse(source.ToString());
                    return null;
                    
				}
				catch {}
			}

			return defaultValue;
		}

		public double ToDouble(object source)
		{
			return ToDouble(source, 0.0);
		}

		public double ToDouble(object source, double defaultValue)
		{
			if( source is double )
			{
				return (double) source;
			}
			
            if (!IsEmpty(source))
			{
				try
				{
					return Convert.ToDouble( source.ToString(), CultureInfo.InvariantCulture );
				}
				catch { }
			}

			return defaultValue;
		}

        public double? ToNullDouble(object source)
        {
            return ToNullDouble(source, null);
        }

        public double? ToNullDouble(object source, double? defaultValue)
        {
            if (source is double?)
            {
                return (double?)source;
            }
            
            if (!IsEmpty(source))
            {
                try
                {
                    return Convert.ToDouble(source.ToString(), CultureInfo.InvariantCulture);
                }
                catch { }
            }

            return defaultValue;
        }

		public decimal ToDecimal(object source)
		{
			return ToDecimal(source, 0);
		}

		public decimal ToDecimal(object source, decimal defaultValue)
		{
			if( source is decimal )
			{
				return (decimal) source;
			}
			
            if( ! IsEmpty(source) )
			{
				try
				{
					return Convert.ToDecimal(source.ToString(), CultureInfo.InvariantCulture );
				}
				catch {}
			}

			return defaultValue;
		}

        public decimal? ToNullDecimal(object source)
        {
            return ToNullDecimal(source, null);
        }

        public decimal? ToNullDecimal(object source, decimal? defaultValue)
        {
            if (source is decimal?)
            {
                return (decimal?)source;
            }
            
            if (! IsEmpty(source))
            {
                try
                {
                    return Convert.ToDecimal(source.ToString(), CultureInfo.InvariantCulture);
                }
                catch { }
            }

            return defaultValue;
        }

		public bool ToBool(object source)
		{
			return ToBool(source, false);
		}

		public bool ToBool(object source, bool defaultValue)
		{
			if( source is bool )
			{
				return (bool) source;
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
						// No, no, 0, False, false, disabled (unfortunately also Next and Fred)
					case '0' :
					case 'N' :
					case 'F' :
					case 'D' :
						return false;
					default:
						try
						{
							return Convert.ToBoolean(source);
						} 
						catch {}
						break;
				}
			}

			return defaultValue;
		}

        public bool? ToNullBool(object source)
        {
            return ToNullBool(source, null);
        }

        public bool? ToNullBool(object source, bool? defaultValue)
        {
            if (source is bool?)
            {
                return (bool?)source;
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
                    // No, no, 0, False, false, disabled (unfortunately also Next and Fred)
                    case '0':
                    case 'N':
                    case 'F':
                    case 'D':
                        return false;
                    default:
                        try
                        {
                            return Convert.ToBoolean(source);
                        }
                        catch
                        {
                            // Do nothing with exception
                        }
                        break;
                }
            }

            return defaultValue;
        }

		public string ToString(object source)
		{
			return ToString(source, "");
		}

		public string ToString(object source, string defaultValue)
		{
			return ToString(source, defaultValue, false);
		}

		public string ToString(object source, string defaultValue, bool defaultForBlank)
		{
			if ( IsNull( source ) )
			{
				return defaultValue;
			}
			
            return source.ToString().Trim() == "" && defaultForBlank ? defaultValue : source.ToString();

		}

		/// <summary>
		/// Converts the object passed into character
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public char ToChar(object source)
		{
			return ToChar(source, ' ');
		}

		/// <summary>
		/// Converts the object passed into character if unable to 
		/// convert then return the default value.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		public char ToChar(object source, char defaultValue)
		{
			return ToChar(source, defaultValue, false);
		}

		/// <summary>
		/// Converts the object passed into character if unable to 
		/// convert then return the default value if defaultForBlank is false
		/// otherwise if defaultForBlank is true then retun blank 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="defaultValue"></param>
		/// <param name="defaultForBlank"></param>
		/// <returns></returns>
		public char ToChar(object source, char defaultValue, bool defaultForBlank)
		{
			if( source is char )
			{
				return (char) source == ' ' && defaultForBlank ? defaultValue : (char) source;
			}
			
            if( ! IsNull(source) )
			{
				try
				{
					var value = Convert.ToChar(source);

					return value == ' ' && defaultForBlank ? defaultValue : value;
				}
				
                catch
                {}
			}

			return defaultValue;
		}

        
	}
}