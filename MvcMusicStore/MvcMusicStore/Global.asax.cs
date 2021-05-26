using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MvcMusicStore.Filters;

namespace MvcMusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(
            new MvcMusicStore.Models.SampleData());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        //Used to handle errors thrown for RegisterGlobalFilters, RegisterRoutes
        //>>
        private void RegisterRoutes(RouteCollection routes)
        {
            throw new NotImplementedException();
        }

        private void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            throw new NotImplementedException();
        }
        //<<

        //Alternative:
        //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //RouteConfig.RegisterRoutes(RouteTable.Routes);

    }
}
