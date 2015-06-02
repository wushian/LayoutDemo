using System.Web.Mvc;

namespace LayoutDemo.Areas.Electronics
{
    public class ElectronicsAreaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Electronics";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Electronics_default",
                "Electronics/{controller}/{action}/{id}",
                 new { action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "LayoutDemo.Areas.Electronics.Controllers" }
            );
        }
    }
}
