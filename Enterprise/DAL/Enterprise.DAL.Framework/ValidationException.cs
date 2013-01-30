// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ValidationException.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;

namespace Enterprise.DAL.Framework
{
    /// <summary>
    /// A validation exception represents a problem with the form or content
    /// of data processed by the application.  It involves the failure of
    /// some rule applied to the value of a given field.
    /// </summary>
	public class ValidationException : Exception
	{
        /// <summary>
        /// The _errors
        /// </summary>
		private List<ValidationError> _errors;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="violation">The violation.</param>
		public ValidationException( string violation ) : this( null, violation )
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="violation">The violation.</param>
		public ValidationException( string field, string violation ) : this( field, violation, null )
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="violation">The violation.</param>
        /// <param name="value">The value.</param>
		public ValidationException( string field, string violation, object value ) : base( violation )
		{
			_errors = new List<ValidationError>();

			var error = new ValidationError( field, value, violation );

			_errors.Add( error );
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="errors">The errors.</param>
		public ValidationException( List<ValidationError> errors )
		{
			_errors = errors;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="error">The error.</param>
		public ValidationException( ValidationError error )
		{
			_errors = new List<ValidationError> {error};
		}

        /// <summary>
        /// Gets the first error.
        /// </summary>
        /// <value>The first error.</value>
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

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>The field.</value>
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

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
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

        /// <summary>
        /// Gets or sets the violation.
        /// </summary>
        /// <value>The violation.</value>
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

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>The errors.</value>
		public List<ValidationError> Errors
		{
			get { return _errors; }
			set { _errors = value; }
		}
	}
}