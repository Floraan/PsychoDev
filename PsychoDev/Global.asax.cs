using System;
using System.Web;

namespace PsychoDev
{
    public class Global : HttpApplication
    {
		protected void Application_BeginRequest(Object sender, EventArgs e)
		{
			if (HttpContext.Current.Request.IsSecureConnection.Equals(false) && HttpContext.Current.Request.IsLocal.Equals(false))
			{
				Response.Redirect("https://" + Request.ServerVariables["HTTP_HOST"]
			+ HttpContext.Current.Request.RawUrl);
			}
		}
        protected void Application_Start()
        {
        }
    }
}
