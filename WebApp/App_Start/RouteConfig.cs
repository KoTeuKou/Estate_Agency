using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
            routes.MapRoute(
                "UserDB",
                "{controller}/{action}/{id}",
                new {controller = "User", action = "List", id = UrlParameter.Optional}
            );
            routes.MapRoute(
                "AwardDB",
                "{controller}/{action}/{id}",
                new {controller = "Award", action = "List", id = UrlParameter.Optional}
            );
        }
    }
}
