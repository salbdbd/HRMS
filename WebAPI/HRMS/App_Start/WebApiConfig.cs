using System.Web.Http;
using System.Web.UI.WebControls;

namespace HRMS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = System.Web.Http.RouteParameter.Optional}
            );
        }
    }
}