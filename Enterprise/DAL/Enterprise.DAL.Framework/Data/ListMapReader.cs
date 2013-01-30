// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ListMapReader.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        /// <summary>
        /// The _data
        /// </summary>
        private List<Dictionary<string, object>> _data;
        /// <summary>
        /// The _position
        /// </summary>
        private int _position = -1;
        /// <summary>
        /// The _closed
        /// </summary>
        private bool _closed;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMapReader"/> class.
        /// </summary>
        public ListMapReader() : this(new List<Dictionary<string, object>>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMapReader"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public ListMapReader( List<Dictionary<string, object>> data )
        {
            _data = data;

            foreach( Dictionary<string, object> result in data )
            {
                NormalizeKeys(result);
            }
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        public List<Dictionary<string, object>> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        /// <summary>
        /// Adds the result.
        /// </summary>
        /// <param name="result">The result.</param>
        public void AddResult( Dictionary<string, object> result )
        {
            NormalizeKeys(result);
            _data.Add(result);
        }

        /// <summary>
        /// Normalizes the keys.
        /// </summary>
        /// <param name="data">The data.</param>
        private static void NormalizeKeys( IDictionary<string, object> data )
        {
            var keys = data.Keys.Where(key => ! data.ContainsKey(key.ToLower())).ToList();

            foreach( var key in keys )
            {
                data[key.ToLower()] = data[key];
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            _closed = true;
        }

        /// <summary>
        /// Closes the <see cref="T:System.Data.IDataReader" /> Object.
        /// </summary>
        public void Close()
        {
            _closed = true;
        }

        /// <summary>
        /// Returns a <see cref="T:System.Data.DataTable" /> that describes the column metadata of the <see cref="T:System.Data.IDataReader" />.
        /// </summary>
        /// <returns>A <see cref="T:System.Data.DataTable" /> that describes the column metadata.</returns>
        public DataTable GetSchemaTable()
        {
            return null;
        }

        /// <summary>
        /// Advances the data reader to the next result, when reading the results of batch SQL statements.
        /// </summary>
        /// <returns>true if there are more rows; otherwise, false.</returns>
        public bool NextResult()
        {
            return false;
        }

        /// <summary>
        /// Advances the <see cref="T:System.Data.IDataReader" /> to the next record.
        /// </summary>
        /// <returns>true if there are more rows; otherwise, false.</returns>
        public bool Read()
        {
            _position++;

            return _position < _data.Count;
        }

        /// <summary>
        /// Gets a value indicating the depth of nesting for the current row.
        /// </summary>
        /// <value>The depth.</value>
        /// <returns>The level of nesting.</returns>
        public int Depth
        {
            get { return 0; }
        }

        /// <summary>
        /// Gets a value indicating whether the data reader is closed.
        /// </summary>
        /// <value><c>true</c> if this instance is closed; otherwise, <c>false</c>.</value>
        /// <returns>true if the data reader is closed; otherwise, false.</returns>
        public bool IsClosed
        {
            get { return _closed; }
        }

        /// <summary>
        /// Gets the number of rows changed, inserted, or deleted by execution of the SQL statement.
        /// </summary>
        /// <value>The records affected.</value>
        /// <returns>The number of rows changed, inserted, or deleted; 0 if no rows were affected or the statement failed; and -1 for SELECT statements.</returns>
        public int RecordsAffected
        {
            get { return _data.Count; }
        }

        /// <summary>
        /// Gets the GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Guid.</returns>
        public Guid GetGuid(string name)
        {
            return Converter.ToGuid(GetValue(name));
        }

        /// <summary>
        /// Gets the GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Guid.</returns>
        public Guid GetGuid(string name, Guid defaultValue)
        {
            return Converter.ToGuid(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the null GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        public Guid? GetNullGuid(string name)
        {
            return Converter.ToGuid(GetValue(name));
        }

        /// <summary>
        /// Gets the null GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        public Guid? GetNullGuid(string name, Guid? defaultValue)
        {
            return Converter.ToNullGuid(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Decimal.</returns>
        public Decimal GetDecimal(string name)
        {
            return Converter.ToDecimal(name);
        }

        /// <summary>
        /// Gets the decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Decimal.</returns>
        public Decimal GetDecimal(string name, Decimal defaultValue)
        {
            return Converter.ToDecimal(name, defaultValue);
        }

        /// <summary>
        /// Gets the null decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        public Decimal? GetNullDecimal(string name)
        {
            return Converter.ToNullDecimal(name);
        }

        /// <summary>
        /// Gets the null decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        public Decimal? GetNullDecimal(string name, Decimal? defaultValue)
        {
            return Converter.ToNullDecimal(name, defaultValue);
        }

        /// <summary>
        /// Gets the int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int16.</returns>
        public Int16 GetInt16(string name)
        {
            return Converter.ToInt16(GetValue(name));
        }

        /// <summary>
        /// Gets the int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int16.</returns>
        public Int16 GetInt16(string name, Int16 defaultValue)
        {
            return Converter.ToInt16(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the null int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        public Int16? GetNullInt16(string name)
        {
            return Converter.ToNullInt16(GetValue(name));
        }

        /// <summary>
        /// Gets the null int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        public Int16? GetNullInt16(string name, Int16? defaultValue)
        {
            return Converter.ToNullInt16(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int32.</returns>
        public Int32 GetInt32(string name)
        {
            return Converter.ToInt32(GetValue(name));
        }

        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int32.</returns>
        public Int32 GetInt32(string name, Int32 defaultValue)
        {
            return Converter.ToInt32(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the null int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        public Int32? GetNullInt32(string name)
        {
            return Converter.ToNullInt32(GetValue(name));
        }

        /// <summary>
        /// Gets the null int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        public Int32? GetNullInt32(string name, Int32? defaultValue)
        {
            return Converter.ToNullInt32(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int64.</returns>
        public Int64 GetInt64(string name)
        {
            return Converter.ToInt64(GetValue(name));
        }

        /// <summary>
        /// Gets the int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int64.</returns>
        public Int64 GetInt64(string name, Int64 defaultValue)
        {
            return Converter.ToInt64(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the null int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        public Int64? GetNullInt64(string name)
        {
            return Converter.ToNullInt64(GetValue(name));
        }

        /// <summary>
        /// Gets the null int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        public Int64? GetNullInt64(string name, Int64? defaultValue)
        {
            return Converter.ToNullInt64(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Double.</returns>
    	public double GetDouble( string name )
    	{
    		return Converter.ToDouble( GetValue( name ) );
    	}

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Double.</returns>
    	public double GetDouble( string name, double defaultValue )
    	{
    		return Converter.ToDouble( GetValue( name ), defaultValue );
    	}

        /// <summary>
        /// Gets the null double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Double}.</returns>
        public double? GetNullDouble(string name)
        {
            return Converter.ToNullDouble(GetValue(name));
        }

        /// <summary>
        /// Gets the null double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Double}.</returns>
        public double? GetNullDouble(string name, double? defaultValue)
        {
            return Converter.ToNullDouble(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
    	public bool GetBool(string name)
        {
            return Converter.ToBool(GetValue(name));
        }

        /// <summary>
        /// Gets the bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Boolean.</returns>
        public bool GetBool(string name, bool defaultValue)
        {
            return Converter.ToBool(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the null bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Boolean}.</returns>
        public bool? GetNullBool(string name)
        {
            return Converter.ToNullBool(GetValue(name));
        }

        /// <summary>
        /// Gets the null bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Boolean}.</returns>
        public bool? GetNullBool(string name, bool? defaultValue)
        {
            return Converter.ToNullBool(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>DateTime.</returns>
        public DateTime GetDate(string name)
        {
            return Converter.ToDate(GetValue(name));
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>DateTime.</returns>
        public DateTime GetDate(string name, DateTime defaultValue)
        {
            return Converter.ToDate(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the null date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        public DateTime? GetNullDate(string name)
        {
            return Converter.ToNullDate(GetValue(name));
        }

        /// <summary>
        /// Gets the null date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        public DateTime? GetNullDate(string name, DateTime? defaultValue)
        {
            return Converter.ToNullDate(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Single.</returns>
        public float GetFloat(string name)
        {
            return Converter.ToFloat(GetValue(name));
        }

        /// <summary>
        /// Gets the float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Single.</returns>
        public float GetFloat(string name, float defaultValue)
        {
            return Converter.ToFloat(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the null float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        public float? GetNullFloat(string name)
        {
            return Converter.ToNullFloat(GetValue(name));
        }

        /// <summary>
        /// Gets the null float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        public float? GetNullFloat(string name, float? defaultValue)
        {
            return Converter.ToNullFloat(GetValue(name), defaultValue);
        }

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>String.</returns>
        public string GetString(string name)
        {
            return Converter.ToString( GetValue(name));
        }

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>String.</returns>
        public string GetString(string name, string defaultValue)
        {
            return Converter.ToString(GetValue(name), defaultValue);
        }


        /// <summary>
        /// Gets the char.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Char.</returns>
    	public char GetChar( string name )
    	{
    		return Converter.ToChar( GetValue( name ) );
    	}

        /// <summary>
        /// Gets the char.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Char.</returns>
    	public char GetChar( string name, char defaultValue )
    	{
    		return Converter.ToChar( GetValue( name ), defaultValue );
    	}

        /// <summary>
        /// Gets the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns>``0.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        T ITypeReader.GetEnum<T>(string name)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>``0.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T GetEnum<T>(string name, T defaultValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Object.</returns>
        private object GetValue(string name)
        {
            string key = name.ToLower();

            return _data[_position].ContainsKey(key) ? _data[_position][key] : DBNull.Value;
        }

        /// <summary>
        /// Gets the name for the field to find.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The name of the field or the empty string (""), if there is no value to return.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetName(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the data type information for the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The data type information for the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the <see cref="T:System.Type" /> information corresponding to the type of <see cref="T:System.Object" /> that would be returned from <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)" />.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The <see cref="T:System.Type" /> information corresponding to the type of <see cref="T:System.Object" /> that would be returned from <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)" />.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Type GetFieldType(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return the value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The <see cref="T:System.Object" /> which will contain the field value upon return.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetValue(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Populates an array of objects with the column values of the current record.
        /// </summary>
        /// <param name="values">An array of <see cref="T:System.Object" /> to copy the attribute fields into.</param>
        /// <returns>The number of instances of <see cref="T:System.Object" /> in the array.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return the index of the named field.
        /// </summary>
        /// <param name="name">The name of the field to find.</param>
        /// <returns>The index of the named field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetOrdinal(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value of the specified column as a Boolean.
        /// </summary>
        /// <param name="i">The zero-based column ordinal.</param>
        /// <returns>The value of the column.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool GetBoolean(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the 8-bit unsigned integer value of the specified column.
        /// </summary>
        /// <param name="i">The zero-based column ordinal.</param>
        /// <returns>The 8-bit unsigned integer value of the specified column.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public byte GetByte(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads a stream of bytes from the specified column offset into the buffer as an array, starting at the given buffer offset.
        /// </summary>
        /// <param name="i">The zero-based column ordinal.</param>
        /// <param name="fieldOffset">The index within the field from which to start the read operation.</param>
        /// <param name="buffer">The buffer into which to read the stream of bytes.</param>
        /// <param name="bufferoffset">The index for <paramref name="buffer" /> to start the read operation.</param>
        /// <param name="length">The number of bytes to read.</param>
        /// <returns>The actual number of bytes read.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the character value of the specified column.
        /// </summary>
        /// <param name="i">The zero-based column ordinal.</param>
        /// <returns>The character value of the specified column.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public char GetChar(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads a stream of characters from the specified column offset into the buffer as an array, starting at the given buffer offset.
        /// </summary>
        /// <param name="i">The zero-based column ordinal.</param>
        /// <param name="fieldoffset">The index within the row from which to start the read operation.</param>
        /// <param name="buffer">The buffer into which to read the stream of bytes.</param>
        /// <param name="bufferoffset">The index for <paramref name="buffer" /> to start the read operation.</param>
        /// <param name="length">The number of bytes to read.</param>
        /// <returns>The actual number of characters read.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the GUID value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The GUID value of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Guid GetGuid(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the 16-bit signed integer value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The 16-bit signed integer value of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public short GetInt16(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the 32-bit signed integer value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The 32-bit signed integer value of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetInt32(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the 64-bit signed integer value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The 64-bit signed integer value of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public long GetInt64(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the single-precision floating point number of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The single-precision floating point number of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public float GetFloat(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the double-precision floating point number of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The double-precision floating point number of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public double GetDouble(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the string value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The string value of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string GetString(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the fixed-position numeric value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The fixed-position numeric value of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public decimal GetDecimal(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the date and time data value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The date and time data value of the specified field.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns an <see cref="T:System.Data.IDataReader" /> for the specified column ordinal.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The <see cref="T:System.Data.IDataReader" /> for the specified column ordinal.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IDataReader GetData(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return whether the specified field is set to null.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>true if the specified field is set to null; otherwise, false.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool IsDBNull(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the number of columns in the current row.
        /// </summary>
        /// <value>The field count.</value>
        /// <returns>When not positioned in a valid recordset, 0; otherwise, the number of columns in the current record. The default is -1.</returns>
        public int FieldCount { get; set; }

        /// <summary>
        /// Gets the column with the specified name.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        object System.Data.IDataRecord.this[int i]
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the column with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Object.</returns>
        public object this[string name]
        {
            get { return GetValue(name); }
        }

        
    }
}