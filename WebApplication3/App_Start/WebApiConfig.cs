using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

//using WebApplication3.ioc;
using WebApplication3.Models;

namespace WebApplication3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
           // Web API configuration and services
           //var container = new UnityContainer();
           // container.RegisterType<IProductRepository, ProductRepository>(new HierarchicalLifetimeManager());
           // config.DependencyResolver = new UnityResolver(container);


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
