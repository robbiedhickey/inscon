using System.Collections.Generic;
using System.Configuration;

namespace Enterprise.DAL.Framework.Cache
{
	/// <summary>
	/// A cache configuration based on settings in web.config or app.config.
	/// These settings will be of the form:
	/// 
	/// cacheName.settingName
	/// </summary>
	public class CacheConfiguration : ICacheConfiguration
	{
		private readonly string _name;
		private readonly Dictionary<string, string> _config = new Dictionary<string, string>();

		public CacheConfiguration(){}
		
		public CacheConfiguration( string name )
		{
			_name = name;
			
			ReadConfiguration();
		}

		protected Dictionary<string, string> Config
		{
			get { return _config; }
		}
		
		private void ReadConfiguration()
		{
			string prefix = _name + ".";
			
			foreach( string key in ConfigurationManager.AppSettings.AllKeys )
			{
				if( key.StartsWith( prefix ) )
				{
					_config[key.Substring( prefix.Length )] = ConfigurationManager.AppSettings[key];
				}
			}

		}
		
		public string GetString( string key )
		{
			return _config.ContainsKey( key ) ? _config[key] : "";
		}
		
		public bool GetBool( string key )
		{
			return GetBool( key, false );
		}

		public bool GetBool( string key, bool defaultValue )
		{
			return _config.ContainsKey( key ) ? Converter.ToBool( _config[key] ) : defaultValue;
		}
		
		public int GetInt( string key, int defaultValue )
		{
			return _config.ContainsKey( key ) ? Converter.ToInt( _config[key], defaultValue ) : defaultValue;
		}
		
		public bool IsInstrumented
		{
			get { return GetBool( "metrics", true ); }
		}

		public bool IsSwitchable
		{
			get { return GetBool( "dynamic" ); }
		}
		
		public int MaxSize
		{
			get { return GetInt( "maxSize", -1 ); }
		}
	}
}
