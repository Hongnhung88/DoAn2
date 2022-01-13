using System.Web;
using System.Web.Optimization;

namespace WebGiay
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Assets/Admin/css").Include(
                "~/Assets/Admin/vendors/mdi/css/materialdesignicons.min.css",
                "~/Assets/Admin/vendors/simple-line-icons/css/simple-line-icons.css",
                "~/Assets/Admin/vendors/flag-icon-css/css/flag-icon.min.css",
                "~/Assets/Admin/vendors/css/vendor.bundle.base.css",
                "~/Assets/Admin/vendors/font-awesome/css/font-awesome.min.css",
                "~/Assets/Admin/vendors/jquery-bar-rating/fontawesome-stars.css",
                "~/Assets/Admin/css/style.css",
                "~/Assets/Admin/css/fontsize.css"));

            bundles.Add(new ScriptBundle("~/Assets/Admin/js").Include(
                "~/Assets/Admin/vendors/js/vendor.bundle.base.js",
                "~/Assets/Admin/vendors/jquery-bar-rating/jquery.barrating.min.js",
                "~/Assets/Admin/vendors/chart.js/Chart.min.js",
                "~/Assets/Admin/vendors/raphael/raphael.min.js",
                "~/Assets/Admin/vendors/morris.js/morris.min.js",
                "~/Assets/Admin/vendors/jquery-sparkline/jquery.sparkline.min.js",
                "~/Assets/Admin/js/off-canvas.js",
                "~/Assets/Admin/js/hoverable-collapse.js",
                "~/Assets/Admin/js/misc.js",
                "~/Assets/Admin/js/settings.js",
                "~/Assets/Admin/js/todolist.js",
                "~/Assets/Admin/js/dashboard.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js"));
        }
    }
}
