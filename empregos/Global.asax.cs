using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Security.Principal;

namespace empregos
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Aplication_AuthenticateRequest(Object sender, EventArgs e)
        {
            var coockie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];

            if (coockie != null && !string.IsNullOrEmpty(coockie.Value))
            {
                FormsAuthenticationTicket ticket;
                try
                {
                    ticket = FormsAuthentication.Decrypt(coockie.Value);
                }
                catch { return; }

                var perfis = ticket.UserData.Split(';');
                if ((Context.User != null))
                {
                    Context.User = new GenericPrincipal(Context.User.Identity, perfis);
                }

            }

        }
    }
}
