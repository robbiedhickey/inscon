// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="TypeConvertingReader.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Class TypeConvertingReader
    /// </summary>
    public class TypeConvertingReader : ITypeReader
    {
        /// <summary>
        /// The _reader
        /// </summary>
        private readonly IDataReader _reader;
        /// <summary>
        /// The _converter
        /// </summary>
        private readonly ITypeConverter _converter;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeConvertingReader"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="converter">The converter.</param>
        public TypeConvertingReader( IDataReader reader, ITypeConverter converter )
        {
            _reader = reader;
            _converter = converter;
        }

        /// <summary>
        /// Closes the <see cref="T:System.Data.IDataReader" /> Object.
        /// </summary>
        public void Close()
        {
            _reader.Close();
        }

        /// <summary>
        /// Returns a <see cref="T:System.Data.DataTable" /> that describes the column metadata of the <see cref="T:System.Data.IDataReader" />.
        /// </summary>
        /// <returns>A <see cref="T:System.Data.DataTable" /> that describes the column metadata.</returns>
        public DataTable GetSchemaTable()
        {
            return _reader.GetSchemaTable();
        }

        /// <summary>
        /// Advances the data reader to the next result, when reading the results of batch SQL statements.
        /// </summary>
        /// <returns>true if there are more rows; otherwise, false.</returns>
        public bool NextResult()
        {
            return _reader.NextResult();
        }

        /// <summary>
        /// Advances the <see cref="T:System.Data.IDataReader" /> to the next record.
        /// </summary>
        /// <returns>true if there are more rows; otherwise, false.</returns>
        public bool Read()
        {
            return _reader.Read();
        }

        /// <summary>
        /// Gets a value indicating the depth of nesting for the current row.
        /// </summary>
        /// <value>The depth.</value>
        /// <returns>The level of nesting.</returns>
        public int Depth
        {
            get { return _reader.Depth; }
        }

        /// <summary>
        /// Gets a value indicating whether the data reader is closed.
        /// </summary>
        /// <value><c>true</c> if this instance is closed; otherwise, <c>false</c>.</value>
        /// <returns>true if the data reader is closed; otherwise, false.</returns>
        public bool IsClosed
        {
            get { return _reader.IsClosed; }
        }

        /// <summary>
        /// Gets the number of rows changed, inserted, or deleted by execution of the SQL statement.
        /// </summary>
        /// <value>The records affected.</value>
        /// <returns>The number of rows changed, inserted, or deleted; 0 if no rows were affected or the statement failed; and -1 for SELECT statements.</returns>
        public int RecordsAffected
        {
            get { return _reader.RecordsAffected; }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            _reader.Dispose();
        }

        /// <summary>
        /// Gets the name for the field to find.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The name of the field or the empty string (""), if there is no value to return.</returns>
        public string GetName(int i)
        {
            return _reader.GetName(i);
        }

        /// <summary>
        /// Gets the data type information for the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The data type information for the specified field.</returns>
        public string GetDataTypeName(int i)
        {
            return _reader.GetDataTypeName(i);
        }

        /// <summary>
        /// Gets the <see cref="T:System.Type" /> information corresponding to the type of <see cref="T:System.Object" /> that would be returned from <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)" />.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The <see cref="T:System.Type" /> information corresponding to the type of <see cref="T:System.Object" /> that would be returned from <see cref="M:System.Data.IDataRecord.GetValue(System.Int32)" />.</returns>
        public Type GetFieldType(int i)
        {
            return _reader.GetFieldType(i);
        }

        /// <summary>
        /// Return the value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The <see cref="T:System.Object" /> which will contain the field value upon return.</returns>
        public object GetValue(int i)
        {
            return _reader.GetValue(i);
        }

        /// <summary>
        /// Populates an array of objects with the column values of the current record.
        /// </summary>
        /// <param name="values">An array of <see cref="T:System.Object" /> to copy the attribute fields into.</param>
        /// <returns>The number of instances of <see cref="T:System.Object" /> in the array.</returns>
        public int GetValues(object[] values)
        {
            return _reader.GetValues(values);
        }

        /// <summary>
        /// Return the index of the named field.
        /// </summary>
        /// <param name="name">The name of the field to find.</param>
        /// <returns>The index of the named field.</returns>
        public int GetOrdinal(string name)
        {
            return _reader.GetOrdinal(name);
        }

        /// <summary>
        /// Gets the value of the specified column as a Boolean.
        /// </summary>
        /// <param name="i">The zero-based column ordinal.</param>
        /// <returns>The value of the column.</returns>
        public bool GetBoolean(int i)
        {
            return _converter.ToBool(_reader.GetBoolean(i));
        }

        /// <summary>
        /// Gets the null boolean.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public bool? GetNullBoolean(int i)
        {
            return _converter.ToNullBool(_reader.GetBoolean(i));
        }

        /// <summary>
        /// Gets the 8-bit unsigned integer value of the specified column.
        /// </summary>
        /// <param name="i">The zero-based column ordinal.</param>
        /// <returns>The 8-bit unsigned integer value of the specified column.</returns>
        public byte GetByte(int i)
        {
            return _reader.GetByte(i);
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
        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            return _reader.GetBytes(i, fieldOffset, buffer, bufferoffset, length);
        }

        /// <summary>
        /// Gets the character value of the specified column.
        /// </summary>
        /// <param name="i">The zero-based column ordinal.</param>
        /// <returns>The character value of the specified column.</returns>
        public char GetChar(int i)
        {
            return _reader.GetChar(i);
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
        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            return _reader.GetChars(i, fieldoffset, buffer, bufferoffset, length);
        }

        /// <summary>
        /// Returns the GUID value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The GUID value of the specified field.</returns>
        public Guid GetGuid(int i)
        {
            return _reader.GetGuid(i);
        }

        /// <summary>
        /// Gets the GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Guid.</returns>
        public Guid GetGuid(string name)
        {
            return _converter.ToGuid(_reader[name]);
        }

        /// <summary>
        /// Gets the GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Guid.</returns>
        public Guid GetGuid(String name, Guid defaultValue)
        {
            return _converter.ToGuid(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the null GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        public Guid? GetNullGuid(string name)
        {
            return _converter.ToNullGuid(_reader[name]);
        }

        /// <summary>
        /// Gets the null GUID.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Guid}.</returns>
        public Guid? GetNullGuid(string name, Guid? defaultValue)
        {
            return _converter.ToNullGuid(_reader[name], defaultValue);
        }


        /// <summary>
        /// Gets the 16-bit signed integer value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The 16-bit signed integer value of the specified field.</returns>
        public short GetInt16(int i)
        {
            return _reader.GetInt16(i);
        }

        /// <summary>
        /// Gets the 32-bit signed integer value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The 32-bit signed integer value of the specified field.</returns>
        public int GetInt32(int i)
        {
            return _converter.ToInt32(_reader.GetInt32(i));
        }

        /// <summary>
        /// Gets the 64-bit signed integer value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The 64-bit signed integer value of the specified field.</returns>
        public long GetInt64(int i)
        {
            return _reader.GetInt64(i);
        }

        /// <summary>
        /// Gets the single-precision floating point number of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The single-precision floating point number of the specified field.</returns>
        public float GetFloat(int i)
        {
            return _reader.GetFloat(i);
        }
        /// <summary>
        /// Gets the float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Single.</returns>
        public float GetFloat(string name)
        {
            return _converter.ToFloat( _reader[name] );
        }
        /// <summary>
        /// Gets the float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Single.</returns>
        public float GetFloat(string name, float defaultValue)
        {
            return _converter.ToFloat(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the null float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        public float? GetNullFloat(string name)
        {
            return _converter.ToNullFloat(_reader[name]);
        }

        /// <summary>
        /// Gets the null float.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{System.Single}.</returns>
        public float? GetNullFloat(string name, float? defaultValue)
        {
            return _converter.ToNullFloat(_reader[name], defaultValue);
        }



        /// <summary>
        /// Gets the double-precision floating point number of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The double-precision floating point number of the specified field.</returns>
        public double GetDouble(int i)
        {
            return _reader.GetDouble(i);
        }

        /// <summary>
        /// Gets the string value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The string value of the specified field.</returns>
        public string GetString(int i)
        {
            return _converter.ToString(_reader.GetString(i)).Trim();
        }

        /// <summary>
        /// Gets the fixed-position numeric value of the specified field.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The fixed-position numeric value of the specified field.</returns>
        public decimal GetDecimal(int i)
        {
            return _reader.GetDecimal(i);
        }

        /// <summary>
        /// Gets the decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Decimal.</returns>
        public decimal GetDecimal(string name)
        {
            return _converter.ToDecimal(_reader[name]);
        }

        /// <summary>
        /// Gets the decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Decimal.</returns>
        public decimal GetDecimal(string name, decimal defaultValue)
        {
            return _converter.ToDecimal(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the null decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        public decimal? GetNullDecimal(string name)
        {
            return _converter.ToNullDecimal(_reader[name]);
        }

        /// <summary>
        /// Gets the null decimal.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Decimal}.</returns>
        public decimal? GetNullDecimal(string name, decimal? defaultValue)
        {
            return _converter.ToNullDecimal(_reader[name], defaultValue);
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
        /// Gets the int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int16.</returns>
        public Int16 GetInt16(string name)
        {
            return _converter.ToInt16(_reader[name]);
        }

        /// <summary>
        /// Gets the int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int16.</returns>
        public Int16 GetInt16(string name, Int16 defaultValue)
        {
            return _converter.ToInt16(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the null int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        public Int16? GetNullInt16(string name)
        {
            return _converter.ToNullInt16(_reader[name]);
        }

        /// <summary>
        /// Gets the null int16.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int16}.</returns>
        public Int16? GetNullInt16(string name, Int16? defaultValue)
        {
            return _converter.ToNullInt16(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int32.</returns>
        public int GetInt32(string name)
        {
             return _converter.ToInt32(_reader[name]);
        }

        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int32.</returns>
        public int GetInt32(string name, int defaultValue)
        {
            return _converter.ToInt32(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the null int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        public int? GetNullInt32(string name)
        {
            return _converter.ToNullInt32(_reader[name]);
        }

        /// <summary>
        /// Gets the null int32.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int32}.</returns>
        public int? GetNullInt32(string name, int? defaultValue)
        {
            return _converter.ToNullInt32(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Int64.</returns>
        public Int64 GetInt64(string name)
        {
            return _converter.ToInt64(_reader[name]);
        }

        /// <summary>
        /// Gets the int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Int64.</returns>
        public Int64 GetInt64(string name, Int64 defaultValue)
        {
            return _converter.ToInt64(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the null int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        public Int64? GetNullInt64(string name)
        {
            return _converter.ToNullInt64(_reader[name]);
        }

        /// <summary>
        /// Gets the null int64.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Int64}.</returns>
        public Int64? GetNullInt64(string name, Int64? defaultValue)
        {
            return _converter.ToNullInt64(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Double.</returns>
    	public double GetDouble( string name )
    	{
    		return _converter.ToDouble( _reader[name] );
    	}

        /// <summary>
        /// Gets the double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Double.</returns>
    	public double GetDouble( string name, double defaultValue )
    	{
    		return _converter.ToDouble( _reader[name], defaultValue );
    	}

        /// <summary>
        /// Gets the null double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Double}.</returns>
        public double? GetNullDouble(string name)
        {
            return _converter.ToNullDouble(_reader[name]);
        }

        /// <summary>
        /// Gets the null double.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Double}.</returns>
        public double? GetNullDouble(string name, double? defaultValue)
        {
            return _converter.ToNullDouble(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
    	public bool GetBool(string name)
        {
            return _converter.ToBool(_reader[name]);
        }

        /// <summary>
        /// Gets the bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Boolean.</returns>
        public bool GetBool(string name, bool defaultValue)
        {
            return _converter.ToBool(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the null bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{Boolean}.</returns>
        public bool? GetNullBool(string name)
        {
            return _converter.ToNullBool(_reader[name]);
        }

        /// <summary>
        /// Gets the null bool.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{Boolean}.</returns>
        public bool? GetNullBool(string name, bool? defaultValue)
        {
            return _converter.ToNullBool(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the null date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        public DateTime? GetNullDate(string name)
        {
            return _converter.ToNullDate(_reader[name]);
        }

        /// <summary>
        /// Gets the null date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Nullable{DateTime}.</returns>
        public DateTime? GetNullDate(string name, DateTime? defaultValue)
        {
            return _converter.ToNullDate(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>DateTime.</returns>
        public DateTime GetDate(string name)
        {
            return _converter.ToDate(_reader[name]);
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>DateTime.</returns>
        public DateTime GetDate(string name, DateTime defaultValue)
        {
            return _converter.ToDate(_reader[name], defaultValue);
        }

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>String.</returns>
        public string GetString(string name)
        {
            return _converter.ToString(_reader[name]);
        }

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>String.</returns>
        public string GetString(string name, string defaultValue)
        {
            return _converter.ToString(_reader[name], defaultValue).Trim();
        }

        /// <summary>
        /// Gets the char.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Char.</returns>
    	public char GetChar( string name )
    	{
    		return _converter.ToChar( _reader[name] );
    	}

        /// <summary>
        /// Gets the char.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>Char.</returns>
    	public char GetChar( string name, char defaultValue )
    	{
    		return _converter.ToChar( _reader[name], defaultValue );
    	}

        /// <summary>
        /// Gets the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns>``0.</returns>
    	public T GetEnum<T>( string name )
		{
			return GetEnum( name, default( T ) );
		}

        /// <summary>
        /// Gets the enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>``0.</returns>
		public T GetEnum<T>( string name, T defaultValue )
		{
			string value = _converter.ToString( _reader[name] );

			return string.IsNullOrEmpty( value ) ? defaultValue :
				(T)Enum.Parse( typeof( T ), value, true );
		}

        /// <summary>
        /// Returns an <see cref="T:System.Data.IDataReader" /> for the specified column ordinal.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>The <see cref="T:System.Data.IDataReader" /> for the specified column ordinal.</returns>
        public IDataReader GetData(int i)
        {
            return _reader.GetData(i);
        }

        /// <summary>
        /// Return whether the specified field is set to null.
        /// </summary>
        /// <param name="i">The index of the field to find.</param>
        /// <returns>true if the specified field is set to null; otherwise, false.</returns>
        public bool IsDBNull(int i)
        {
            return _reader.IsDBNull(i);
        }

        /// <summary>
        /// Gets the number of columns in the current row.
        /// </summary>
        /// <value>The field count.</value>
        /// <returns>When not positioned in a valid recordset, 0; otherwise, the number of columns in the current record. The default is -1.</returns>
        public int FieldCount
        {
            get { return _reader.FieldCount; }
        }

        /// <summary>
        /// Gets the column with the specified name.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns>System.Object.</returns>
        public object this[int i]
        {
            get { return _reader[i]; }
        }

        /// <summary>
        /// Gets the column with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Object.</returns>
        public object this[string name]
        {
            get { return _reader[name]; }
        }
    }
}
