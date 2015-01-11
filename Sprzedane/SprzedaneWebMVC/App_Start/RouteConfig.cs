using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SprzedaneWebMVC
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
                name: "Przedmioty",
                url: "{controller}/{action}/{id}/{serchIn}",
                defaults: new { controller = "Przedmioty", action = "Index", id = UrlParameter.Optional, serchIn = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Wyszukiwarka",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Wyszukiwarka", action = "PoNazwie", name = "" }
            );
        }
    }
}
