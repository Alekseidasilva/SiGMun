using System;
using System.Security.Principal;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace SiGMun.MVCPro
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_AuthetnticationRequest(object sender, EventArgs e)
        {
          var cookie= Context.Request.Cookies[FormsAuthentication.FormsCookieName];
          if (cookie!=null && cookie.Value!=String.Empty)
          {
              FormsAuthenticationTicket tiket;
              try
              {
                    tiket= FormsAuthentication.Decrypt(cookie.Value);
                }
              catch 
              {
                  return;
              }

              var perfis = tiket.UserData.Split(';');
              if (Context.User!=null)
              {
                  Context.User=new GenericPrincipal(Context.User.Identity,perfis);
              }


          }
        }
    }
}
