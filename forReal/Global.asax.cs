using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace forReal
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //
            //Create Application state variables
            System.Diagnostics.Debug.WriteLine(Application["-------------"]);
            System.Diagnostics.Debug.WriteLine(Application["TotalApplications"]);

            if (Application["TotalApplications"]==null)
            {
            Application["TotalApplications"] = 0;
            }

            Application["TotalUserSessions"] = 0;
            //Increment TotalUserSessions by 1
            Application["TotalApplications"] = (int)Application["TotalApplications"]+1;
        }
        
        void Session_Start(object sender, EventArgs e)
        {
            //increment TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            //Decrement TotalIUserSessions by 1

            //Application["TotalApplUserSessions"] = (int)Application["TotalApplUserSessions"] - 1;
        }

    }
}