using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Www
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = null;
            if (Server.GetLastError() != null)
            {
                ex = Server.GetLastError().GetBaseException();
                if (ex.GetType() == typeof(HttpException))
                {
                    HttpException httpex = (HttpException)ex;
                    int httpcode = httpex.GetHttpCode();
                    if (httpcode == 404)
                    {
                        Server.Transfer("/404.aspx");
                        Server.ClearError();
                        return;
                    }
                }
                Response.Write(ex.Message);
                Server.Transfer("/error.aspx");
                Server.ClearError();
            }

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}