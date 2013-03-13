using System.Web;
using System.Web.Mvc;

namespace Enterprise.ApplicationServices.InternalServices
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}