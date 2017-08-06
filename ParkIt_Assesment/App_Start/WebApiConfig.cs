using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ParkIt_Assesment.Filters;

namespace ParkIt_Assesment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

			//Register the validation filter
			config.Filters.Add(new ValidateActionFilter());

			config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
