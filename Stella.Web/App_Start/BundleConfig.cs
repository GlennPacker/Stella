using System.Web;
using System.Web.Optimization;

namespace Stella.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Main").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-ui-router.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/angular-animate.js",
                        "~/Scripts/angular-sanitize.js",
                        "~/Scripts/angular-cookies.js",
                        "~/Scripts/ngToast.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                        "~/Scripts/angular-ui/ui-bootstrap.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/App").Include(
                        "~/Js/app.js",
                        "~/Js/Directives/PlanetDir.js",
                        "~/Js/Controllers/PlanetController.js",

                        "~/Js/Services/CommonServices.js",
                         "~/Js/Services/PlanetResource.js",
                         "~/Js/Services/ApiResource.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/Services").Include(
                         "~/Js/Services/CommonServices.js",
                         "~/Js/Services/PlanetResource.js",
                         "~/Js/Services/ApiResource.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
