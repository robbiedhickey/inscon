using System;
using System.Reflection;

namespace Enterprise.DAL.Framework.Data
{
    public static class NullHandler
    {
        //  define application encoded null values 
        public static short NullShort
        {
            get { return -1; }
        }

        // TRANSMISSINGCOMMENT: Property NullInteger
        public static int NullInteger
        {
            get { return -1; }
        }

        // TRANSMISSINGCOMMENT: Property NullSingle
        public static float NullSingle
        {
            get { return float.MinValue; }
        }

        // TRANSMISSINGCOMMENT: Property NullDouble
        public static double NullDouble
        {
            get { return double.MinValue; }
        }

        // TRANSMISSINGCOMMENT: Property NullDecimal
        public static decimal NullDecimal
        {
            get { return decimal.MinValue; }
        }

        // TRANSMISSINGCOMMENT: Property NullDate
        public static DateTime NullDate
        {
            get { return DateTime.MinValue; }
        }

        // TRANSMISSINGCOMMENT: Property NullString
        public static string NullString
        {
            get { return ""; }
        }

        // TRANSMISSINGCOMMENT: Property NullBoolean
        public static bool NullBoolean
        {
            get { return false; }
        }

        // TRANSMISSINGCOMMENT: Property NullGuid
        public static Guid NullGuid
        {
            get { return Guid.Empty; }
        }


        //  sets a field to an application encoded null value ( used in BLL layer )
        public static object GetNull(PropertyInfo objPropertyInfo)
        {
            if (objPropertyInfo == null)
            {
                return null;
            }

            string type = objPropertyInfo.PropertyType.ToString();
            switch (type)
            {
                case "System.Int16":
                    return NullShort;
                case "System.Int32":
                    return NullInteger;
                case "System.Int64":
                    return NullInteger;
                case "System.Single":
                    return NullSingle;
                case "System.Double":
                    return NullDouble;
                case "System.Decimal":
                    return NullDecimal;
                case "System.DateTime":
                    return NullDate;
                case "System.String":
                    return NullString;
                case "System.Char":
                    return NullString;
                case "System.Boolean":
                    return NullBoolean;
                case "System.Guid":
                    return NullGuid;
                default:
                    {
                        //  Enumerations default to the first entry
                        Type pType = objPropertyInfo.PropertyType;
                        if (pType.BaseType == typeof (Enum))
                        {
                            Array objEnumValues = Enum.GetValues(pType);
                            Array.Sort(objEnumValues);
                            return Enum.ToObject(pType, objEnumValues.GetValue(0));
                        }
                        //  complex object
                        return null;
                    }
            }
        }

        //  checks if a field contains an application encoded null value
        public static bool IsNull(object objField)
        {
            if (objField != null)
            {
                if (objField is int)
                {
                    return objField.Equals(NullInteger);
                }
                if (objField is float)
                {
                    return objField.Equals(NullSingle);
                }
                if (objField is double)
                {
                    return objField.Equals(NullDouble);
                }
                if (objField is decimal)
                {
                    return objField.Equals(NullDecimal);
                }
                if (objField is DateTime)
                {
                    var objDate = (DateTime) objField;
                    return objDate.Date.Equals(NullDate.Date);
                }
                if (objField is string)
                {
                    return objField.Equals(NullString);
                }
                if (objField is bool)
                {
                    return objField.Equals(NullBoolean);
                }
                if (objField is Guid)
                {
                    return objField.Equals(NullGuid);
                }
                //  complex object
                return false;
            }
            return true;
        }
    }
}