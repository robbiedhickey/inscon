using System;
using System.Text.RegularExpressions;

namespace Enterprise.DAL.Framework.Data
{
   public static class DataFormat
    {
        #region Public Methods
        
        public static string FormatUSPhone(string num)
        {

            if (num != null)
            {

                //first we must remove all non numeric characters
                num = num.Replace("(", "").Replace(")", "").Replace("-", "");
                string results = string.Empty;
                const string formatPattern = @"(\d{3})(\d{3})(\d{4})";
                results = Regex.Replace(num, formatPattern, "($1) $2-$3");
                //now return the formatted phone number
                return results;
            }
            else
            {
                return String.Empty;
            }
                
            
        }

        public static string StripNonNumeric(string num)
        {
            if (num != null)
            {

            var regEx = new Regex(@"\D");
            return regEx.Replace(num, "");
            }
            else
            {
                return String.Empty;
            }
              
        }
        
        #endregion
    }
}
