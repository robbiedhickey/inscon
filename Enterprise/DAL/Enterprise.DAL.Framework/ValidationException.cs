using System;
using System.Collections.Generic;

namespace Enterprise.DAL.Framework
{
	/// <summary>
	/// A validation exception represents a problem with the form or content
	/// of data processed by the application.  It involves the failure of
	/// some rule applied to the value of a given field.
	/// </summary>
	/// <author>Michael Roof</author>
	public class ValidationException : Exception
	{
		private List<ValidationError> _errors;

		public ValidationException( string violation ) : this( null, violation )
		{
		}

		public ValidationException( string field, string violation ) : this( field, violation, null )
		{
		}

		public ValidationException( string field, string violation, object value ) : base( violation )
		{
			_errors = new List<ValidationError>();

			var error = new ValidationError( field, value, violation );

			_errors.Add( error );
		}

		public ValidationException( List<ValidationError> errors )
		{
			_errors = errors;
		}

		public ValidationException( ValidationError error )
		{
			_errors = new List<ValidationError> {error};
		}

		public ValidationError FirstError
		{
			get
			{
				if( _errors == null || _errors.Count < 1 )
				{
					_errors = new List<ValidationError> {new ValidationError(null, null)};
				}

				return _errors[0];
			}
		}

		public string Field
		{
			get
			{
				return _errors != null && _errors.Count > 0 ? _errors[0].Field : "";
			}
			set
			{
				FirstError.Field = value;
			}
		}

		public object Value
		{
			get
			{
				return _errors != null && _errors.Count > 0 ? _errors[0].Value : "";
			}
			set
			{
				FirstError.Value = value;
			}
		}

		public string Violation
		{
			get
			{
				return _errors != null && _errors.Count > 0 ? _errors[0].Violation : "";
			}
			set
			{
				FirstError.Violation = value;
			}
		}

		public List<ValidationError> Errors
		{
			get { return _errors; }
			set { _errors = value; }
		}
	}
}