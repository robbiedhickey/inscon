namespace Enterprise.DAL.Framework
{
	/// <summary>
	/// Summary description for ValidationError.
	/// </summary>
	/// <author>Michael Roof</author>
	public class ValidationError
	{
		private string _field;
		private object _value;
		private string _violation;

		public ValidationError( string field, object value )
		{
			_field = field;
			_value = value;
		}

		public ValidationError( string field, object value, string violation ) : this( field, value )
		{
			_violation = violation;
		}

		public string Field
		{
			get { return _field; }
			set { _field = value; }
		}

		public object Value
		{
			get { return _value; }
			set { _value = value; }
		}

		public string Violation
		{
			get { return _violation; }
			set { _violation = value; }
		}
	}
}