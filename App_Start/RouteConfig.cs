﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Durandal1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Durandal",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Durandal", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}