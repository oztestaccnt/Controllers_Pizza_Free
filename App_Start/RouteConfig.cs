using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lesson7ControllersLab
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "FreeBird",
               url: "free/bird/{name}/{age}/{color}",
               defaults: new { controller = "Free", action = "Bird",
                   name = UrlParameter.Optional,
                   age = UrlParameter.Optional,
                   color = UrlParameter.Optional },
               constraints: new { }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
