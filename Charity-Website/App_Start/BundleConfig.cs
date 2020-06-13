using System.Web;
using System.Web.Optimization;

namespace Charity_Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                "~/Scripts/App/jquery.collapsible.min.js",
                "~/Scripts/App/swiper.js",
                "~/Scripts/App/jquery.countdown.js",
                "~/Scripts/App/circle-progress.min.js",
                "~/Scripts/App/jquery.countTo.min.js",
                "~/Scripts/App/jquery.barfiller.js",
                "~/Scripts/App/custom.js"
                ));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/App/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/CSS/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
