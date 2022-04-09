using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using FooYes.Data.Services;

namespace FooYes.Web.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            // Registering custom dataprovider class
            builder.RegisterType<SqlRestaurantDataProvider>()
                .As<IRestaurantData>()
                .InstancePerRequest();
            builder.RegisterType<RestaurantDataDBContext>().InstancePerRequest();

            builder.RegisterType<CartDataProvider>()
                .As<ICartData>()
                .SingleInstance();

            // builder.RegisterType<RestaurantDataProvider>()
            //     .As<IRestaurantData>()
            //     .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}