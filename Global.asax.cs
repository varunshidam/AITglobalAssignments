using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GlobalDemo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Console.WriteLine("application Started");
            Application["appcode"] = 500;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //Console.WriteLine("session started");
            Session["sesscode"] = 600;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Console.WriteLine("application end");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Console.WriteLine("session end");
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}