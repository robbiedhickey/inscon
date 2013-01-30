using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace BootstrapSupport
{
    public class BootstrapBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js").Include(
                "~/Scripts/jquery-1.9.0.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/jquery.validate.js",
                "~/scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/jquery.validate.unobtrusive-custom-for-bootstrap.js",
                "~/Scripts/jquery-ui-1.10.0.js"
                ));

            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/main.css",
                "~/Content/themes/base/jquery-ui.css"
                ));
            bundles.Add(new StyleBundle("~/content/css-responsive").Include(
                "~/Content/bootstrap-responsive.css",
                "~/Content/main.css"
                ));
        }
    }
}