using System.Web;
using System.Web.Optimization;

namespace OfflineAppSample
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/resources").Include(
                          "~/Scripts/fastclick.js"
                        , "~/Scripts/app/application/applicationcontroller.js"
                        , "~/Scripts/app/articles/articlescontroller.js"
                        , "~/Scripts/app/articles/article.js"
                        , "~/Scripts/app/datastores/network.js"
                        , "~/Scripts/app/datastores/indexeddb.js"
                        , "~/Scripts/app/datastores/websql.js"
                        , "~/Scripts/app/templates.js"
                        , "~/Scripts/app/appcache.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
        }
    }
}