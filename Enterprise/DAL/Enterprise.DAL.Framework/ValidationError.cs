// ***********************************************************************
// Assembly         : Enterprise.DAL.Framework
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="ValidationError.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Enterprise.DAL.Framework
{
    /// <summary>
    /// Summary description for ValidationError.
    /// </summary>
	public class ValidationError
	{
        /// <summary>
        /// The _field
        /// </summary>
		private string _field;
        /// <summary>
        /// The _value
        /// </summary>
		private object _value;
        /// <summary>
        /// The _violation
        /// </summary>
		private string _violation;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="value">The value.</param>
		public ValidationError( string field, object value )
		{
			_field = field;
			_value = value;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="value">The value.</param>
        /// <param name="violation">The violation.</param>
		public ValidationError( string field, object value, string violation ) : this( field, value )
		{
			_violation = violation;
		}

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>The field.</value>
		public string Field
		{
			get { return _field; }
			set { _field = value; }
		}

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
		public object Value
		{
			get { return _value; }
			set { _value = value; }
		}

        /// <summary>
        /// Gets or sets the violation.
        /// </summary>
        /// <value>The violation.</value>
		public string Violation
		{
			get { return _violation; }
			set { _violation = value; }
		}
	}
}