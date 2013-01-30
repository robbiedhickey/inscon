using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Enterprise.DAL.Framework.Data
{
    public class ModelHelper
    {
        public string GetDisplayName(object obj, string propertyName)

        {
            if (obj == null) return null;

            return GetDisplayName(obj.GetType(), propertyName);
        }

        public string GetDisplayName(Type type, string propertyName)

        {
            var property = type.GetProperty(propertyName);

            if (property == null)
            {
                return null;
            }
            
            return GetDisplayName(property);
        }


        public string GetDisplayName(PropertyInfo property)

        {
            var attrName = GetAttributeDisplayName(property);

            if (!string.IsNullOrEmpty(attrName))
            {
                return attrName;
            }

            var metaName = GetMetaDisplayName(property);

            return !string.IsNullOrEmpty(metaName) ? metaName : property.Name;
        }

        private string GetAttributeDisplayName(PropertyInfo property)
        {
            var atts = property.GetCustomAttributes( typeof (DisplayNameAttribute), true );

            return atts.Length == 0 ? null : ((DisplayNameAttribute) atts[0]).DisplayName;
        }


        private string GetMetaDisplayName(PropertyInfo property)

        {
            object[] atts = property.DeclaringType.GetCustomAttributes( typeof (MetadataTypeAttribute), true );

            if (atts.Length == 0)
            {
                return null;
            }


            var metaAttr = atts[0] as MetadataTypeAttribute;

            var metaProperty = metaAttr.MetadataClassType.GetProperty(property.Name);

            return metaProperty == null ? null : GetAttributeDisplayName(metaProperty);
        }
    }
}