using System;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Wraps a data reader to offer key-based retrieval and automatic data conversion.
    /// </summary>
    public class TypeConvertingReader : ITypeReader
    {
        private readonly IDataReader _reader;
        private readonly ITypeConverter _converter;

        public TypeConvertingReader( IDataReader reader, ITypeConverter converter )
        {
            _reader = reader;
            _converter = converter;
        }

        public void Close()
        {
            _reader.Close();
        }

        public DataTable GetSchemaTable()
        {
            return _reader.GetSchemaTable();
        }

        public bool NextResult()
        {
            return _reader.NextResult();
        }

        public bool Read()
        {
            return _reader.Read();
        }

        public int Depth
        {
            get { return _reader.Depth; }
        }

        public bool IsClosed
        {
            get { return _reader.IsClosed; }
        }

        public int RecordsAffected
        {
            get { return _reader.RecordsAffected; }
        }

        public void Dispose()
        {
            _reader.Dispose();
        }

        public string GetName(int i)
        {
            return _reader.GetName(i);
        }

        public string GetDataTypeName(int i)
        {
            return _reader.GetDataTypeName(i);
        }

        public Type GetFieldType(int i)
        {
            return _reader.GetFieldType(i);
        }

        public object GetValue(int i)
        {
            return _reader.GetValue(i);
        }

        public int GetValues(object[] values)
        {
            return _reader.GetValues(values);
        }

        public int GetOrdinal(string name)
        {
            return _reader.GetOrdinal(name);
        }

        public bool GetBoolean(int i)
        {
            return _converter.ToBool(_reader.GetBoolean(i));
        }

        public bool? GetNullBoolean(int i)
        {
            return _converter.ToNullBool(_reader.GetBoolean(i));
        }

        public byte GetByte(int i)
        {
            return _reader.GetByte(i);
        }

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            return _reader.GetBytes(i, fieldOffset, buffer, bufferoffset, length);
        }

        public char GetChar(int i)
        {
            return _reader.GetChar(i);
        }

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            return _reader.GetChars(i, fieldoffset, buffer, bufferoffset, length);
        }

        public Guid GetGuid(int i)
        {
            return _reader.GetGuid(i);
        }

        public Guid GetGuid(string name)
        {
            return _converter.ToGuid(_reader[name]);
        }

        public Guid GetGuid(String name, Guid defaultValue)
        {
            return _converter.ToGuid(_reader[name], defaultValue);
        }

        public Guid? GetNullGuid(string name)
        {
            return _converter.ToNullGuid(_reader[name]);
        }

        public Guid? GetNullGuid(string name, Guid? defaultValue)
        {
            return _converter.ToNullGuid(_reader[name], defaultValue);
        }


        public short GetInt16(int i)
        {
            return _reader.GetInt16(i);
        }

        public int GetInt32(int i)
        {
            return _converter.ToInt32(_reader.GetInt32(i));
        }

        public long GetInt64(int i)
        {
            return _reader.GetInt64(i);
        }

        public float GetFloat(int i)
        {
            return _reader.GetFloat(i);
        }
        public float GetFloat(string name)
        {
            return _converter.ToFloat( _reader[name] );
        }
        public float GetFloat(string name, float defaultValue)
        {
            return _converter.ToFloat(_reader[name], defaultValue);
        }

        public float? GetNullFloat(string name)
        {
            return _converter.ToNullFloat(_reader[name]);
        }

        public float? GetNullFloat(string name, float? defaultValue)
        {
            return _converter.ToNullFloat(_reader[name], defaultValue);
        }



        public double GetDouble(int i)
        {
            return _reader.GetDouble(i);
        }

        public string GetString(int i)
        {
            return _converter.ToString(_reader.GetString(i));
        }

        public decimal GetDecimal(int i)
        {
            return _reader.GetDecimal(i);
        }

        public decimal GetDecimal(string name)
        {
            return _converter.ToDecimal(_reader[name]);
        }

        public decimal GetDecimal(string name, decimal defaultValue)
        {
            return _converter.ToDecimal(_reader[name], defaultValue);
        }

        public decimal? GetNullDecimal(string name)
        {
            return _converter.ToNullDecimal(_reader[name]);
        }

        public decimal? GetNullDecimal(string name, decimal? defaultValue)
        {
            return _converter.ToNullDecimal(_reader[name], defaultValue);
        }

        public DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }



        public Int16 GetInt16(string name)
        {
            return _converter.ToInt16(_reader[name]);
        }

        public Int16 GetInt16(string name, Int16 defaultValue)
        {
            return _converter.ToInt16(_reader[name], defaultValue);
        }

        public Int16? GetNullInt16(string name)
        {
            return _converter.ToNullInt16(_reader[name]);
        }

        public Int16? GetNullInt16(string name, Int16? defaultValue)
        {
            return _converter.ToNullInt16(_reader[name], defaultValue);
        }

        public int GetInt32(string name)
        {
             return _converter.ToInt32(_reader[name]);
        }

        public int GetInt32(string name, int defaultValue)
        {
            return _converter.ToInt32(_reader[name], defaultValue);
        }

        public int? GetNullInt32(string name)
        {
            return _converter.ToNullInt32(_reader[name]);
        }

        public int? GetNullInt32(string name, int? defaultValue)
        {
            return _converter.ToNullInt32(_reader[name], defaultValue);
        }

        public Int64 GetInt64(string name)
        {
            return _converter.ToInt64(_reader[name]);
        }

        public Int64 GetInt64(string name, Int64 defaultValue)
        {
            return _converter.ToInt64(_reader[name], defaultValue);
        }

        public Int64? GetNullInt64(string name)
        {
            return _converter.ToNullInt64(_reader[name]);
        }

        public Int64? GetNullInt64(string name, Int64? defaultValue)
        {
            return _converter.ToNullInt64(_reader[name], defaultValue);
        }

    	public double GetDouble( string name )
    	{
    		return _converter.ToDouble( _reader[name] );
    	}

    	public double GetDouble( string name, double defaultValue )
    	{
    		return _converter.ToDouble( _reader[name], defaultValue );
    	}

        public double? GetNullDouble(string name)
        {
            return _converter.ToNullDouble(_reader[name]);
        }

        public double? GetNullDouble(string name, double? defaultValue)
        {
            return _converter.ToNullDouble(_reader[name], defaultValue);
        }

    	public bool GetBool(string name)
        {
            return _converter.ToBool(_reader[name]);
        }

        public bool GetBool(string name, bool defaultValue)
        {
            return _converter.ToBool(_reader[name], defaultValue);
        }

        public bool? GetNullBool(string name)
        {
            return _converter.ToNullBool(_reader[name]);
        }

        public bool? GetNullBool(string name, bool? defaultValue)
        {
            return _converter.ToNullBool(_reader[name], defaultValue);
        }

        public DateTime? GetNullDate(string name)
        {
            return _converter.ToNullDate(_reader[name]);
        }

        public DateTime? GetNullDate(string name, DateTime? defaultValue)
        {
            return _converter.ToNullDate(_reader[name], defaultValue);
        }

        public DateTime GetDate(string name)
        {
            return _converter.ToDate(_reader[name]);
        }

        public DateTime GetDate(string name, DateTime defaultValue)
        {
            return _converter.ToDate(_reader[name], defaultValue);
        }

        public string GetString(string name)
        {
            return _converter.ToString(_reader[name]);
        }

        public string GetString(string name, string defaultValue)
        {
            return _converter.ToString(_reader[name], defaultValue);
        }

    	public char GetChar( string name )
    	{
    		return _converter.ToChar( _reader[name] );
    	}

    	public char GetChar( string name, char defaultValue )
    	{
    		return _converter.ToChar( _reader[name], defaultValue );
    	}

    	public T GetEnum<T>( string name )
		{
			return GetEnum( name, default( T ) );
		}

		public T GetEnum<T>( string name, T defaultValue )
		{
			string value = _converter.ToString( _reader[name] );

			return string.IsNullOrEmpty( value ) ? defaultValue :
				(T)Enum.Parse( typeof( T ), value, true );
		}

        public IDataReader GetData(int i)
        {
            return _reader.GetData(i);
        }

        public bool IsDBNull(int i)
        {
            return _reader.IsDBNull(i);
        }

        public int FieldCount
        {
            get { return _reader.FieldCount; }
        }

        public object this[int i]
        {
            get { return _reader[i]; }
        }

        public object this[string name]
        {
            get { return _reader[name]; }
        }
    }
}
