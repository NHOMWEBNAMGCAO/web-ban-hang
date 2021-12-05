using System.Web.Mvc;

namespace ishop.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "AdIndex", Controllers = "AdHome", id = UrlParameter.Optional },
                namespaces: new [] { "ishop.Areas.Admin.Controllers" }
            );
        }
    }
}
