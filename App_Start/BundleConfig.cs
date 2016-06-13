using System.Web;
using System.Web.Optimization;

namespace Portfolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                   .Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                   .Include("~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                   .Include("~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                   .Include("~/Scripts/bootstrap.js")
                   .Include("~/Scripts/respond.js")
                   .Include("~/Scripts/jquery.easing.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/animations")
                   .Include("~/Scripts/cbpAnimatedHeader.js")
                   .Include("~/Scripts/classie.js")
                   .Include("~/Scripts/jqBootstrapValidation.js")
                   .Include("~/Scripts/freelancer.js")
                   .Include("~/Scripts/parallax.js"));
            bundles.Add(new StyleBundle("~/Content/css")
                   .Include("~/Content/bootstrap.css"));
        }
    }
}
