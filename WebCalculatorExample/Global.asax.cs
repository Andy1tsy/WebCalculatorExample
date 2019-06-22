using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using WebCalculatorExample.CalculatorManager;
using WebCalculatorExample.DBManager;

namespace WebCalculatorExample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var builder = new ContainerBuilder();

            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<DbManager>().As<IDbManager>().SingleInstance();
            builder.RegisterType<CalcManager>().As<ICalcManager>().SingleInstance();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
