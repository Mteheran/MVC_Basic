using aspSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace aspSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            UserData.Users.Add(
            new Models.User() { Id = Guid.NewGuid().ToString(), Name = "User 1", LastName="Last Name 1", Phone=252525 });

            UserData.Users.Add(
            new Models.User() { Id = Guid.NewGuid().ToString(), Name = "User 2", LastName = "Last Name 2", Phone = 505050 });
            
            UserData.Users.Add(
            new Models.User() { Id = Guid.NewGuid().ToString(), Name = "User 3", LastName = "Last Name 3", Phone = 606060 });

        }
    }
}
