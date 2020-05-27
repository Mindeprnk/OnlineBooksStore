using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineBooksStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            // This is a custom Route and they should be written before the geneeric routes else the generic routes will be executed irresptively.
            routes.MapRoute(
               name: "BooksByReleaseDate",
               url: "books/released/{year}/{month}",
               defaults: new { Controller = "Books", action = "ByReleaseDate" },
            new {year = @"\d{4}", month = @"\d{2}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
