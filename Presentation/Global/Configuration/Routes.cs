namespace Presentation.Global
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Routing;

    public partial class APITemplate
    {
        private static void RegisterRoutes()
        {
            GlobalConfiguration.Configure(c => c.MapHttpAttributeRoutes());
            RouteTable.Routes.MapMvcAttributeRoutes();
        }
    }
}