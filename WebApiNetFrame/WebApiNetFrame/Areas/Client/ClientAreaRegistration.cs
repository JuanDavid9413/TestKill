using System.Web.Http;
using System.Web.Mvc;
using WebApiNetFrame.Areas.HelpPage;

namespace WebApiNetFrame.Areas.Client
{
    public class ClientAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Client";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Client_default",
                "Client/{action}/{id}",
                new { controller = "Client", action = "Index", id = UrlParameter.Optional }
            );
            //HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}