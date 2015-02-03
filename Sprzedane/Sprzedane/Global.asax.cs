using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Threading;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Sprzedane
{
    public class Global : System.Web.HttpApplication
    {

        public delegate void Worker();
        private static Thread worker;



        protected void Application_Start(object sender, EventArgs e)
        {
            AuctionChecker ac = new AuctionChecker();
            RouteTable.Routes.Add(new ServiceRoute("", new WebServiceHostFactory(),
            typeof(SprzedaneService)));


        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Response.Cache.SetNoStore();
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}