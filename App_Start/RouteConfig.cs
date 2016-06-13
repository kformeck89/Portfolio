using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Portfolio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "SendEmail",
                url: "{controller}/{action}/{name}/{email}/{phone}/{message}",
                defaults: new
                {
                    controller = "Home",
                    action = "SendEmail",
                    name = UrlParameter.Optional,
                    phone = UrlParameter.Optional,
                }
            );
        }
    }
}
