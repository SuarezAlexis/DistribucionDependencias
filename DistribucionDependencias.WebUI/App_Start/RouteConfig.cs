using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DistribucionDependencias.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "",
                defaults: new { Controller = "Producto", action = "List", categoria = (string)null, page = 1 }
            );

            routes.MapRoute(
                name: null,
                url: "Pag{page}",
                defaults: new { Controller = "Producto", action = "List", categoria = (string)null,  },
                constraints: new { page = @"\d+" }
            );

            routes.MapRoute(
                name: null,
                url: "{categoria}",
                defaults: new { Controller = "Producto", action = "List", page = 1 }
            );

            routes.MapRoute(
                name: null,
                url: "{categoria}/Pag{page}",
                defaults: new { Controller = "Producto", action = "List" },
                constraints: new { page = @"\d+" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Producto", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}
