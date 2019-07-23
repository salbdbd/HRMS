using System;
using System.Configuration;
using System.Web;
using System.Web.Http;
using Dapper.Framework;
using Newtonsoft.Json.Serialization;

namespace HRMS
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var config = GlobalConfiguration.Configuration;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var appSettings = ConfigurationManager.AppSettings;
            var connectionString = new ConnectionString
            {
                Server = appSettings["Server"],
                Port = Convert.ToInt32(appSettings["Port"]),
                Database = appSettings["Database"],
                UserId = appSettings["UserId"],
                Password = appSettings["Password"],
            };
            Connection.Initialize(connectionString);
        }
    }
}