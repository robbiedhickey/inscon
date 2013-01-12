using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// This reader allows iteration of a list of maps.  Because the maps are
    /// keyed by name instead of position, the ordinal retrieval methods will
    /// not work.
    /// </summary>
    public class ListMapReader : ITypeReader
    {
        private List<Dictionary<string, object>> _data;
        private int _position = -1;
        private bool _closed;

        public ListMapReader() : this(new List<Dictionary<string, object>>())
        {
        }

        public ListMapReader( List<Dictionary<string, object>> data )
        {
            _data = data;

            foreach( Dictionary<string, object> result in data )
            {
                NormalizeKeys(result);
            }
        }

        public List<Dictionary<string, object>> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public void AddResult( Dictionary<string, object> result )
        {
            NormalizeKeys(result);
            _data.Add(result);
        }

        private static void NormalizeKeys( IDictionary<string, object> data )
        {
            var keys = data.Keys.Where(key => ! data.ContainsKey(key.ToLower())).ToList();

            foreach( var key in keys )
            {
                data[key.ToLower()] = data[key];
            }
        }

        public void Dispose()
        {
            _closed = true;
        }

        public void Close()
        {
            _closed = true;
        }

        public DataTable GetSchemaTable()
        {
            return null;
        }

        public bool NextResult()
        {
            return false;
        }

        public bool Read()
        {
            _position++;

            return _position < _data.Count;
        }

        public int Depth
        {
            get { return 0; }
        }

        public bool IsClosed
        {
            get { return _closed; }
        }

        public int RecordsAffected
        {
            get { return _data.Count; }
        }

        public Guid GetGuid(string name)
        {
            return Converter.ToGuid(GetValue(name));
        }

        public Guid GetGuid(string name, Guid defaultValue)
        {
            return Converter.ToGuid(GetValue(name), defaultValue);
        }

        public Guid? GetNullGuid(string name)
        {
            return Converter.ToGuid(GetValue(name));
        }

        public Guid? GetNullGuid(string name, Guid? defaultValue)
        {
            return Converter.ToNullGuid(GetValue(name), defaultValue);
        }

        public Decimal GetDecimal(string name)
        {
            return Converter.ToDecimal(name);
        }

        public Decimal GetDecimal(string name, Decimal defaultValue)
        {
            return Converter.ToDecimal(name, defaultValue);
        }

        public Decimal? GetNullDecimal(string name)
        {
            return Converter.ToNullDecimal(name);
        }

        public Decimal? GetNullDecimal(string name, Decimal? defaultValue)
        {
            return Converter.ToNullDecimal(name, defaultValue);
        }

        public Int16 GetInt16(string name)
        {
            return Converter.ToInt16(GetValue(name));
        }

        public Int16 GetInt16(string name, Int16 defaultValue)
        {
            return Converter.ToInt16(GetValue(name), defaultValue);
        }

        public Int16? GetNullInt16(string name)
        {
            return Converter.ToNullInt16(GetValue(name));
        }

        public Int16? GetNullInt16(string name, Int16? defaultValue)
        {
            return Converter.ToNullInt16(GetValue(name), defaultValue);
        }

        public Int32 GetInt32(string name)
        {
            return Converter.ToInt32(GetValue(name));
        }

        public Int32 GetInt32(string name, Int32 defaultValue)
        {
            return Converter.ToInt32(GetValue(name), defaultValue);
        }

        public Int32? GetNullInt32(string name)
        {
            return Converter.ToNullInt32(GetValue(name));
        }

        public Int32? GetNullInt32(string name, Int32? defaultValue)
        {
            return Converter.ToNullInt32(GetValue(name), defaultValue);
        }

        public Int64 GetInt64(string name)
        {
            return Converter.ToInt64(GetValue(name));
        }

        public Int64 GetInt64(string name, Int64 defaultValue)
        {
            return Converter.ToInt64(GetValue(name), defaultValue);
        }

        public Int64? GetNullInt64(string name)
        {
            return Converter.ToNullInt64(GetValue(name));
        }

        public Int64? GetNullInt64(string name, Int64? defaultValue)
        {
            return Converter.ToNullInt64(GetValue(name), defaultValue);
        }

    	public double GetDouble( string name )
    	{
    		return Converter.ToDouble( GetValue( name ) );
    	}

    	public double GetDouble( string name, double defaultValue )
    	{
    		return Converter.ToDouble( GetValue( name ), defaultValue );
    	}

        public double? GetNullDouble(string name)
        {
            return Converter.ToNullDouble(GetValue(name));
        }

        public double? GetNullDouble(string name, double? defaultValue)
        {
            return Converter.ToNullDouble(GetValue(name), defaultValue);
        }

    	public bool GetBool(string name)
        {
            return Converter.ToBool(GetValue(name));
        }

        public bool GetBool(string name, bool defaultValue)
        {
            return Converter.ToBool(GetValue(name), defaultValue);
        }

        public bool? GetNullBool(string name)
        {
            return Converter.ToNullBool(GetValue(name));
        }

        public bool? GetNullBool(string name, bool? defaultValue)
        {
            return Converter.ToNullBool(GetValue(name), defaultValue);
        }

        public DateTime GetDate(string name)
        {
            return Converter.ToDate(GetValue(name));
        }

        public DateTime GetDate(string name, DateTime defaultValue)
        {
            return Converter.ToDate(GetValue(name), defaultValue);
        }

        public DateTime? GetNullDate(string name)
        {
            return Converter.ToNullDate(GetValue(name));
        }

        public DateTime? GetNullDate(string name, DateTime? defaultValue)
        {
            return Converter.ToNullDate(GetValue(name), defaultValue);
        }

        public float GetFloat(string name)
        {
            return Converter.ToFloat(GetValue(name));
        }

        public float GetFloat(string name, float defaultValue)
        {
            return Converter.ToFloat(GetValue(name), defaultValue);
        }

        public float? GetNullFloat(string name)
        {
            return Converter.ToNullFloat(GetValue(name));
        }

        public float? GetNullFloat(string name, float? defaultValue)
        {
            return Converter.ToNullFloat(GetValue(name), defaultValue);
        }

        public string GetString(string name)
        {
            return Converter.ToString( GetValue(name));
        }

        public string GetString(string name, string defaultValue)
        {
            return Converter.ToString(GetValue(name), defaultValue);
        }


    	public char GetChar( string name )
    	{
    		return Converter.ToChar( GetValue( name ) );
    	}

    	public char GetChar( string name, char defaultValue )
    	{
    		return Converter.ToChar( GetValue( name ), defaultValue );
    	}

        T ITypeReader.GetEnum<T>(string name)
        {
            throw new NotImplementedException();
        }
        public T GetEnum<T>(string name, T defaultValue)
        {
            throw new NotImplementedException();
        }

        private object GetValue(string name)
        {
            string key = name.ToLower();

            return _data[_position].ContainsKey(key) ? _data[_position][key] : DBNull.Value;
        }

        public string GetName(int i)
        {
            throw new NotImplementedException();
        }

        public string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        public Type GetFieldType(int i)
        {
            throw new NotImplementedException();
        }

        public object GetValue(int i)
        {
            throw new NotImplementedException();
        }

        public int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }

        public int GetOrdinal(string name)
        {
            throw new NotImplementedException();
        }

        public bool GetBoolean(int i)
        {
            throw new NotImplementedException();
        }

        public byte GetByte(int i)
        {
            throw new NotImplementedException();
        }

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public char GetChar(int i)
        {
            throw new NotImplementedException();
        }

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public Guid GetGuid(int i)
        {
            throw new NotImplementedException();
        }

        public short GetInt16(int i)
        {
            throw new NotImplementedException();
        }

        public int GetInt32(int i)
        {
            throw new NotImplementedException();
        }

        public long GetInt64(int i)
        {
            throw new NotImplementedException();
        }

        public float GetFloat(int i)
        {
            throw new NotImplementedException();
        }

        public double GetDouble(int i)
        {
            throw new NotImplementedException();
        }

        public string GetString(int i)
        {
            throw new NotImplementedException();
        }

        public decimal GetDecimal(int i)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetData(int i)
        {
            throw new NotImplementedException();
        }

        public bool IsDBNull(int i)
        {
            throw new NotImplementedException();
        }

        public int FieldCount { get; set; }

        object System.Data.IDataRecord.this[int i]
        {
            get { throw new NotImplementedException(); }
        }

        public object this[string name]
        {
            get { return GetValue(name); }
        }

        
    }
}