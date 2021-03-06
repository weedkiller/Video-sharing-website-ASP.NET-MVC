﻿using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_Video_Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Enable MVC Attribute routing
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Media", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
