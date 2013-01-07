using System;
using System.Collections.Generic;
using log4net;
using Enterprise.DAL.Framework.Configuration;

namespace Enterprise.DAL.Framework.Cache
{
	public class CacheFactoryCreator
	{
		private static readonly ILog Log = LogManager.GetLogger( typeof( CacheFactoryCreator ) );
		private static readonly Dictionary<string, string> Mappings = new Dictionary<string, string>();

		public static void AddMapping( string name, string type )
		{
			Mappings[name] = type;	
		}

		public static ICacheFactory Create( string name )
		{
			string factoryType = Mappings.ContainsKey( name ) ?
				Mappings[name] : ConfigurationUtils.GetConfigString( name + ".cacheFactory" );

			ICacheFactory factory = null;

			if( ! string.IsNullOrEmpty( factoryType ) )
			{
				try 
				{
					string[] typeComponents = factoryType.Split(',');
					
					if( typeComponents.Length < 2 )
					{
						throw new ValidationException( "Invalid cache type declaration: " + factoryType );
					}

					var handle = Activator.CreateInstance( typeComponents[1].Trim(), typeComponents[0].Trim() );

					var target = handle.Unwrap();
					
					Log.InfoFormat( "Created new instance of {0} for cache {1}", typeComponents[0], name );

					factory = target as ICacheFactory;
				}
				catch( Exception e )
				{
					Log.Warn( "Could not create factory of configured type: " + factoryType, e);
				}
			}

			return factory;
		}
	}
}
