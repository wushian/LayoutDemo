using System.Web;
using System.Web.Optimization;

namespace LayoutDemo
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/scripts/jquery.bxslider.js",
                        "~/scripts/appjs.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css",
                        "~/Content/custom.css"));
        }
    }
}